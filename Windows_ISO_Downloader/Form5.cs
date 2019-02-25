namespace Windows_ISO_Downloader
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Web;
    using System.Windows.Forms;
    using Windows_ISO_Downloader.My;

    [DesignerGenerated]
    public class Form5 : Form
    {
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        [CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel2")]
        private LinkLabel _LinkLabel2;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel3")]
        private LinkLabel _LinkLabel3;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel4")]
        private LinkLabel _LinkLabel4;
        [CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        private IContainer components;

        public Form5()
        {
            base.Load += new EventHandler(this.Form5_Load);
            this.InitializeComponent();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            this.LinkLabel2.Text = Form1.rm.GetString("Support");
            this.LinkLabel3.Text = Form1.rm.GetString("PrivacyPolicy");
            this.Label1.Text = $"{HttpUtility.HtmlDecode(Form1.rm.GetString("WinIsoDownloader"))} {"8.03"}";
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            this.PictureBox1.Image = new Bitmap(Image.FromStream(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.HeiDoc.png")));
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form5));
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.LinkLabel2 = new LinkLabel();
            this.LinkLabel3 = new LinkLabel();
            this.LinkLabel4 = new LinkLabel();
            this.PictureBox1 = new PictureBox();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.Label1.AccessibleRole = AccessibleRole.StaticText;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0xa9, 0x13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Windows ISO Downloader";
            this.Label2.AccessibleRole = AccessibleRole.StaticText;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(12, 0x1c);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x10b, 0x13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Copyright \x00a9 2016-2019 by HeiDoc V.O.F.";
            this.LinkLabel1.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new Point(12, 0x42);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new Size(0x2d, 0x13);
            this.LinkLabel1.TabIndex = 2;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "F.A.Q.";
            this.LinkLabel2.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Location = new Point(12, 0x55);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new Size(0x3a, 0x13);
            this.LinkLabel2.TabIndex = 3;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Support";
            this.LinkLabel3.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel3.AutoSize = true;
            this.LinkLabel3.Location = new Point(12, 0x68);
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.Size = new Size(90, 0x13);
            this.LinkLabel3.TabIndex = 4;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "Privacy Policy";
            this.LinkLabel4.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel4.AutoSize = true;
            this.LinkLabel4.Location = new Point(12, 0xab);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new Size(0xca, 0x13);
            this.LinkLabel4.TabIndex = 5;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "Icons by FontAwesome / CC BY";
            this.PictureBox1.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox1.Location = new Point(0x117, 50);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x89, 0x89);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            base.AccessibleRole = AccessibleRole.Window;
            base.AutoScaleDimensions = new SizeF(8f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1ac, 0xc7);
            base.Controls.Add(this.PictureBox1);
            base.Controls.Add(this.LinkLabel4);
            base.Controls.Add(this.LinkLabel3);
            base.Controls.Add(this.LinkLabel2);
            base.Controls.Add(this.LinkLabel1);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Segoe UI", 8.25f);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            this.MinimumSize = new Size(450, 250);
            base.Name = "Form5";
            this.Text = "HeiDoc.net";
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel1.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/joomla/technology-science/microsoft/67-microsoft-windows-and-office-iso-download-tool?showall=&start=4");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel2.LinkVisited = true;
            try
            {
                Process.Start("https://www.wincert.net/forum/index.php?/forum/227-windows-iso-downloader/");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel3.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/joomla/about-us/63-privacy-policy");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel4.LinkVisited = true;
            try
            {
                Process.Start("https://fontawesome.com/");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual LinkLabel LinkLabel1
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
                LinkLabel label = this._LinkLabel1;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel1 = value;
                label = this._LinkLabel1;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel2
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
                LinkLabel label = this._LinkLabel2;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel2 = value;
                label = this._LinkLabel2;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel3
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
                LinkLabel label = this._LinkLabel3;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel3 = value;
                label = this._LinkLabel3;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel4
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
                LinkLabel label = this._LinkLabel4;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel4 = value;
                label = this._LinkLabel4;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox1 = value;
            }
        }
    }
}

