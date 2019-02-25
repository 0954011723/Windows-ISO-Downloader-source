namespace Windows_ISO_Downloader
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using Windows_ISO_Downloader.My;

    [DesignerGenerated]
    public class Form3 : Form
    {
        [CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button _Button1;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        [CompilerGenerated, AccessedThroughProperty("RichTextBox1")]
        private RichTextBox _RichTextBox1;
        private IContainer components;
        public static ResourceManager rm;

        public Form3()
        {
            base.Load += new EventHandler(this.Form2_Load);
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            rm = Form1.rm;
            this.Label1.Text = rm.GetString("CheckConnection");
            this.RichTextBox1.Text = $"URL: {MyProject.Forms.Form1.WebBrowser1.Url.ToString()}{"\r\n"}Document: {MyProject.Forms.Form1.WebBrowser1.Document.Body.OuterHtml}";
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form3));
            this.Button1 = new Button();
            this.Label1 = new Label();
            this.RichTextBox1 = new RichTextBox();
            base.SuspendLayout();
            this.Button1.AccessibleRole = AccessibleRole.PushButton;
            this.Button1.Location = new Point(12, 0x93);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x4b, 40);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Label1.AccessibleRole = AccessibleRole.StaticText;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x124, 0x13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ERROR. Please check your internet connection.";
            this.RichTextBox1.AccessibleRole = AccessibleRole.Text;
            this.RichTextBox1.Location = new Point(12, 0x19);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new Size(0x196, 0x74);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            base.AcceptButton = this.Button1;
            base.AccessibleRole = AccessibleRole.Window;
            base.AutoScaleDimensions = new SizeF(8f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1ac, 0xc7);
            base.Controls.Add(this.RichTextBox1);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.Button1);
            this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            this.MaximumSize = new Size(450, 250);
            base.MinimizeBox = false;
            this.MinimumSize = new Size(450, 250);
            base.Name = "Form3";
            this.Text = "HeiDoc.net";
            base.ResumeLayout(false);
            base.PerformLayout();
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

        internal virtual RichTextBox RichTextBox1
        {
            [CompilerGenerated]
            get => 
                this._RichTextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._RichTextBox1 = value;
            }
        }
    }
}

