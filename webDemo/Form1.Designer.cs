namespace webDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goButton = new Button();
            addressBar = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            BDLT2Button = new Button();
            ButtonBDLT1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // goButton
            // 
            goButton.Location = new Point(699, 3);
            goButton.Name = "goButton";
            goButton.RightToLeft = RightToLeft.No;
            goButton.Size = new Size(75, 23);
            goButton.TabIndex = 0;
            goButton.Text = "Go!";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // addressBar
            // 
            addressBar.Location = new Point(12, 3);
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(681, 23);
            addressBar.TabIndex = 1;
            addressBar.TextChanged += addressBar_TextChanged;
            // 
            // webView21
            // 
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 32);
            webView21.Name = "webView21";
            webView21.Size = new Size(1078, 651);
            webView21.Source = new Uri("https://13520422.github.io/web_base/", UriKind.Absolute);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // BDLT2Button
            // 
            BDLT2Button.Location = new Point(780, 2);
            BDLT2Button.Name = "BDLT2Button";
            BDLT2Button.RightToLeft = RightToLeft.No;
            BDLT2Button.Size = new Size(75, 23);
            BDLT2Button.TabIndex = 4;
            BDLT2Button.Text = "Go BDLT2";
            BDLT2Button.UseVisualStyleBackColor = true;
            BDLT2Button.Click += ButtonGoBDLT2;
            // 
            // ButtonBDLT1
            // 
            ButtonBDLT1.Location = new Point(861, 3);
            ButtonBDLT1.Name = "ButtonBDLT1";
            ButtonBDLT1.RightToLeft = RightToLeft.No;
            ButtonBDLT1.Size = new Size(113, 23);
            ButtonBDLT1.TabIndex = 5;
            ButtonBDLT1.Text = "Go BDLT1";
            ButtonBDLT1.UseVisualStyleBackColor = true;
            ButtonBDLT1.Click += ButtonGoBDLT1;
            // 
            // button3
            // 
            button3.Location = new Point(980, 3);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(98, 23);
            button3.TabIndex = 6;
            button3.Text = "clear cache";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 683);
            Controls.Add(button3);
            Controls.Add(ButtonBDLT1);
            Controls.Add(BDLT2Button);
            Controls.Add(addressBar);
            Controls.Add(goButton);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goButton;
        private TextBox addressBar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button BDLT2Button;
        private Button ButtonBDLT1;
        private Button button3;
    }
}