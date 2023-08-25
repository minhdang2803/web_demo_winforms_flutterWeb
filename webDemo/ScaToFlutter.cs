using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public interface ISCAToFlutterWeb
{
    public void RedirectToScreen();
    public void SetToken();
    public void ToNamed(string data);

    public void applyToken(string token);
}
public class SCAToFlutterWeb : ISCAToFlutterWeb
{
    private Microsoft.Web.WebView2.WinForms.WebView2 _webview;
    private string url;
    private string token;
    private string _json;
    private Action<string> TokenExpiration;
    private int reconectingLimitation = 5;
    public SCAToFlutterWeb(string url, string token, Microsoft.Web.WebView2.WinForms.WebView2 webView, Action<string> TokenExpirationHandler)
    {
        this.url = url;
        this.token = token;
        this._webview = webView;
        this._json = "";
        this.TokenExpiration = TokenExpirationHandler;
        _webview.CoreWebView2.WebMessageReceived += FromFlutterWeb;
    }
    public void ToNamed(string data)
    {
        this._json = data;
        _webview.CoreWebView2.Navigate(url);
    }
    public void applyToken(string token)
    {
        this.token = token;
    }
    public async void SetToken()
    {
        string script = "setToken('" + token + "')";
        await _webview.CoreWebView2.ExecuteScriptAsync(script);
    }

    public async void RedirectToScreen()
    {
        string script = "redirectToScreen('" + _json + "')";
        await _webview.CoreWebView2.ExecuteScriptAsync(script);
    }
    void FromFlutterWeb(object sender, CoreWebView2WebMessageReceivedEventArgs args)
    {

        string messageFromFlutter = args.TryGetWebMessageAsString();
        if (messageFromFlutter == "request_token")
        {
            SetToken();
        }
        if (messageFromFlutter == "token_valid")
        {
            Task.Delay(1000);
            RedirectToScreen();
        }
        if (messageFromFlutter == "token_invalid")
        {
            if (reconectingLimitation <= 5)
            {
                this.TokenExpiration(messageFromFlutter);
                SetToken();
                reconectingLimitation++;
            }

        }
    }
}



