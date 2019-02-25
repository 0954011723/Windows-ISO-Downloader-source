namespace Windows_ISO_Downloader
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web.Script.Serialization;
    using System.Windows.Forms;
    using Windows_ISO_Downloader.My;
    using Windows_ISO_Downloader.My.Resources;

    [DesignerGenerated]
    public class Form2 : Form
    {
        [CompilerGenerated, AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [CompilerGenerated, AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        [CompilerGenerated, AccessedThroughProperty("Label10")]
        private Label _Label10;
        [CompilerGenerated, AccessedThroughProperty("Label11")]
        private Label _Label11;
        [CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label _Label3;
        [CompilerGenerated, AccessedThroughProperty("Label4")]
        private Label _Label4;
        [CompilerGenerated, AccessedThroughProperty("Label5")]
        private Label _Label5;
        [CompilerGenerated, AccessedThroughProperty("Label6")]
        private Label _Label6;
        [CompilerGenerated, AccessedThroughProperty("Label7")]
        private Label _Label7;
        [CompilerGenerated, AccessedThroughProperty("Label8")]
        private Label _Label8;
        [CompilerGenerated, AccessedThroughProperty("Label9")]
        private Label _Label9;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [CompilerGenerated, AccessedThroughProperty("RichTextBox1")]
        private RichTextBox _RichTextBox1;
        [CompilerGenerated, AccessedThroughProperty("RichTextBox2")]
        private RichTextBox _RichTextBox2;
        [CompilerGenerated, AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [CompilerGenerated, AccessedThroughProperty("TextBox10")]
        private TextBox _TextBox10;
        [CompilerGenerated, AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [CompilerGenerated, AccessedThroughProperty("TextBox3")]
        private TextBox _TextBox3;
        [CompilerGenerated, AccessedThroughProperty("TextBox4")]
        private TextBox _TextBox4;
        [CompilerGenerated, AccessedThroughProperty("TextBox5")]
        private TextBox _TextBox5;
        [CompilerGenerated, AccessedThroughProperty("TextBox6")]
        private TextBox _TextBox6;
        [CompilerGenerated, AccessedThroughProperty("TextBox7")]
        private TextBox _TextBox7;
        [CompilerGenerated, AccessedThroughProperty("TextBox8")]
        private TextBox _TextBox8;
        [CompilerGenerated, AccessedThroughProperty("TextBox9")]
        private TextBox _TextBox9;
        [CompilerGenerated, AccessedThroughProperty("WebBrowser1")]
        private WebBrowser _WebBrowser1;
        public static byte[] byteArray = new byte[0xf4240];
        public static byte[] byteArrayNorm = new byte[0xf4240];
        public static string byteString;
        private IContainer components;
        public static long fileSize;
        public static bool initialised;

        public Form2()
        {
            base.Load += new EventHandler(this.Form2_Load);
            base.Shown += new EventHandler(this.Form2_Shown);
            this.InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (initialised)
            {
                CheckBox box;
                bool flag = (box = this.CheckBox1).Checked;
                this.SetDeletionFlag("ei.cfg", ref flag);
                box.Checked = flag;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (initialised)
            {
                CheckBox box;
                bool flag = (box = this.CheckBox1).Checked;
                this.SetDeletionFlag("cversion.ini", ref flag);
                box.Checked = flag;
            }
        }

        private UDFreturn CheckUDF(string eicfg)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(eicfg);
            byte[] array = new byte[(bytes.Length - 1) + 1];
            UDFreturn freturn2 = new UDFreturn();
            bytes.CopyTo(array, 0);
            int num4 = bytes.Count<byte>() - 1;
            for (int i = 0; i <= num4; i++)
            {
                if ((bytes[i] < 0x20) | (bytes[i] > 0x7e))
                {
                    array[i] = 0x20;
                }
            }
            string str = new string(Encoding.ASCII.GetChars(array));
            int start = 100;
            do
            {
                int num = Microsoft.VisualBasic.Strings.InStr(start, Microsoft.VisualBasic.Strings.LCase(byteString), Microsoft.VisualBasic.Strings.LCase(str), CompareMethod.Binary);
                if (num == 0)
                {
                    freturn2.deletionFlag = -1;
                    return freturn2;
                }
                int count = num - 0x29;
                byte[] buffer3 = byteArray.Skip<byte>(count).Take<byte>(100).ToArray<byte>();
                if (((((buffer3[0] == 1) && (buffer3[1] == 1)) && ((buffer3[2] == 2) && (buffer3[3] == 0))) && (((buffer3[5] == 0) && (buffer3[10] == (0x18 + (eicfg.Length * 2)))) && ((buffer3[11] == 0) && ((buffer3[0x12] == 0) | (buffer3[0x12] == 5))))) && (((buffer3[0x13] == ((eicfg.Length * 2) + 1)) && (buffer3[0x24] == 0)) && (buffer3[0x25] == 0)))
                {
                    freturn2.deletionFlag = buffer3[0x12];
                    freturn2.index = count;
                    freturn2.subArray = buffer3;
                    return freturn2;
                }
                start = num + 1;
            }
            while (start <= 0xf41dc);
            freturn2.deletionFlag = -1;
            return freturn2;
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
            this.LinkLabel1.Parent = this.PictureBox1;
            this.LinkLabel1.Location = new Point(0, 0);
            this.LinkLabel1.BringToFront();
            this.LinkLabel1.Text = Form1.rm.GetString("HashArchive");
            this.RichTextBox1.Text = Form1.rm.GetString("isotools_title");
            this.RichTextBox2.Text = Form1.rm.GetString("isotools_description");
            this.Label1.Text = Form1.rm.GetString("isotools_productFamily");
            this.Label2.Text = Form1.rm.GetString("isotools_productName");
            this.Label3.Text = Form1.rm.GetString("isotools_fileDescription");
            this.Label4.Text = Form1.rm.GetString("isotools_fileName");
            this.Label5.Text = Form1.rm.GetString("isotools_fileSize");
            this.Label6.Text = Form1.rm.GetString("isotools_sha1");
            this.Label7.Text = Form1.rm.GetString("isotools_fileType");
            this.Label8.Text = Form1.rm.GetString("isotools_architecture");
            this.Label9.Text = Form1.rm.GetString("LanguageName");
            this.Label10.Text = Form1.rm.GetString("isotools_ReleaseDate");
            this.Label11.Text = Form1.rm.GetString("isotools_Notes");
            this.GroupBox1.Text = Form1.rm.GetString("isotools_Remover");
            this.CheckBox1.Text = Form1.rm.GetString("isotools_eicfg");
            this.CheckBox2.Text = Form1.rm.GetString("isotools_cversionini");
            this.Cursor = Cursors.WaitCursor;
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.TextBox7.Text = "";
            this.TextBox8.Text = "";
            this.TextBox9.Text = "";
            this.TextBox10.Text = "";
            this.WebBrowser1.Navigate("about:blank");
            this.WebBrowser1.Document.Write(string.Empty);
            this.WebBrowser1.DocumentText = "";
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            initialised = false;
            FileStream stream = null;
            bool flag = false;
            try
            {
                fileSize = new FileInfo(MyProject.Forms.Form1.OpenFileDialog1.FileName).Length;
                stream = new FileStream(MyProject.Forms.Form1.OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MessageBox.Show(Form1.rm.GetString("isotools_ErrorOpen"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = true;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
            if (!flag)
            {
                stream.Read(byteArray, 0, 0xf4240);
                stream.Close();
                byteArray.CopyTo(byteArrayNorm, 0);
                int index = 0;
                do
                {
                    if ((byteArray[index] < 0x20) | (byteArray[index] > 0x7e))
                    {
                        byteArrayNorm[index] = 0x20;
                    }
                    index++;
                }
                while (index <= 0xf423f);
                byteString = new string(Encoding.ASCII.GetChars(byteArrayNorm));
                UDFreturn freturn = this.CheckUDF("ei.cfg");
                UDFreturn freturn2 = this.CheckUDF("cversion.ini");
                if (freturn.deletionFlag > -1)
                {
                    this.CheckBox1.Enabled = true;
                    if (freturn.deletionFlag == 5)
                    {
                        this.CheckBox1.Checked = true;
                    }
                }
                else
                {
                    this.CheckBox1.Checked = false;
                    this.CheckBox1.Enabled = false;
                }
                if (freturn2.deletionFlag > -1)
                {
                    this.CheckBox2.Enabled = true;
                    if (freturn2.deletionFlag == 5)
                    {
                        this.CheckBox2.Checked = true;
                    }
                }
                else
                {
                    this.CheckBox2.Checked = false;
                    this.CheckBox2.Enabled = false;
                }
                this.InitialiseSha1();
            }
            else
            {
                this.CheckBox1.Checked = false;
                this.CheckBox1.Enabled = false;
                this.CheckBox2.Checked = false;
                this.CheckBox2.Enabled = false;
            }
            initialised = true;
            this.Cursor = Cursors.Default;
        }

        private int GetCrc(byte[] bytes)
        {
            int num = 0;
            int num2 = 0x1021;
            foreach (byte num5 in bytes)
            {
                int num3 = 0;
                do
                {
                    bool flag = (((byte) (num5 >> ((7 - num3) & 7))) & 1) > 0;
                    num = num << 1;
                    if ((((num >> 15) & 1) > 0) ^ flag)
                    {
                        num ^= num2;
                    }
                    num3++;
                }
                while (num3 <= 7);
            }
            return (num & 0xffff);
        }

        private void InitialiseSha1()
        {
            if (!this.CheckBox1.Checked && !this.CheckBox2.Checked)
            {
                bool flag;
                if (fileSize > 0x3b9aca00L)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
                if (!flag && (MessageBox.Show(Form1.rm.GetString("isotools_calculateHash"), "HeiDoc.net", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    flag = true;
                }
                if (flag)
                {
                    StreamReader reader;
                    this.Cursor = Cursors.WaitCursor;
                    SHA1 sha = SHA1.Create();
                    byte[] buffer = null;
                    StringBuilder builder = new StringBuilder();
                    bool flag2 = false;
                    string newValue = null;
                    try
                    {
                        using (FileStream stream = new FileStream(MyProject.Forms.Form1.OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            buffer = sha.ComputeHash(stream);
                        }
                    }
                    catch (Exception exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        Exception exception = exception1;
                        newValue = exception.Message;
                        flag2 = true;
                        MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                        ProjectData.ClearProjectError();
                    }
                    if (!flag2)
                    {
                        foreach (byte num2 in buffer)
                        {
                            builder.Append(num2.ToString("X2"));
                        }
                        this.TextBox6.Text = builder.ToString();
                        HttpWebResponse response = null;
                        MyProduct expression = null;
                        HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://www.heidoc.net/php/myvsdump_api.php?sha1={this.TextBox6.Text}");
                        request.UserAgent = $"Windows ISO Downloader/{"8.03"}";
                        flag2 = false;
                        try
                        {
                            response = (HttpWebResponse) request.GetResponse();
                        }
                        catch (Exception exception4)
                        {
                            ProjectData.SetProjectError(exception4);
                            Exception exception2 = exception4;
                            newValue = exception2.Message;
                            flag2 = true;
                            MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception2.Message;
                            ProjectData.ClearProjectError();
                        }
                        if (!flag2)
                        {
                            bool flag3 = false;
                            try
                            {
                                reader = new StreamReader(response.GetResponseStream());
                                string input = reader.ReadToEnd();
                                expression = new JavaScriptSerializer().Deserialize<MyProduct>(input);
                                if (Information.IsNothing(expression))
                                {
                                    newValue = Form1.rm.GetString("isotools_hashNotFound");
                                    flag3 = true;
                                }
                            }
                            catch (Exception exception5)
                            {
                                ProjectData.SetProjectError(exception5);
                                Exception exception3 = exception5;
                                newValue = exception3.Message;
                                flag3 = true;
                                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception3.Message;
                                ProjectData.ClearProjectError();
                            }
                            if (!flag3)
                            {
                                this.TextBox1.Text = expression.PRODUCTFAMILY;
                                this.TextBox2.Text = expression.PRODUCTNAME;
                                this.TextBox3.Text = expression.FILEDESCRIPTION;
                                this.TextBox4.Text = expression.FILENAME;
                                this.TextBox5.Text = expression.SIZE;
                                this.TextBox7.Text = expression.FILETYPE;
                                this.TextBox8.Text = expression.ARCHITECTURE;
                                this.TextBox9.Text = expression.LANGUAGENAME;
                                this.TextBox10.Text = expression.RELEASEDATE;
                                newValue = expression.NOTE;
                            }
                        }
                    }
                    Assembly executingAssembly = Assembly.GetExecutingAssembly();
                    reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.blank.html"));
                    string str2 = reader.ReadToEnd();
                    reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.jquery.min.js"));
                    string str3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
                    if (!this.WebBrowser1.Version.ToString().StartsWith("11.") && !this.WebBrowser1.Version.ToString().StartsWith("10."))
                    {
                        reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.css"));
                    }
                    else
                    {
                        reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.css"));
                    }
                    string str4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
                    if (!this.WebBrowser1.Version.ToString().StartsWith("11.") && !this.WebBrowser1.Version.ToString().StartsWith("10."))
                    {
                        reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.js"));
                    }
                    else
                    {
                        reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.js"));
                    }
                    string str5 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
                    str2 = str2.Replace("|*BOOTSTRAP*|", str4).Replace("|*BOOTSTRAPJS*|", str5).Replace("|*JQUERY*|", str3).Replace("|*BODY*|", newValue);
                    this.WebBrowser1.Navigate("about:blank");
                    this.WebBrowser1.Document.Write(string.Empty);
                    this.WebBrowser1.DocumentText = str2;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form2));
            this.Label4 = new Label();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.Label3 = new Label();
            this.RichTextBox1 = new RichTextBox();
            this.TextBox3 = new TextBox();
            this.Label5 = new Label();
            this.TextBox4 = new TextBox();
            this.Label6 = new Label();
            this.TextBox5 = new TextBox();
            this.Label7 = new Label();
            this.TextBox6 = new TextBox();
            this.Label8 = new Label();
            this.TextBox7 = new TextBox();
            this.Label9 = new Label();
            this.TextBox8 = new TextBox();
            this.Label10 = new Label();
            this.TextBox9 = new TextBox();
            this.Label2 = new Label();
            this.TextBox10 = new TextBox();
            this.Label1 = new Label();
            this.Label11 = new Label();
            this.WebBrowser1 = new WebBrowser();
            this.GroupBox1 = new GroupBox();
            this.CheckBox2 = new CheckBox();
            this.CheckBox1 = new CheckBox();
            this.RichTextBox2 = new RichTextBox();
            this.LinkLabel1 = new LinkLabel();
            this.PictureBox1 = new PictureBox();
            this.GroupBox1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.Label4.AccessibleRole = AccessibleRole.StaticText;
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(12, 0xa2);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x79, 0x13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Original File Name";
            this.TextBox1.Location = new Point(0xa9, 0x3f);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new Size(370, 0x1a);
            this.TextBox1.TabIndex = 2;
            this.TextBox2.Location = new Point(0xa9, 0x5f);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new Size(370, 0x1a);
            this.TextBox2.TabIndex = 4;
            this.Label3.AccessibleRole = AccessibleRole.StaticText;
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(12, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x66, 0x13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "File Description";
            this.RichTextBox1.AccessibleRole = AccessibleRole.StaticText;
            this.RichTextBox1.BorderStyle = BorderStyle.None;
            this.RichTextBox1.Enabled = false;
            this.RichTextBox1.Font = new Font("Segoe UI", 18f);
            this.RichTextBox1.Location = new Point(12, 12);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new Size(0x3d2, 0x2d);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "Microsoft SHA1 Hash Archive from my.visualstudio.com";
            this.TextBox3.Location = new Point(0xa9, 0x7f);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new Size(370, 0x1a);
            this.TextBox3.TabIndex = 6;
            this.Label5.AccessibleRole = AccessibleRole.StaticText;
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(12, 0xc2);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x79, 0x13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "File Size in MBytes";
            this.TextBox4.Location = new Point(0xa9, 0x9f);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new Size(370, 0x1a);
            this.TextBox4.TabIndex = 8;
            this.Label6.AccessibleRole = AccessibleRole.StaticText;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(12, 0xe2);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x4e, 0x13);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "SHA1 Hash";
            this.TextBox5.Location = new Point(0xa9, 0xbf);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new Size(370, 0x1a);
            this.TextBox5.TabIndex = 10;
            this.Label7.AccessibleRole = AccessibleRole.StaticText;
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(12, 0x102);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x3d, 0x13);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "File Type";
            this.TextBox6.Location = new Point(0xa9, 0xdf);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.ReadOnly = true;
            this.TextBox6.Size = new Size(370, 0x1a);
            this.TextBox6.TabIndex = 12;
            this.Label8.AccessibleRole = AccessibleRole.StaticText;
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(12, 290);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x53, 0x13);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Architecture";
            this.TextBox7.Location = new Point(0xa9, 0xff);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = true;
            this.TextBox7.Size = new Size(370, 0x1a);
            this.TextBox7.TabIndex = 14;
            this.Label9.AccessibleRole = AccessibleRole.StaticText;
            this.Label9.AutoSize = true;
            this.Label9.Location = new Point(12, 0x142);
            this.Label9.Name = "Label9";
            this.Label9.Size = new Size(0x45, 0x13);
            this.Label9.TabIndex = 0x11;
            this.Label9.Text = "Language";
            this.TextBox8.Location = new Point(0xa9, 0x11f);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.ReadOnly = true;
            this.TextBox8.Size = new Size(370, 0x1a);
            this.TextBox8.TabIndex = 0x10;
            this.Label10.AccessibleRole = AccessibleRole.StaticText;
            this.Label10.AutoSize = true;
            this.Label10.Location = new Point(12, 0x162);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x57, 0x13);
            this.Label10.TabIndex = 0x13;
            this.Label10.Text = "Release Date";
            this.TextBox9.Location = new Point(0xa9, 0x13f);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.ReadOnly = true;
            this.TextBox9.Size = new Size(370, 0x1a);
            this.TextBox9.TabIndex = 0x12;
            this.Label2.AccessibleRole = AccessibleRole.StaticText;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(12, 0x62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x61, 0x13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Product Name";
            this.TextBox10.Location = new Point(0xa9, 0x15f);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.Size = new Size(370, 0x1a);
            this.TextBox10.TabIndex = 20;
            this.Label1.AccessibleRole = AccessibleRole.StaticText;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(12, 0x42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(100, 0x13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Product Family";
            this.Label11.AccessibleRole = AccessibleRole.StaticText;
            this.Label11.AutoSize = true;
            this.Label11.Location = new Point(12, 0x182);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x2d, 0x13);
            this.Label11.TabIndex = 0x15;
            this.Label11.Text = "Notes";
            this.WebBrowser1.AccessibleRole = AccessibleRole.Text;
            this.WebBrowser1.AllowWebBrowserDrop = false;
            this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser1.Location = new Point(0xa9, 0x180);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.Size = new Size(0x335, 0xc4);
            this.WebBrowser1.TabIndex = 0x16;
            this.WebBrowser1.WebBrowserShortcutsEnabled = false;
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.RichTextBox2);
            this.GroupBox1.Location = new Point(0x221, 0x3f);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1bd, 0x13a);
            this.GroupBox1.TabIndex = 0x18;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ei.cfg and cversion.ini remover";
            this.CheckBox2.AccessibleRole = AccessibleRole.CheckButton;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Enabled = false;
            this.CheckBox2.Location = new Point(6, 0x11d);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new Size(0xf8, 0x17);
            this.CheckBox2.TabIndex = 0x1b;
            this.CheckBox2.Text = "remove cversion.ini from ISO image";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox1.AccessibleRole = AccessibleRole.CheckButton;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Enabled = false;
            this.CheckBox1.Location = new Point(6, 0x100);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new Size(0xd4, 0x17);
            this.CheckBox1.TabIndex = 0x1a;
            this.CheckBox1.Text = "remove ei.cfg from ISO image";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.RichTextBox2.AccessibleRole = AccessibleRole.StaticText;
            this.RichTextBox2.Font = new Font("Segoe UI", 10.25f);
            this.RichTextBox2.Location = new Point(7, 0x1a);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.ReadOnly = true;
            this.RichTextBox2.Size = new Size(0x1b0, 0xe0);
            this.RichTextBox2.TabIndex = 0x19;
            this.RichTextBox2.Text = manager.GetString("RichTextBox2.Text");
            this.LinkLabel1.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel1.AutoEllipsis = true;
            this.LinkLabel1.BackColor = Color.Transparent;
            this.LinkLabel1.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel1.Location = new Point(8, 0x213);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new Size(0x67, 0x18);
            this.LinkLabel1.TabIndex = 0x17;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Hash Archive";
            this.LinkLabel1.TextAlign = ContentAlignment.TopCenter;
            this.PictureBox1.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox1.Image = Windows_ISO_Downloader.My.Resources.Resources.compact_disc;
            this.PictureBox1.Location = new Point(12, 0x213);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x69, 0x2e);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0x34;
            this.PictureBox1.TabStop = false;
            base.AccessibleRole = AccessibleRole.Window;
            base.AutoScaleDimensions = new SizeF(8f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3ea, 0x24d);
            base.Controls.Add(this.LinkLabel1);
            base.Controls.Add(this.PictureBox1);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.WebBrowser1);
            base.Controls.Add(this.Label11);
            base.Controls.Add(this.TextBox10);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TextBox9);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.TextBox8);
            base.Controls.Add(this.Label10);
            base.Controls.Add(this.TextBox7);
            base.Controls.Add(this.Label9);
            base.Controls.Add(this.TextBox6);
            base.Controls.Add(this.Label8);
            base.Controls.Add(this.TextBox5);
            base.Controls.Add(this.Label7);
            base.Controls.Add(this.TextBox4);
            base.Controls.Add(this.Label6);
            base.Controls.Add(this.TextBox3);
            base.Controls.Add(this.Label5);
            base.Controls.Add(this.RichTextBox1);
            base.Controls.Add(this.TextBox2);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.Label4);
            this.Cursor = Cursors.WaitCursor;
            this.Font = new Font("Segoe UI", 8.25f);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            this.MinimumSize = new Size(0x400, 640);
            base.Name = "Form2";
            this.Text = "HeiDoc.net";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel1.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/php/myvsdump.php");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void SetDeletionFlag(string eicfg, ref bool flag)
        {
            UDFreturn freturn = this.CheckUDF(eicfg);
            if (flag)
            {
                freturn.subArray[0x12] = 5;
            }
            else
            {
                freturn.subArray[0x12] = 0;
            }
            byte[] bytes = BitConverter.GetBytes(this.GetCrc(freturn.subArray.Skip<byte>(0x10).Take<byte>(freturn.subArray[10]).ToArray<byte>()));
            freturn.subArray[8] = bytes[0];
            freturn.subArray[9] = bytes[1];
            int num = 0;
            int index = 0;
            do
            {
                if (index != 4)
                {
                    num += freturn.subArray[index];
                }
                index++;
            }
            while (index <= 15);
            byte[] buffer2 = BitConverter.GetBytes(num);
            freturn.subArray[4] = buffer2[0];
            byte[] array = new byte[0xf4240];
            FileStream stream = null;
            bool flag2 = false;
            bool flag3 = false;
            try
            {
                stream = new FileStream(MyProject.Forms.Form1.OpenFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MessageBox.Show(Form1.rm.GetString("isotools_ErrorWrite1"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag2 = true;
                flag = !flag;
                MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
            if (!flag2)
            {
                stream.Read(array, 0, 0xf4240);
                if (!byteArray.SequenceEqual<byte>(array))
                {
                    MessageBox.Show(Form1.rm.GetString("isotools_ErrorWrite2"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    flag3 = true;
                }
            }
            if (!flag2 && !flag3)
            {
                stream.Position = freturn.index;
                stream.Write(freturn.subArray, 0, 100);
                stream.Position = 0L;
                stream.Read(byteArray, 0, 0xf4240);
            }
            if (!flag2)
            {
                stream.Close();
            }
            if (!flag2 && !flag3)
            {
                MessageBox.Show(Form1.rm.GetString("isotools_Success"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (!flag2 && !flag3)
            {
                byteArray.CopyTo(byteArrayNorm, 0);
                int num3 = 0;
                do
                {
                    if ((byteArray[num3] < 0x20) | (byteArray[num3] > 0x7e))
                    {
                        byteArrayNorm[num3] = 0x20;
                    }
                    num3++;
                }
                while (num3 <= 0xf423f);
                byteString = new string(Encoding.ASCII.GetChars(byteArrayNorm));
                if (this.TextBox6.Text == "")
                {
                    this.InitialiseSha1();
                }
            }
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString() != "about:blank")
            {
                e.Cancel = true;
                try
                {
                    Process.Start(e.Url.ToString());
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    MyProject.Forms.Form1.ToolStripStatusLabel1.Text = exception.Message;
                    ProjectData.ClearProjectError();
                }
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

        internal virtual CheckBox CheckBox1
        {
            [CompilerGenerated]
            get => 
                this._CheckBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox1_CheckedChanged);
                CheckBox box = this._CheckBox1;
                if (box != null)
                {
                    box.CheckedChanged -= handler;
                }
                this._CheckBox1 = value;
                box = this._CheckBox1;
                if (box != null)
                {
                    box.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox2
        {
            [CompilerGenerated]
            get => 
                this._CheckBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox2_CheckedChanged);
                CheckBox box = this._CheckBox2;
                if (box != null)
                {
                    box.CheckedChanged -= handler;
                }
                this._CheckBox2 = value;
                box = this._CheckBox2;
                if (box != null)
                {
                    box.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this._GroupBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._GroupBox1 = value;
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

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label10 = value;
            }
        }

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label11 = value;
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label Label9
        {
            [CompilerGenerated]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label9 = value;
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

        internal virtual RichTextBox RichTextBox2
        {
            [CompilerGenerated]
            get => 
                this._RichTextBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._RichTextBox2 = value;
            }
        }

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox1 = value;
            }
        }

        internal virtual TextBox TextBox10
        {
            [CompilerGenerated]
            get => 
                this._TextBox10;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox10 = value;
            }
        }

        internal virtual TextBox TextBox2
        {
            [CompilerGenerated]
            get => 
                this._TextBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox2 = value;
            }
        }

        internal virtual TextBox TextBox3
        {
            [CompilerGenerated]
            get => 
                this._TextBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox3 = value;
            }
        }

        internal virtual TextBox TextBox4
        {
            [CompilerGenerated]
            get => 
                this._TextBox4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox4 = value;
            }
        }

        internal virtual TextBox TextBox5
        {
            [CompilerGenerated]
            get => 
                this._TextBox5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox5 = value;
            }
        }

        internal virtual TextBox TextBox6
        {
            [CompilerGenerated]
            get => 
                this._TextBox6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox6 = value;
            }
        }

        internal virtual TextBox TextBox7
        {
            [CompilerGenerated]
            get => 
                this._TextBox7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox7 = value;
            }
        }

        internal virtual TextBox TextBox8
        {
            [CompilerGenerated]
            get => 
                this._TextBox8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox8 = value;
            }
        }

        internal virtual TextBox TextBox9
        {
            [CompilerGenerated]
            get => 
                this._TextBox9;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox9 = value;
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
                WebBrowserNavigatingEventHandler handler = new WebBrowserNavigatingEventHandler(this.WebBrowser1_Navigating);
                CancelEventHandler handler2 = new CancelEventHandler(this.WebBrowser1_NewWindow);
                WebBrowser browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.Navigating -= handler;
                    browser.NewWindow -= handler2;
                }
                this._WebBrowser1 = value;
                browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.Navigating += handler;
                    browser.NewWindow += handler2;
                }
            }
        }
    }
}

