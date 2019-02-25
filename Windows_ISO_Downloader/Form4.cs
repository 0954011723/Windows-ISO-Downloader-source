namespace Windows_ISO_Downloader
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Forms;
    using Windows_ISO_Downloader.My;

    [DesignerGenerated]
    public class Form4 : Form
    {
        [CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button _Button1;
        [CompilerGenerated, AccessedThroughProperty("Button2")]
        private Button _Button2;
        [CompilerGenerated, AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("WebBrowser1")]
        private WebBrowser _WebBrowser1;
        [CompilerGenerated, AccessedThroughProperty("WebBrowser2")]
        private WebBrowser _WebBrowser2;
        private IContainer components;
        public static int countdown = 120;
        public static int CS_NOCLOSE = 0x200;
        public static bool init = false;

        public Form4()
        {
            base.Load += new EventHandler(this.Form4_Load);
            base.Shown += new EventHandler(this.Form4_Shown);
            base.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WebBrowser1.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Timer1.Enabled && !MyProject.Forms.Form1.CheckBox2.Checked)
            {
                e.Cancel = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = Form1.rm.GetString("ads_sponsor");
            this.Button1.Text = Form1.rm.GetString("ads_refresh");
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            this.WebBrowser1.Navigate($"https://www.wincert.net/ads/sponsor.php?lang={Form1.rm.GetString("TechBenchUrl")}");
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string str = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.blank.html")).ReadToEnd();
            StreamReader reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.jquery.min.js"));
            string newValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            if (!this.WebBrowser2.Version.ToString().StartsWith("11.") && !this.WebBrowser2.Version.ToString().StartsWith("10."))
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.css"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.css"));
            }
            string str3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            if (!this.WebBrowser2.Version.ToString().StartsWith("11.") && !this.WebBrowser2.Version.ToString().StartsWith("10."))
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.js"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.js"));
            }
            string str4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            str = str.Replace("|*BOOTSTRAP*|", str3).Replace("|*BOOTSTRAPJS*|", str4).Replace("|*JQUERY*|", newValue).Replace("|*BODY*|", $"<small><small id="text">{Form1.rm.GetString("ads_remove")}</small></small>");
            this.WebBrowser2.Navigate("about:blank");
            this.WebBrowser2.Document.Write(string.Empty);
            this.WebBrowser2.DocumentText = str;
            init = true;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form4));
            this.WebBrowser1 = new WebBrowser();
            this.Button1 = new Button();
            this.WebBrowser2 = new WebBrowser();
            this.Timer1 = new Timer(this.components);
            this.Button2 = new Button();
            base.SuspendLayout();
            this.WebBrowser1.AllowWebBrowserDrop = false;
            this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser1.Location = new Point(12, 12);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.ScrollBarsEnabled = false;
            this.WebBrowser1.Size = new Size(0x324, 0x213);
            this.WebBrowser1.TabIndex = 0;
            this.WebBrowser1.WebBrowserShortcutsEnabled = false;
            this.Button1.AccessibleRole = AccessibleRole.PushButton;
            this.Button1.Location = new Point(600, 0x225);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x69, 0x1c);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Refresh Video";
            this.Button1.UseVisualStyleBackColor = true;
            this.WebBrowser2.AccessibleRole = AccessibleRole.StaticText;
            this.WebBrowser2.AllowNavigation = false;
            this.WebBrowser2.AllowWebBrowserDrop = false;
            this.WebBrowser2.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser2.Location = new Point(12, 0x225);
            this.WebBrowser2.MinimumSize = new Size(20, 20);
            this.WebBrowser2.Name = "WebBrowser2";
            this.WebBrowser2.ScriptErrorsSuppressed = true;
            this.WebBrowser2.ScrollBarsEnabled = false;
            this.WebBrowser2.Size = new Size(0x246, 0x1c);
            this.WebBrowser2.TabIndex = 1;
            this.WebBrowser2.WebBrowserShortcutsEnabled = false;
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 0x3e8;
            this.Button2.AccessibleDescription = "Close";
            this.Button2.AccessibleRole = AccessibleRole.PushButton;
            this.Button2.Enabled = false;
            this.Button2.Location = new Point(0x2c7, 0x225);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0x69, 0x1c);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = true;
            base.AccessibleDescription = "";
            base.AccessibleRole = AccessibleRole.Window;
            base.AutoScaleDimensions = new SizeF(8f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x33c, 0x24d);
            base.Controls.Add(this.Button2);
            base.Controls.Add(this.WebBrowser2);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.WebBrowser1);
            this.Font = new Font("Segoe UI", 8.25f);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            this.MaximumSize = new Size(850, 640);
            this.MinimumSize = new Size(850, 640);
            base.Name = "Form4";
            this.Text = "A Message from our Sponsors...";
            base.ResumeLayout(false);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            this.Button2.Text = Conversions.ToString(countdown);
            if (countdown <= 0)
            {
                this.Timer1.Enabled = false;
                this.Button2.Enabled = true;
                this.Button2.Text = Form1.rm.GetString("ads_close");
            }
        }

        private void WebBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            if (this.WebBrowser1.StatusText.StartsWith("https://") | this.WebBrowser1.StatusText.StartsWith("http://"))
            {
                e.Cancel = true;
                try
                {
                    Process.Start(this.WebBrowser1.StatusText);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    e.Cancel = false;
                    MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void WebBrowser2_NewWindow(object sender, CancelEventArgs e)
        {
            if (this.WebBrowser2.StatusText.StartsWith("https://") | this.WebBrowser2.StatusText.StartsWith("http://"))
            {
                e.Cancel = true;
                try
                {
                    Process.Start(this.WebBrowser2.StatusText);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    e.Cancel = false;
                    MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                    ProjectData.ClearProjectError();
                }
            }
        }

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                Button button = this._Button1;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button1 = value;
                button = this._Button1;
                if (button != null)
                {
                    button.Click += handler;
                }
            }
        }

        internal virtual Button Button2
        {
            [CompilerGenerated]
            get => 
                this._Button2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Button2_Click);
                Button button = this._Button2;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button2 = value;
                button = this._Button2;
                if (button != null)
                {
                    button.Click += handler;
                }
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;
                return createParams;
            }
        }

        internal virtual Timer Timer1
        {
            [CompilerGenerated]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                Timer timer = this._Timer1;
                if (timer != null)
                {
                    timer.Tick -= handler;
                }
                this._Timer1 = value;
                timer = this._Timer1;
                if (timer != null)
                {
                    timer.Tick += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowser1
        {
            [CompilerGenerated]
            get => 
                this._WebBrowser1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                CancelEventHandler handler = new CancelEventHandler(this.WebBrowser1_NewWindow);
                WebBrowser browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.NewWindow -= handler;
                }
                this._WebBrowser1 = value;
                browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.NewWindow += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowser2
        {
            [CompilerGenerated]
            get => 
                this._WebBrowser2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                CancelEventHandler handler = new CancelEventHandler(this.WebBrowser2_NewWindow);
                WebBrowser browser = this._WebBrowser2;
                if (browser != null)
                {
                    browser.NewWindow -= handler;
                }
                this._WebBrowser2 = value;
                browser = this._WebBrowser2;
                if (browser != null)
                {
                    browser.NewWindow += handler;
                }
            }
        }
    }
}

