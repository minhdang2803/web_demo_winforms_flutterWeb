# Background knownledges
From SCA, to make a connection to Flutter Web, we should use **JavaScript** on Web Browser (Webview2 ....) and vice versa. In this document, We will know how SCA communucates with Flutter Web to display some kind of events such as (Bé Đến Là Tặng, Quà Tặng may mắn ...). This README explains everything in detail, the way how to construct a channel to make the communication between SCA and Flutter Web through JavaScript on Browser.

### Some main points to remember
-   SCA and Flutter Web receives JavaScript returns from Browser (here I use Webview2 as a Browser).
-   SCA invokes JavaScript functions to send data to Flutter Web (Which handles the contents of websites)
-   Flutter Web sends back data to SCA by invoking JavaScript functions.
-   **Except the access token, the data which is sent between two platfoms should be in JSON.**

# How SCA communicate to Flutter Web?
![SCA to Flutter Web](https://lh3.googleusercontent.com/drive-viewer/AITFw-w0yRLtQSnWDYhpWYBUyfK00DaW36-EsY5gtEoAsIbucYyse_0YDXGpv5qPjdKwMNdUwOl0YsnLRfGXbbBZ6dEc-kyfjw=s1600)

# SCA Side (this repository)

![Example SCA repository](https://lh3.googleusercontent.com/drive-viewer/AITFw-w3_IujfXqk7hvmCKjT36M-U7XdEhiD4Zlb532dDKK5N9oDZMrOAd2Bxws6y6PK95wO0-6O0PTVr93i-lQkaeo_7wY3bw=s2560)

For the SCA, I made a class that handles the communication **ScaToFlutter.cs**
-   **ISCAToFlutterWeb**: an interface which is used by **Controller/View-Model/Presenter Layer**, contains methods that help developers to handles the tokens and connection to Flutter Web
-   **SCAToFlutterWeb**: A concrete class implementings all methods and properties in **ISCAToFlutterWeb** interface, It contains some properties such as url, token, _webview... which will be explain in detail below.
    * **token**: an Access Token generated when user login to SCA, which also needed to use for accessing the resources of screens and events in Flutter Web.
    * **url**: The URL to The Flutter Website, only to the ConCung splash screen to validate Access Token.
    * **_json**: The data is sent to Flutter through JavaScript, it must be in JSON and has at two pair of key-value.
    * **_webview**: the Webview2 instance supported by ```Microsoft.Web.WebView2.WinForm``` library.
    * **TokenExpiration**: the Callback to handle Expired Access Token.
* **DataToFlutterWebModel.cs**: An example data class that should be parse to JSON to send to Flutter Web
* **Data.cs**: User data for example, contains user infomation and Access Token.
* **SeriviceLocator.cs** A simple SerivceLocator pattern to get Data from anywhere without any dependencies.

## Data to be sent

The data sent from SCA should be in JSON and it need 2 field:
*   pageName: the route to a specific page in Website, for an example:
    * **/bdlt** -> "go to Bé đến là tặng"  event screen.
    * **/bdlt2** -> go to "Bé đến là tặng v2" event screen.
    * **/paymentQR** go to Payment Screen using QR code.
* *data*: the main data to website in **JSON**, it should be a Page model, see **DataToFlutterWebModel.cs**,
* Example for the full data to sent to Web: 
```JSON {r class.source="bg-danger", class.output="bg-warning"}
{
  "pageName": "/bdlt",
  "data": {
    "TotalRecord": 0,
    "OSCSID": 0,
    "ClearStockID": null,
    "StoreID": 0,
    "PID": 109687,
    "ReferenceID": null,
    "ProductName": "PQT 20k mua đồ chơi(BDLT)",
    "ProductID": "1920000001228",
    "MaxQuantity": 0,
    "OutputQuantity": null,
    "VAT": 5,
    "PriceAfterVAT": 0.0,
    "CreatedDate": "0001-01-01T00:00:00",
    "CreatedUserName": null,
    "CreatedFullName": null,
    "DefectID": "CST23052256280250",
    "MaxQuantityOrder": null,
    "CategoryID": 1920,
    "CustomerMemberTypeID": 0,
    "FixedQuantity": 1,
    "StockQuantity": 4,
    "IsOnlineGift": true,
    "Version": 1,
    "BackgroundMobileFirst": null,
    "BackgroundMobileSecond": null
  }
}
```

## How SCA Listens to responses from the Web Browser?

* To listen to JavaScript returns, we use the **WebMessageReceived**, this method listens to all resonpse from JavaScript, it should be initialized from the Constructor of SCAToFlutterWeb class.
```cs
     _webview.CoreWebView2.WebMessageReceived += FromFlutterWeb;
```
* **FromFlutterWeb** is the method that handles all response from Webview2, it is like a controller which receives requests and makes responses to Webview
```cs
private int reconectingLimitation = 5;
void FromFlutterWeb(object sender, CoreWebView2WebMessageReceivedEventArgs args)
    {
        // Get the message from Webview2
        string messageFromFlutter = args.TryGetWebMessageAsString();
        
        // For each messages: there should be different ways to response back to Webview2
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
        //if(messageFromFlutter == "...") {} -> other activities
    }
```
* **The messages such as: "request_token" "token_valid" should be agreed by both SCA and Flutter team members**
## How SCA make responses to Webview2
From SCA, we use **ExecueScriptAsync** to send data to Flutter by invoking JS methods, The **script** will be the JS method which has parameters in String, the ExecuteScriptAsynce will make the method invocation.
```cs
await _webview.CoreWebView2.ExecuteScriptAsync(script);
```
for an example:
```cs
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
```
# How to run the Demo:

* Run Flutter Web (https://bitbucket.org/concung/cci.web.flutter/src/master/)
* Copy the local URL of Flutter web splash screen to InitializeAsync(), for an example: **"http://localhost:59732/splash"**
```cs
private string
async void InitializeAsync()
{
    await webView21.EnsureCoreWebView2Async(null);
    //Register User data to Service Locator
    ServiceLocator.Instance.Register("user", new UserData(tokenHere));
    adapter = new SCAToFlutterWeb("http://localhost:59732/splash", token, webView21, TokenExpirationHandler: HandleExpiredToken);
}
```
* press Button (Go BDLT, Go BDLT2 ...)

Note: If the CORS policy happens, make sure you have already started the proxy server (in cci.web.flutter/Server) then run the command:
```bash
$node app.js
```
# Flutter Side

In the flutter side, the Splash screen always be the only one entry point, where handle the token expiration and navigate to each Event's content page such as (BDLT, QRPayment)...

## Main points to know

* **Flutter team members** create JS function that can be called during a communications.
->  Which means SCA team members only use **functions that are created by Flutter team members**, they do not create any JS functions.
* The navigation inside the website is handled by Flutter team members, the SCA only navigate to the ConCung Splash Screen.
## How to create JS functions?
1. In **/Client/web/javascript_dart/**, create a .js extension file, the rules for naming:
    *   Using **snake_case**.
    *   Using the name of the page that use it function: For an example, if a page is **SplashScreen**, and we need some JS functions that will be used when user interacts with that page, we should name **splash.js** or **splash_screen.js**.
2. Writing the JS functions as normal.
3. To notify the listener in SCA (C# Winforms), use the method **postMessage(message)**, message should be in **String**, the message should be both agreed by Flutter and SCA team members!
```js
window.chrome.webview.postMessage(message);
```
Example:
```js
function requestTokenFromSCA(message) {
    //message = "request_token"
    window.chrome.webview.postMessage(message)
}
```
4. import the .js extension file to **/web/index.html**
## How Flutter listens to JavaScript returns?

![JSToDartFunciton](https://lh3.googleusercontent.com/drive-viewer/AITFw-xeQWKYQRGw4qXS3FGZ9ScL2G5ffW2RaT4dos07piMFqIIJUA9rQHSLw_NVvhBnbbRfdFCLZfd84kSXBMFERj1mPXFbqQ=s2560)

In each screen directory, for an example: splash screen's directory - **"/Client/lib/presentation/splash/"**

![Splash screen directory in Flutter Web repository](https://lh3.googleusercontent.com/drive-viewer/AITFw-xD1UklWA-XdssNxVrnCp_5esYBTIiqOfhJYGDDF8JXOV7F7OPaJSUHl3ux47xE-AXHsWHnQIuqI-pIRoBKMallzslhiA=s2560)
We should make a directory name **javascript**,which contains all the adapter that allow to use a function can be called in JavaScript, function must have the keyword **external**, external function is a function whose body is provided separately from its declaration.
```dart
@JS()
library channel_function;

import 'package:js/js.dart';
export 'package:js/js.dart' show allowInterop, allowInteropCaptureThis;

@JS('setToken')
external set setToken(void Function(Object obj) f);

@JS('redirectToScreen')
external set redirectToScreen(void Function(Object obj) f);

@JS('paymentExpired')
external bool paymentExpired(Object obj);

@JS('paymentSuccess')
external set paymentSuccess(void Function(Object obj) f);
```
The body of these Functions will be implemented in each Screen's controller, for the SplashScreen:
```dart
  Future<void> onInit() async {
//Handle the body of SetToken() (SetToken is a JS function), when the JS function is invoked, It will also be invoked in Dart, and the function f inside allowInterop(f) will executed.
    setToken = allowInterop(_setToken); 
    redirectToScreen = allowInterop(_redirectToScreen);
    super.onInit();
  }

//Implementations of the JSfunctions
  void _setToken(Object token) {
    final tokenInString = token.toString();
    bool isExpired = validateTokenFromSCA(tokenInString);
    if (!isExpired) {
      //If token valid -> Pass to SCA a flag == true
      CcApplication.instance.apply((_this) {
        _this.token = token.toString();
        _this.save();
      });
      invokeJSFunction("responseTokenToSCA", ["token_valid"]);
    } else {
      //If token is inValid -> Pass to SCA a flag == false
      invokeJSFunction("responseTokenToSCA", ["token_invalid"]);
    }
  }
  void _redirectToScreen(Object pageInfo) {
    var map = json.decode(pageInfo.toString());
    // Argument to a Page page
    var argument = {
      "argument": map["argument"] ?? "",
      "pageName": map["pageName"] ?? "",
      "data": map["data"] ?? null
    };
    //Navigate to page
    this.pageNext = map["pageName"] ?? "";
    if (this.pageNext.isNotEmpty) {
      Get.toNamed(pageNext, arguments: argument);
    }
  }
```
## How to invoke a JS Function in Flutter?
Using the method **invokeJSFunction** in mixin **ScaToFlutterMixin** from **sca_to_flutter_channel.dart**: 
* Path: **Client/modules/base/lib/util/helper/sca_to_flutter_channel.dart**
```dart
import 'dart:js' as js;

mixin ScaToFlutterMixin {
  void invokeJSFunction(String functionName, List<dynamic>? arguments) =>
      js.context.callMethod(functionName, arguments);
}

```

