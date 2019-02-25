namespace Windows_ISO_Downloader
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web;
    using System.Windows.Forms;
    using System.Xml;
    using Windows_ISO_Downloader.My;
    using Windows_ISO_Downloader.My.Resources;

    [DesignerGenerated]
    public class Form1 : Form
    {
        private float $STATIC$Wait$2011C$start;
        [CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button _Button1;
        [CompilerGenerated, AccessedThroughProperty("Button2")]
        private Button _Button2;
        [CompilerGenerated, AccessedThroughProperty("Button3")]
        private Button _Button3;
        [CompilerGenerated, AccessedThroughProperty("Button4")]
        private Button _Button4;
        [CompilerGenerated, AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [CompilerGenerated, AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [CompilerGenerated, AccessedThroughProperty("CheckBox3")]
        private CheckBox _CheckBox3;
        [CompilerGenerated, AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [CompilerGenerated, AccessedThroughProperty("ComboBox2")]
        private ComboBox _ComboBox2;
        [CompilerGenerated, AccessedThroughProperty("ComboBox3")]
        private ComboBox _ComboBox3;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
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
        [CompilerGenerated, AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel2")]
        private LinkLabel _LinkLabel2;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel3")]
        private LinkLabel _LinkLabel3;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel4")]
        private LinkLabel _LinkLabel4;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel5")]
        private LinkLabel _LinkLabel5;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel6")]
        private LinkLabel _LinkLabel6;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel7")]
        private LinkLabel _LinkLabel7;
        [CompilerGenerated, AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;
        [CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [CompilerGenerated, AccessedThroughProperty("PictureBox10")]
        private PictureBox _PictureBox10;
        [CompilerGenerated, AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;
        [CompilerGenerated, AccessedThroughProperty("PictureBox3")]
        private PictureBox _PictureBox3;
        [CompilerGenerated, AccessedThroughProperty("PictureBox4")]
        private PictureBox _PictureBox4;
        [CompilerGenerated, AccessedThroughProperty("PictureBox5")]
        private PictureBox _PictureBox5;
        [CompilerGenerated, AccessedThroughProperty("PictureBox6")]
        private PictureBox _PictureBox6;
        [CompilerGenerated, AccessedThroughProperty("PictureBox7")]
        private PictureBox _PictureBox7;
        [CompilerGenerated, AccessedThroughProperty("PictureBox8")]
        private PictureBox _PictureBox8;
        [CompilerGenerated, AccessedThroughProperty("PictureBox9")]
        private PictureBox _PictureBox9;
        [CompilerGenerated, AccessedThroughProperty("RadioButton1")]
        private RadioButton _RadioButton1;
        [CompilerGenerated, AccessedThroughProperty("RadioButton10")]
        private RadioButton _RadioButton10;
        [CompilerGenerated, AccessedThroughProperty("RadioButton11")]
        private RadioButton _RadioButton11;
        [CompilerGenerated, AccessedThroughProperty("RadioButton12")]
        private RadioButton _RadioButton12;
        [CompilerGenerated, AccessedThroughProperty("RadioButton13")]
        private RadioButton _RadioButton13;
        [CompilerGenerated, AccessedThroughProperty("RadioButton14")]
        private RadioButton _RadioButton14;
        [CompilerGenerated, AccessedThroughProperty("RadioButton15")]
        private RadioButton _RadioButton15;
        [CompilerGenerated, AccessedThroughProperty("RadioButton16")]
        private RadioButton _RadioButton16;
        [CompilerGenerated, AccessedThroughProperty("RadioButton17")]
        private RadioButton _RadioButton17;
        [CompilerGenerated, AccessedThroughProperty("RadioButton18")]
        private RadioButton _RadioButton18;
        [CompilerGenerated, AccessedThroughProperty("RadioButton19")]
        private RadioButton _RadioButton19;
        [CompilerGenerated, AccessedThroughProperty("RadioButton2")]
        private RadioButton _RadioButton2;
        [CompilerGenerated, AccessedThroughProperty("RadioButton20")]
        private RadioButton _RadioButton20;
        [CompilerGenerated, AccessedThroughProperty("RadioButton21")]
        private RadioButton _RadioButton21;
        [CompilerGenerated, AccessedThroughProperty("RadioButton22")]
        private RadioButton _RadioButton22;
        [CompilerGenerated, AccessedThroughProperty("RadioButton23")]
        private RadioButton _RadioButton23;
        [CompilerGenerated, AccessedThroughProperty("RadioButton24")]
        private RadioButton _RadioButton24;
        [CompilerGenerated, AccessedThroughProperty("RadioButton25")]
        private RadioButton _RadioButton25;
        [CompilerGenerated, AccessedThroughProperty("RadioButton26")]
        private RadioButton _RadioButton26;
        [CompilerGenerated, AccessedThroughProperty("RadioButton27")]
        private RadioButton _RadioButton27;
        [CompilerGenerated, AccessedThroughProperty("RadioButton28")]
        private RadioButton _RadioButton28;
        [CompilerGenerated, AccessedThroughProperty("RadioButton29")]
        private RadioButton _RadioButton29;
        [CompilerGenerated, AccessedThroughProperty("RadioButton3")]
        private RadioButton _RadioButton3;
        [CompilerGenerated, AccessedThroughProperty("RadioButton30")]
        private RadioButton _RadioButton30;
        [CompilerGenerated, AccessedThroughProperty("RadioButton31")]
        private RadioButton _RadioButton31;
        [CompilerGenerated, AccessedThroughProperty("RadioButton4")]
        private RadioButton _RadioButton4;
        [CompilerGenerated, AccessedThroughProperty("RadioButton5")]
        private RadioButton _RadioButton5;
        [CompilerGenerated, AccessedThroughProperty("RadioButton6")]
        private RadioButton _RadioButton6;
        [CompilerGenerated, AccessedThroughProperty("RadioButton7")]
        private RadioButton _RadioButton7;
        [CompilerGenerated, AccessedThroughProperty("RadioButton8")]
        private RadioButton _RadioButton8;
        [CompilerGenerated, AccessedThroughProperty("RadioButton9")]
        private RadioButton _RadioButton9;
        [CompilerGenerated, AccessedThroughProperty("RichTextBox1")]
        private RichTextBox _RichTextBox1;
        [CompilerGenerated, AccessedThroughProperty("StatusStrip1")]
        private StatusStrip _StatusStrip1;
        [CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [CompilerGenerated, AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [CompilerGenerated, AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [CompilerGenerated, AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;
        [CompilerGenerated, AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;
        [CompilerGenerated, AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [CompilerGenerated, AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [CompilerGenerated, AccessedThroughProperty("TextBox3")]
        private TextBox _TextBox3;
        [CompilerGenerated, AccessedThroughProperty("TextBox4")]
        private TextBox _TextBox4;
        [CompilerGenerated, AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatusLabel1")]
        private ToolStripStatusLabel _ToolStripStatusLabel1;
        [CompilerGenerated, AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;
        [CompilerGenerated, AccessedThroughProperty("WebBrowser1")]
        private WebBrowser _WebBrowser1;
        public static string apidp = string.Empty;
        public static string clickOrder;
        public static int colour;
        private IContainer components;
        public static string dellOS;
        public static string docText;
        public static string downloadType;
        public static string dropHonolulu;
        public static string dropNewAdditions;
        public static string dropOffice07;
        public static string dropOffice10;
        public static string dropText;
        public static string dropTextLocalised = string.Empty;
        public static string dropWin10;
        public static string dropWin10dev;
        public static string dropWin10ins;
        public static string dropWin7;
        public static string dropWin8;
        public static bool enableButtons;
        public const string fakeAgent = "Mozilla/5.0 (Windows Phone 10.0;  Android 6.0.1; Nokia; Lumia 520) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.82 Mobile Safari/537.36 Edge/14.14348";
        public const string fakeAgent_dell = "RestSharp/105.2.3.0";
        public const string globalDate = "2019-02-24";
        public const string globalVersion = "8.03";
        public static bool internetError = false;
        public static bool isIdle;
        public static ResourceManager langDropdown = LangDropdown.ResourceManager;
        public static string langIDW7;
        public static string link2013;
        public static bool liveLogin = false;
        public static bool MSLogin;
        public static bool noAds;
        public static string prodIDW7;
        public static bool reload;
        public static ResourceManager rm;
        public static DataTable serviceTable = new DataTable();
        public static bool switchLanguage;
        public static DataTable systemTable = new DataTable();
        public static string TechBenchUrl;
        public static string whatsNew = string.Empty;
        public static string winVersion;

        public Form1()
        {
            base.Load += new EventHandler(this.Form1_Load);
            base.Shown += new EventHandler(this.Form1_Shown);
            this.InitializeComponent();
        }

        [CompilerGenerated]
        private bool _Lambda$__73-0(DataRow row) => 
            (row.Field<string>("model") == this.ComboBox2.Text);

        private void Add2016Mac(string version)
        {
            this.ComboBox2.Items.Add("Office 2019 for Mac " + version);
            this.ComboBox2.Items.Add("Office 2019 Business Pro for Mac " + version);
            this.ComboBox2.Items.Add("Word 2019 for Mac " + version);
            this.ComboBox2.Items.Add("Excel 2019 for Mac " + version);
            this.ComboBox2.Items.Add("PowerPoint 2019 for Mac " + version);
            this.ComboBox2.Items.Add("Outlook 2019 for Mac " + version);
            this.ComboBox2.Items.Add(string.Empty);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.RadioButton17.Checked)
            {
                bool flag = false;
                this.GetLinkDell();
                try
                {
                    MyProject.Computer.Clipboard.SetText(link2013);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox(rm.GetString("ErrorClipboard"), MsgBoxStyle.ApplicationModal, null);
                    this.ToolStripStatusLabel1.Text = exception.Message;
                    flag = true;
                    ProjectData.ClearProjectError();
                }
                if (!flag)
                {
                    Interaction.MsgBox(rm.GetString("SuccessClipboard"), MsgBoxStyle.ApplicationModal, null);
                }
            }
            else
            {
                downloadType = "\"DownloadType\": IsoX86";
                this.CopyDownload();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((this.RadioButton11.Checked | this.RadioButton16.Checked) | this.RadioButton17.Checked)
            {
                bool flag = false;
                if (this.RadioButton11.Checked | this.RadioButton16.Checked)
                {
                    this.GetLink2016Mac();
                }
                else
                {
                    this.GetLinkDell();
                }
                try
                {
                    MyProject.Computer.Clipboard.SetText(link2013);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox(rm.GetString("ErrorClipboard"), MsgBoxStyle.ApplicationModal, null);
                    this.ToolStripStatusLabel1.Text = exception.Message;
                    flag = true;
                    ProjectData.ClearProjectError();
                }
                if (!flag)
                {
                    Interaction.MsgBox(rm.GetString("SuccessClipboard"), MsgBoxStyle.ApplicationModal, null);
                }
            }
            else
            {
                downloadType = "\"DownloadType\": IsoX64";
                this.CopyDownload();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (((((this.RadioButton5.Checked | this.RadioButton7.Checked) | this.RadioButton8.Checked) | this.RadioButton9.Checked) | this.RadioButton15.Checked) | this.RadioButton16.Checked)
            {
                bool flag = false;
                if (this.RadioButton15.Checked)
                {
                    this.GetLinkExp();
                }
                else
                {
                    this.GetLink2013();
                }
                try
                {
                    MyProject.Computer.Clipboard.SetText(link2013);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox(rm.GetString("ErrorClipboard"), MsgBoxStyle.ApplicationModal, null);
                    this.ToolStripStatusLabel1.Text = exception.Message;
                    flag = true;
                    ProjectData.ClearProjectError();
                }
                if (!flag)
                {
                    Interaction.MsgBox(rm.GetString("SuccessClipboard"), MsgBoxStyle.ApplicationModal, null);
                }
            }
            else
            {
                downloadType = "\"DownloadType\": Unknown";
                this.CopyDownload();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.RadioButton11.Checked | this.RadioButton16.Checked)
            {
                this.GetLink2016Mac();
            }
            else if (this.RadioButton15.Checked)
            {
                this.GetLinkExp();
            }
            else if (this.RadioButton17.Checked)
            {
                this.GetLinkDell();
            }
            else
            {
                this.GetLink2013();
            }
            try
            {
                Process.Start(link2013);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox3.Checked)
            {
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "ExpertView", Conversions.ToString(this.CheckBox1.Checked));
            }
            if (this.CheckBox1.Checked)
            {
                if (((this.WebBrowser1.Document != null) && (this.WebBrowser1.Document.Body != null)) && (this.WebBrowser1.Document.Body.OuterHtml.Contains("id=\"product-edition\"") | this.WebBrowser1.Document.Body.OuterHtml.Contains("id=product-edition")))
                {
                    this.WebBrowser1.Document.GetElementById("product-edition").OuterHtml = "<select id=\"product-edition\" href=\"#product-info-content\">" + dropTextLocalised + "</slect>";
                }
            }
            else
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                try
                {
                    enumerator = this.WebBrowser1.Document.GetElementsByTagName("optgroup").GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        HtmlElement current = (HtmlElement) enumerator.Current;
                        if (current.GetAttribute("classname") == "expert")
                        {
                            current.OuterHtml = string.Empty;
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                try
                {
                    enumerator2 = this.WebBrowser1.Document.GetElementsByTagName("option").GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        HtmlElement element2 = (HtmlElement) enumerator2.Current;
                        if (element2.GetAttribute("classname") == "expert")
                        {
                            element2.OuterHtml = string.Empty;
                        }
                    }
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox3.Checked)
            {
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "NoAds", Conversions.ToString(this.CheckBox2.Checked));
            }
            if (this.CheckBox2.Checked)
            {
                MyProject.Forms.Form4.Close();
            }
            else
            {
                MyProject.Forms.Form4.Show();
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox3.Checked)
            {
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "Language", Conversions.ToString(this.ComboBox1.SelectedIndex));
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "ExpertView", Conversions.ToString(this.CheckBox1.Checked));
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "NoAds", Conversions.ToString(this.CheckBox2.Checked));
            }
            else
            {
                Interaction.DeleteSetting("Windows ISO Downloader", null, null);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CheckBox3.Checked)
            {
                Interaction.SaveSetting("Windows ISO Downloader", "Settings", "Language", Conversions.ToString(this.ComboBox1.SelectedIndex));
            }
            switch (this.ComboBox1.SelectedIndex)
            {
                case 0:
                    rm = ResourceArabic.ResourceManager;
                    break;

                case 1:
                    rm = ResourceBulgarian.ResourceManager;
                    break;

                case 2:
                    rm = ResourceCzech.ResourceManager;
                    break;

                case 3:
                    rm = ResourceChinese.ResourceManager;
                    break;

                case 4:
                    rm = ResourceChineseHk.ResourceManager;
                    break;

                case 5:
                    rm = ResourceChineseTw.ResourceManager;
                    break;

                case 6:
                    rm = ResourceDanish.ResourceManager;
                    break;

                case 7:
                    rm = ResourceGerman.ResourceManager;
                    break;

                case 8:
                    rm = ResourceEstonian.ResourceManager;
                    break;

                case 9:
                    rm = ResourceGreek.ResourceManager;
                    break;

                case 10:
                    rm = ResourceEnglish.ResourceManager;
                    break;

                case 11:
                    rm = ResourceEnglishUs.ResourceManager;
                    break;

                case 12:
                    rm = ResourceSpanish.ResourceManager;
                    break;

                case 13:
                    rm = ResourceSpanishMx.ResourceManager;
                    break;

                case 14:
                    rm = ResourceFrenchCa.ResourceManager;
                    break;

                case 15:
                    rm = ResourceFrench.ResourceManager;
                    break;

                case 0x10:
                    rm = ResourceHebrew.ResourceManager;
                    break;

                case 0x11:
                    rm = ResourceCroatian.ResourceManager;
                    break;

                case 0x12:
                    rm = ResourceItalian.ResourceManager;
                    break;

                case 0x13:
                    rm = ResourceJapanese.ResourceManager;
                    break;

                case 20:
                    rm = ResourceKorean.ResourceManager;
                    break;

                case 0x15:
                    rm = ResourceLatvian.ResourceManager;
                    break;

                case 0x16:
                    rm = ResourceLithuanian.ResourceManager;
                    break;

                case 0x17:
                    rm = ResourceHungarian.ResourceManager;
                    break;

                case 0x18:
                    rm = ResourceDutch.ResourceManager;
                    break;

                case 0x19:
                    rm = ResourceNorwegian.ResourceManager;
                    break;

                case 0x1a:
                    rm = ResourcePolish.ResourceManager;
                    break;

                case 0x1b:
                    rm = ResourcePortugueseBr.ResourceManager;
                    break;

                case 0x1c:
                    rm = ResourcePortuguese.ResourceManager;
                    break;

                case 0x1d:
                    rm = ResourceRomanian.ResourceManager;
                    break;

                case 30:
                    rm = ResourceRussian.ResourceManager;
                    break;

                case 0x1f:
                    rm = ResourceSlovak.ResourceManager;
                    break;

                case 0x20:
                    rm = ResourceSlovenian.ResourceManager;
                    break;

                case 0x21:
                    rm = ResourceSerbian.ResourceManager;
                    break;

                case 0x22:
                    rm = ResourceFinnish.ResourceManager;
                    break;

                case 0x23:
                    rm = ResourceSwedish.ResourceManager;
                    break;

                case 0x24:
                    rm = ResourceThai.ResourceManager;
                    break;

                case 0x25:
                    rm = ResourceTurkish.ResourceManager;
                    break;

                case 0x26:
                    rm = ResourceUkrainian.ResourceManager;
                    break;
            }
            TechBenchUrl = rm.GetString("TechBenchUrl");
            this.Button1.Text = rm.GetString("CopyLink32");
            this.Button2.Text = rm.GetString("CopyLink64");
            this.Button3.Text = rm.GetString("CopyLinkOther");
            this.Button4.Text = rm.GetString("Download");
            this.LinkLabel1.Text = HttpUtility.HtmlDecode(rm.GetString("About"));
            this.LinkLabel2.Text = rm.GetString("Forum");
            this.LinkLabel3.Text = rm.GetString("MailingList");
            this.LinkLabel4.Text = rm.GetString("IsoTools");
            this.LinkLabel5.Text = rm.GetString("BuyLicense");
            this.LinkLabel6.Text = rm.GetString("Donation");
            this.RadioButton12.Text = rm.GetString("Developer");
            this.CheckBox1.Text = rm.GetString("ExpertView");
            this.CheckBox2.Text = rm.GetString("DonateShort");
            this.CheckBox3.Text = rm.GetString("SettingsRemember");
            this.ToolTip1.ToolTipTitle = rm.GetString("ExpertView");
            this.ToolTip1.SetToolTip(this.CheckBox1, rm.GetString("ExpertViewMsg"));
            this.ComboBox2.AccessibleName = rm.GetString("SelectEdition");
            this.ComboBox3.AccessibleName = rm.GetString("SelectLanguage");
            if (this.RadioButton17.Checked)
            {
                this.RichTextBox1.Text = rm.GetString("DellOEM");
                this.Label1.Text = rm.GetString("Model");
                this.Label2.Text = rm.GetString("Image");
            }
            else
            {
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
            }
            this.Label3.Text = rm.GetString("LanguageName");
            this.ComboBox1.AccessibleName = rm.GetString("LanguageName");
            this.TabPage3.Text = rm.GetString("Settings");
            this.TabPage4.Text = rm.GetString("Other");
            this.RadioButton10.Text = rm.GetString("NewAdditions");
            this.GroupBox1.Text = rm.GetString("dell_tools");
            this.Label4.Text = rm.GetString("dell_filter");
            this.Label5.Text = rm.GetString("isotools_fileName");
            this.Label6.Text = rm.GetString("isotools_fileSize");
            this.Label7.Text = rm.GetString("dell_sha256");
            this.Label8.Text = rm.GetString("isotools_ReleaseDate");
            switchLanguage = true;
            if (((((this.RadioButton2.Checked | this.RadioButton3.Checked) | this.RadioButton4.Checked) | this.RadioButton10.Checked) | this.RadioButton12.Checked) | this.RadioButton14.Checked)
            {
                this.DisplayTechbench();
            }
            else if (this.RadioButton1.Checked | this.RadioButton6.Checked)
            {
                this.DisplayDownload();
            }
            else if (((!this.RadioButton5.Checked && !this.RadioButton7.Checked) && (!this.RadioButton8.Checked && !this.RadioButton9.Checked)) && ((!this.RadioButton11.Checked && !this.RadioButton15.Checked) && (!this.RadioButton16.Checked && !this.RadioButton17.Checked)))
            {
                this.WebBrowser1.Navigate("about:blank");
                this.CreateDocText();
                this.WebBrowser1.DocumentText = docText;
            }
            if (!this.CheckBox2.Checked && Form4.init)
            {
                MyProject.Forms.Form4.Text = rm.GetString("ads_sponsor");
                MyProject.Forms.Form4.Button1.Text = rm.GetString("ads_refresh");
                MyProject.Forms.Form4.Button2.Text = rm.GetString("ads_close");
                MyProject.Forms.Form4.WebBrowser1.Navigate($"https://www.wincert.net/ads/sponsor.php?lang={rm.GetString("language")}");
                MyProject.Forms.Form4.WebBrowser2.Document.GetElementById("text").InnerHtml = rm.GetString("ads_remove");
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Button4.Enabled = false;
            this.ComboBox3.Items.Clear();
            if (this.RadioButton17.Checked && (this.ComboBox2.Text != string.Empty))
            {
                this.TextBox1.Text = string.Empty;
                this.TextBox2.Text = string.Empty;
                this.TextBox3.Text = string.Empty;
                this.TextBox4.Text = string.Empty;
                EnumerableRowCollection<DataRow> source = serviceTable.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(this._Lambda$__73-0));
                Random random = new Random();
                string str = Conversions.ToString(source.ElementAtOrDefault<DataRow>(random.Next(0, source.Count<DataRow>())).ItemArray[1]);
                HttpWebResponse response = null;
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://apidp.dell.com/v1/osri/images/{str}?apikey=8eec4f50-de34-4ee8-9cbb-19dd8c1a7987");
                request.UserAgent = "RestSharp/105.2.3.0";
                bool flag = false;
                try
                {
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    MessageBox.Show(rm.GetString("CheckConnection"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.ToolStripStatusLabel1.Text = exception.Message;
                    flag = true;
                    ProjectData.ClearProjectError();
                }
                if (!flag)
                {
                    Match match;
                    apidp = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    for (match = new Regex("\"url\":\"([^\"]+)\",\"osCode\":\"([^\"]+)\",\"osCode90\":\\[([^\\[\\]]+)\\],\"size\":\"([^\"]+)\",\"sha256\":\"([^\"]+)\",\"title\":\"([^\"]+)\",\"shippedOS\":([^\"]+),\"swbId\":\"([^\"]+)\",\"releaseDate\":\"([^\"]+)\"").Match(apidp); match.Success; match = match.NextMatch())
                    {
                        this.ComboBox3.Items.Add(match.Groups[6]);
                    }
                    match = new Regex("\"systemImagePath\":\"([^\"]+)\"").Match(apidp);
                    if (match.Success)
                    {
                        try
                        {
                            this.PictureBox10.Load(match.Groups[1].ToString());
                            return;
                        }
                        catch (Exception exception3)
                        {
                            ProjectData.SetProjectError(exception3);
                            Exception exception2 = exception3;
                            this.ToolStripStatusLabel1.Text = exception2.Message;
                            ProjectData.ClearProjectError();
                            return;
                        }
                    }
                    this.PictureBox10.Image = null;
                }
            }
            else if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, string.Empty, false))
            {
                object[] arguments = new object[] { "Microsoft Expression" };
                string[] argumentNames = new string[] { "value" };
                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", arguments, argumentNames, null, null)))
                {
                    this.ComboBox3.Items.Add("Chinese, CN (简体中文, 中国)");
                    this.ComboBox3.Items.Add("Chinese, TW (繁體中文, 台灣)");
                    this.ComboBox3.Items.Add("Deutsch");
                    this.ComboBox3.Items.Add("English, US");
                    this.ComboBox3.Items.Add("Espa\x00f1ol, ES");
                    this.ComboBox3.Items.Add("Fran\x00e7ais, FR");
                    this.ComboBox3.Items.Add("Italiano");
                    this.ComboBox3.Items.Add("Japanese (日本語)");
                    this.ComboBox3.Items.Add("Korean (한국어)");
                }
                else
                {
                    object[] objArray2 = new object[] { "2011" };
                    string[] textArray2 = new string[] { "value" };
                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray2, textArray2, null, null)))
                    {
                        this.ComboBox3.Items.Add("Chinese, CN (简体中文, 中国)");
                        this.ComboBox3.Items.Add("Chinese, TW (繁體中文, 台灣)");
                        this.ComboBox3.Items.Add("Dansk");
                        this.ComboBox3.Items.Add("Deutsch");
                        this.ComboBox3.Items.Add("English, US");
                        this.ComboBox3.Items.Add("Espa\x00f1ol, ES");
                        this.ComboBox3.Items.Add("Fran\x00e7ais, FR");
                        this.ComboBox3.Items.Add("Italiano");
                        this.ComboBox3.Items.Add("Japanese (日本語)");
                        this.ComboBox3.Items.Add("Nederlands");
                        this.ComboBox3.Items.Add("Norsk bokm\x00e5l");
                        this.ComboBox3.Items.Add("Polski");
                        this.ComboBox3.Items.Add("Русский");
                        this.ComboBox3.Items.Add("Suomi");
                        this.ComboBox3.Items.Add("Svenska");
                    }
                    else
                    {
                        object[] objArray3 = new object[] { "for Mac" };
                        string[] textArray3 = new string[] { "value" };
                        if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray3, textArray3, null, null)))
                        {
                            this.ComboBox3.Items.Add("Multi Language");
                        }
                        else
                        {
                            object[] objArray4 = new object[] { "Personal" };
                            string[] textArray4 = new string[] { "value" };
                            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray4, textArray4, null, null)))
                            {
                                this.ComboBox3.Items.Add("Japanese (日本語)");
                            }
                            else
                            {
                                object[] objArray5 = new object[] { "Project" };
                                string[] textArray5 = new string[] { "value" };
                                object[] objArray6 = new object[] { "Visio" };
                                string[] textArray6 = new string[] { "value" };
                                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray5, textArray5, null, null), NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray6, textArray6, null, null))))
                                {
                                    this.ComboBox3.Items.Add("Arabic (العربية)");
                                    this.ComboBox3.Items.Add("Čeština");
                                    this.ComboBox3.Items.Add("Chinese, CN (简体中文, 中国)");
                                    this.ComboBox3.Items.Add("Chinese, TW (繁體中文, 台灣)");
                                    this.ComboBox3.Items.Add("Dansk");
                                    this.ComboBox3.Items.Add("Deutsch");
                                    this.ComboBox3.Items.Add("Ελληνικά");
                                    this.ComboBox3.Items.Add("English, US");
                                    this.ComboBox3.Items.Add("Espa\x00f1ol, ES");
                                    this.ComboBox3.Items.Add("Fran\x00e7ais, FR");
                                    this.ComboBox3.Items.Add("Hebrew (עברית)");
                                    this.ComboBox3.Items.Add("Italiano");
                                    this.ComboBox3.Items.Add("Japanese (日本語)");
                                    this.ComboBox3.Items.Add("Korean (한국어)");
                                    this.ComboBox3.Items.Add("Magyar");
                                    this.ComboBox3.Items.Add("Nederlands");
                                    this.ComboBox3.Items.Add("Norsk bokm\x00e5l");
                                    this.ComboBox3.Items.Add("Polski");
                                    this.ComboBox3.Items.Add("Portugu\x00eas, BR");
                                    this.ComboBox3.Items.Add("Portugu\x00eas, PT");
                                    this.ComboBox3.Items.Add("Rom\x00e2nă");
                                    this.ComboBox3.Items.Add("Русский");
                                    this.ComboBox3.Items.Add("Slovenčina");
                                    this.ComboBox3.Items.Add("Slovenščina");
                                    this.ComboBox3.Items.Add("Suomi");
                                    this.ComboBox3.Items.Add("Svenska");
                                    this.ComboBox3.Items.Add("T\x00fcrk\x00e7e");
                                    this.ComboBox3.Items.Add("Українська");
                                }
                                else
                                {
                                    this.ComboBox3.Items.Add("Arabic (العربية)");
                                    this.ComboBox3.Items.Add("Bahasa Indonesia");
                                    this.ComboBox3.Items.Add("Bahasa Melayu");
                                    this.ComboBox3.Items.Add("Български");
                                    this.ComboBox3.Items.Add("Čeština");
                                    this.ComboBox3.Items.Add("Chinese, CN (简体中文, 中国)");
                                    this.ComboBox3.Items.Add("Chinese, TW (繁體中文, 台灣)");
                                    this.ComboBox3.Items.Add("Dansk");
                                    this.ComboBox3.Items.Add("Deutsch");
                                    this.ComboBox3.Items.Add("Eesti");
                                    this.ComboBox3.Items.Add("Ελληνικά");
                                    this.ComboBox3.Items.Add("English, US");
                                    this.ComboBox3.Items.Add("Espa\x00f1ol, ES");
                                    this.ComboBox3.Items.Add("Fran\x00e7ais, FR");
                                    this.ComboBox3.Items.Add("Hebrew (עברית)");
                                    this.ComboBox3.Items.Add("Hindi (हिंदी)");
                                    this.ComboBox3.Items.Add("Hrvatska");
                                    this.ComboBox3.Items.Add("Italiano");
                                    this.ComboBox3.Items.Add("Japanese (日本語)");
                                    this.ComboBox3.Items.Add("Қазақ тілі");
                                    this.ComboBox3.Items.Add("Korean (한국어)");
                                    this.ComboBox3.Items.Add("Latviešu");
                                    this.ComboBox3.Items.Add("Lietuvių");
                                    this.ComboBox3.Items.Add("Magyar");
                                    this.ComboBox3.Items.Add("Nederlands");
                                    this.ComboBox3.Items.Add("Norsk bokm\x00e5l");
                                    this.ComboBox3.Items.Add("Polski");
                                    this.ComboBox3.Items.Add("Portugu\x00eas, BR");
                                    this.ComboBox3.Items.Add("Portugu\x00eas, PT");
                                    this.ComboBox3.Items.Add("Rom\x00e2nă");
                                    this.ComboBox3.Items.Add("Русский");
                                    this.ComboBox3.Items.Add("Slovenčina");
                                    this.ComboBox3.Items.Add("Slovenščina");
                                    this.ComboBox3.Items.Add("Srpski");
                                    this.ComboBox3.Items.Add("Suomi");
                                    this.ComboBox3.Items.Add("Svenska");
                                    this.ComboBox3.Items.Add("Thai (ไทย)");
                                    this.ComboBox3.Items.Add("Ti\x00eáng Vi\x00eạt");
                                    this.ComboBox3.Items.Add("T\x00fcrk\x00e7e");
                                    this.ComboBox3.Items.Add("Українська");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBox3.Text != string.Empty)
            {
                this.Button4.Enabled = true;
                if (this.RadioButton17.Checked)
                {
                    Match match = new Regex("\"url\":\"([^\"]+)\\/([^\"]+)\\?([^\"]+)\",\"osCode\":\"([^\"]+)\",\"osCode90\":\\[([^\\[\\]]+)\\],\"size\":\"([^\"]+)\",\"sha256\":\"([^\"]+)\",\"title\":\"([^\"]+)\",\"shippedOS\":([^\"]+),\"swbId\":\"([^\"]+)\",\"releaseDate\":\"([^\"]+)\"").Match(apidp);
                    int num = this.ComboBox3.SelectedIndex - 1;
                    for (int i = 0; i <= num; i++)
                    {
                        match = match.NextMatch();
                    }
                    this.TextBox1.Text = match.Groups[2].ToString();
                    this.TextBox2.Text = Conversions.ToString(Math.Round((double) (((double) Convert.ToInt64(match.Groups[6].ToString())) / 1048576.0)));
                    this.TextBox3.Text = match.Groups[7].ToString();
                    this.TextBox4.Text = match.Groups[11].ToString();
                }
            }
        }

        private void CopyDownload()
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.WebBrowser1.Document.GetElementsByTagName("input").GetEnumerator();
                while (enumerator.MoveNext())
                {
                    string attribute = ((HtmlElement) enumerator.Current).GetAttribute("value");
                    if (attribute.Contains(downloadType) | attribute.Contains(downloadType.Replace(" ", string.Empty)))
                    {
                        Match match = new Regex("http[^\"]+", RegexOptions.IgnoreCase).Match(attribute);
                        bool flag = false;
                        try
                        {
                            MyProject.Computer.Clipboard.SetText(HttpUtility.HtmlDecode(match.Value));
                        }
                        catch (Exception exception1)
                        {
                            ProjectData.SetProjectError(exception1);
                            Exception exception = exception1;
                            Interaction.MsgBox(rm.GetString("ErrorClipboard"), MsgBoxStyle.ApplicationModal, null);
                            this.ToolStripStatusLabel1.Text = exception.Message;
                            flag = true;
                            ProjectData.ClearProjectError();
                        }
                        if (!flag)
                        {
                            Interaction.MsgBox(rm.GetString("SuccessClipboard"), MsgBoxStyle.ApplicationModal, null);
                        }
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
        }

        private void CreateDocText()
        {
            StreamReader reader;
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.home3.html"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.home.html"));
            }
            docText = reader.ReadToEnd();
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.css"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.css"));
            }
            string newValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.js"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.js"));
            }
            string str2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.style.css"));
            string str3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.jquery.min.js"));
            string str4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.HeiDoc.png"));
            MemoryStream destination = new MemoryStream();
            reader.BaseStream.CopyTo(destination);
            string str5 = Convert.ToBase64String(destination.ToArray());
            docText = docText.Replace("|*BOOTSTRAP*|", newValue).Replace("|*BOOTSTRAPJS*|", str2).Replace("|*STYLECSX*|", str3).Replace("|*JQUERY*|", str4).Replace("|*HEIDOCPNG*|", str5);
            docText = docText.Replace("|*WINISODOWNLOADER*|", rm.GetString("WinIsoDownloader"));
            docText = docText.Replace("|*WINISOLINE1*|", rm.GetString("WinIsoLine1"));
            docText = docText.Replace("|*WINISOLINE2*|", rm.GetString("WinIsoLine2"));
            docText = docText.Replace("|*ABOUT*|", rm.GetString("About"));
            docText = docText.Replace("|*WHATSNEW*|", rm.GetString("WhatsNew"));
            docText = docText.Replace("|*GLOBALVERSION*|", "8.03");
            CultureInfo provider = new CultureInfo(rm.GetString("TechBenchUrl"));
            docText = docText.Replace("|*GLOBALDATE*|", DateTime.Parse("2019-02-24").ToString("D", provider));
            docText = docText.Replace("|*WHATSNEWBODY*|", whatsNew);
        }

        private void DisplayDownload()
        {
            string str;
            StreamReader reader;
            this.WebBrowser1.Visible = true;
            this.GroupBox1.Visible = false;
            this.RichTextBox1.Visible = false;
            this.Label1.Visible = false;
            this.Label2.Visible = false;
            this.ComboBox2.Visible = false;
            this.ComboBox3.Visible = false;
            this.Button4.Visible = false;
            this.Button1.Enabled = false;
            this.Button2.Enabled = false;
            this.Button3.Enabled = false;
            if (this.RadioButton1.Checked)
            {
                str = "Windows 7";
            }
            else
            {
                str = "Office 2010";
            }
            this.WebBrowser1.Navigate("about:blank");
            this.WebBrowser1.Document.Write(string.Empty);
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.download3.html"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.download.html"));
            }
            docText = reader.ReadToEnd();
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.css"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.css"));
            }
            string newValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            if (this.WebBrowser1.Version.Major < 10)
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap3.min.js"));
            }
            else
            {
                reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.bootstrap.min.js"));
            }
            string str3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.style.css"));
            string str4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.jquery.min.js"));
            string str5 = Convert.ToBase64String(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            reader = new StreamReader(executingAssembly.GetManifestResourceStream("Windows_ISO_Downloader.HeiDoc.png"));
            MemoryStream destination = new MemoryStream();
            reader.BaseStream.CopyTo(destination);
            string str6 = Convert.ToBase64String(destination.ToArray());
            docText = docText.Replace("|*BOOTSTRAP*|", newValue).Replace("|*BOOTSTRAPJS*|", str3).Replace("|*STYLECSX*|", str4).Replace("|*JQUERY*|", str5).Replace("|*HEIDOCPNG*|", str6);
            docText = docText.Replace("|*SOFTWARE*|", rm.GetString("DownloadSoftware").Replace("***", str));
            docText = docText.Replace("|*SELECTEDITION*|", rm.GetString("SelectEdition"));
            docText = docText.Replace("|*SELECTLANGUAGE*|", rm.GetString("SelectLanguage"));
            docText = docText.Replace("|*CONFIRM*|", rm.GetString("Confirm"));
            if (this.RadioButton1.Checked)
            {
                dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition")).Replace("Home Premium", rm.GetString("EdHomePremium")).Replace("Professional", rm.GetString("EdProfessional")).Replace("Ultimate", rm.GetString("EdUltimate"));
            }
            else
            {
                dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition"));
            }
            docText = docText.Replace("|*DROPDOWN*|", dropTextLocalised);
            this.WebBrowser1.DocumentText = docText;
        }

        private void DisplayTechbench()
        {
            this.WebBrowser1.Visible = true;
            this.GroupBox1.Visible = false;
            this.RichTextBox1.Visible = false;
            this.Label1.Visible = false;
            this.Label2.Visible = false;
            this.ComboBox2.Visible = false;
            this.ComboBox3.Visible = false;
            this.Button4.Visible = false;
            isIdle = false;
            this.Button1.Enabled = false;
            this.Button2.Enabled = false;
            this.Button3.Enabled = false;
            enableButtons = false;
            this.TabControl1.Enabled = false;
            if ((((this.WebBrowser1.Document.Body != null) && (this.WebBrowser1.Document.Body.OuterHtml.Contains("id=\"product-edition\"") | this.WebBrowser1.Document.Body.OuterHtml.Contains("id=product-edition"))) && (!this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\": ") && !this.WebBrowser1.Document.Body.OuterHtml.Contains("Windows ISO Downloader"))) && (!switchLanguage && !reload))
            {
                if ((this.RadioButton1.Checked | this.RadioButton2.Checked) | this.RadioButton3.Checked)
                {
                    dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition")).Replace("China Get Genuine", rm.GetString("EdChinaGetGenuine")).Replace("Home China", rm.GetString("EdHomeChina")).Replace("Education", rm.GetString("EdEducation")).Replace("Home Basic", rm.GetString("EdHomeBasic")).Replace("Home Premium", rm.GetString("EdHomePremium")).Replace("Professional", rm.GetString("EdProfessional")).Replace("Single Language", rm.GetString("EdSingleLanguage")).Replace("Ultimate", rm.GetString("EdUltimate"));
                }
                else
                {
                    dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition"));
                }
                this.WebBrowser1.Document.GetElementById("product-edition").OuterHtml = "<select id=\"product-edition\" href=\"#product-info-content\">" + dropTextLocalised + "</slect>";
                if (!this.CheckBox1.Checked)
                {
                    IEnumerator enumerator;
                    IEnumerator enumerator2;
                    try
                    {
                        enumerator = this.WebBrowser1.Document.GetElementsByTagName("optgroup").GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            HtmlElement current = (HtmlElement) enumerator.Current;
                            if (current.GetAttribute("classname") == "expert")
                            {
                                current.OuterHtml = string.Empty;
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    try
                    {
                        enumerator2 = this.WebBrowser1.Document.GetElementsByTagName("option").GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            HtmlElement element2 = (HtmlElement) enumerator2.Current;
                            if (element2.GetAttribute("classname") == "expert")
                            {
                                element2.OuterHtml = string.Empty;
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator2 is IDisposable)
                        {
                            (enumerator2 as IDisposable).Dispose();
                        }
                    }
                }
                enableButtons = true;
                this.TabControl1.Enabled = true;
            }
            else
            {
                IEnumerator enumerator3;
                reload = false;
                this.WebBrowser1.Navigate("about:blank");
                this.WebBrowser1.Document.Write(string.Empty);
                this.WebBrowser1.Visible = false;
                new Windows_ISO_Downloader.NativeMethods().ChangeUserAgent("Mozilla/5.0 (Windows Phone 10.0;  Android 6.0.1; Nokia; Lumia 520) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.82 Mobile Safari/537.36 Edge/14.14348");
                this.WebBrowser1.Navigate($"https://www.microsoft.com/{TechBenchUrl}/software-download/windows10ISO", null, null, $"User-Agent: {"Mozilla/5.0 (Windows Phone 10.0;  Android 6.0.1; Nokia; Lumia 520) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.82 Mobile Safari/537.36 Edge/14.14348"}");
                while (this.WebBrowser1.IsBusy)
                {
                    Application.DoEvents();
                }
                int num = 0;
                do
                {
                    if (this.WebBrowser1.ReadyState == WebBrowserReadyState.Complete)
                    {
                        break;
                    }
                    Application.DoEvents();
                    Thread.Sleep(10);
                    num++;
                }
                while (num <= 0x1f3);
                Application.DoEvents();
                this.Wait(1f);
                while (this.WebBrowser1.IsBusy)
                {
                    Application.DoEvents();
                }
                int num2 = 0;
                do
                {
                    if (this.WebBrowser1.ReadyState == WebBrowserReadyState.Complete)
                    {
                        break;
                    }
                    Application.DoEvents();
                    Thread.Sleep(10);
                    num2++;
                }
                while (num2 <= 0x1f3);
                Application.DoEvents();
                try
                {
                    enumerator3 = this.WebBrowser1.Document.GetElementsByTagName("body").GetEnumerator();
                    while (enumerator3.MoveNext())
                    {
                        ((HtmlElement) enumerator3.Current).Style = "-ms-overflow-style: none; font-size: smaller;";
                    }
                }
                finally
                {
                    if (enumerator3 is IDisposable)
                    {
                        (enumerator3 as IDisposable).Dispose();
                    }
                }
                if (this.WebBrowser1.Document.Body.OuterHtml.Contains("id=\"product-edition\"") | this.WebBrowser1.Document.Body.OuterHtml.Contains("id=product-edition"))
                {
                    IEnumerator enumerator4;
                    IEnumerator enumerator5;
                    IEnumerator enumerator6;
                    IEnumerator enumerator7;
                    try
                    {
                        enumerator4 = this.WebBrowser1.Document.GetElementsByTagName("div").GetEnumerator();
                        while (enumerator4.MoveNext())
                        {
                            HtmlElement element4 = (HtmlElement) enumerator4.Current;
                            if ((((element4.Parent.TagName == "BODY") && !element4.OuterHtml.Contains("SoftwareDownload_EditionSelection")) && (!element4.OuterHtml.Contains("id=\"meControl\"") && !element4.OuterHtml.Contains("id=meControl"))) && (!element4.OuterHtml.Contains("id=\"progress-modal\"") && !element4.OuterHtml.Contains("id=progress-modal")))
                            {
                                element4.Style = "display: none;";
                            }
                            if ((((element4.OuterHtml.Contains("CSPvNext") | element4.OuterHtml.Contains("ms.cmpgrp")) && !element4.OuterHtml.Contains("productEdition-validation")) && (!element4.OuterHtml.Contains("id=\"meControl\"") && !element4.OuterHtml.Contains("id=meControl"))) && (!element4.OuterHtml.Contains("id=\"progress-modal\"") && !element4.OuterHtml.Contains("id=progress-modal")))
                            {
                                element4.Style = "display: none;";
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator4 is IDisposable)
                        {
                            (enumerator4 as IDisposable).Dispose();
                        }
                    }
                    try
                    {
                        enumerator5 = this.WebBrowser1.Document.GetElementsByTagName("p").GetEnumerator();
                        while (enumerator5.MoveNext())
                        {
                            HtmlElement element5 = (HtmlElement) enumerator5.Current;
                            if ((element5.Parent.TagName == "DIV") && (element5.OuterHtml.Contains("Windows 10") | element5.OuterHtml.Contains("Windows&nbsp;10")))
                            {
                                element5.Style = "display: none;";
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator5 is IDisposable)
                        {
                            (enumerator5 as IDisposable).Dispose();
                        }
                    }
                    try
                    {
                        enumerator6 = this.WebBrowser1.Document.GetElementsByTagName("ul").GetEnumerator();
                        while (enumerator6.MoveNext())
                        {
                            HtmlElement element6 = (HtmlElement) enumerator6.Current;
                            if (element6.OuterHtml.Contains("faq-accordion"))
                            {
                                element6.Parent.Parent.Parent.Style = "display: none;";
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator6 is IDisposable)
                        {
                            (enumerator6 as IDisposable).Dispose();
                        }
                    }
                    this.WebBrowser1.Document.GetElementById("uhfLogo").Style = "display: none;";
                    this.WebBrowser1.Document.GetElementById("uhf-g-nav").Style = "display: none;";
                    this.WebBrowser1.Document.GetElementById("searchForm").Style = "display: none;";
                    this.WebBrowser1.Document.GetElementById("uhfCatLogo").Style = "display: none;";
                    this.WebBrowser1.Document.GetElementById("uhfCatLogoButton").Parent.Style = "display: none !important;";
                    this.WebBrowser1.Document.GetElementById("uhf-c-nav").Parent.Style = "display: none;";
                    try
                    {
                        enumerator7 = this.WebBrowser1.Document.GetElementsByTagName("BUTTON").GetEnumerator();
                        while (enumerator7.MoveNext())
                        {
                            HtmlElement element7 = (HtmlElement) enumerator7.Current;
                            if (element7.OuterHtml.Contains("glyph-chevron"))
                            {
                                element7.Style = "display: none;";
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator7 is IDisposable)
                        {
                            (enumerator7 as IDisposable).Dispose();
                        }
                    }
                    if ((this.RadioButton1.Checked | this.RadioButton2.Checked) | this.RadioButton3.Checked)
                    {
                        dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition")).Replace("China Get Genuine", rm.GetString("EdChinaGetGenuine")).Replace("Home China", rm.GetString("EdHomeChina")).Replace("Education", rm.GetString("EdEducation")).Replace("Home Basic", rm.GetString("EdHomeBasic")).Replace("Home Premium", rm.GetString("EdHomePremium")).Replace("Professional", rm.GetString("EdProfessional")).Replace("Single Language", rm.GetString("EdSingleLanguage")).Replace("Ultimate", rm.GetString("EdUltimate"));
                    }
                    else
                    {
                        dropTextLocalised = dropText.Replace("Select edition", rm.GetString("SelectEdition"));
                    }
                    this.WebBrowser1.Document.GetElementById("product-edition").OuterHtml = "<select id=\"product-edition\" href=\"#product-info-content\">" + dropTextLocalised + "</slect>";
                    if (!this.CheckBox1.Checked)
                    {
                        IEnumerator enumerator8;
                        IEnumerator enumerator9;
                        try
                        {
                            enumerator8 = this.WebBrowser1.Document.GetElementsByTagName("optgroup").GetEnumerator();
                            while (enumerator8.MoveNext())
                            {
                                HtmlElement element8 = (HtmlElement) enumerator8.Current;
                                if (element8.GetAttribute("classname") == "expert")
                                {
                                    element8.OuterHtml = string.Empty;
                                }
                            }
                        }
                        finally
                        {
                            if (enumerator8 is IDisposable)
                            {
                                (enumerator8 as IDisposable).Dispose();
                            }
                        }
                        try
                        {
                            enumerator9 = this.WebBrowser1.Document.GetElementsByTagName("option").GetEnumerator();
                            while (enumerator9.MoveNext())
                            {
                                HtmlElement element9 = (HtmlElement) enumerator9.Current;
                                if (element9.GetAttribute("classname") == "expert")
                                {
                                    element9.OuterHtml = string.Empty;
                                }
                            }
                        }
                        finally
                        {
                            if (enumerator9 is IDisposable)
                            {
                                (enumerator9 as IDisposable).Dispose();
                            }
                        }
                    }
                    HtmlElement elementById = this.WebBrowser1.Document.GetElementById("submit-product-edition");
                    elementById.Parent.InnerHtml = $"<form action='https://www.heidoc.net/'>{elementById.OuterHtml}</form>";
                    this.WebBrowser1.Visible = true;
                    this.TabControl1.Enabled = true;
                }
                else if (((this.WebBrowser1.Document.Url.Host == "login.live.com") && (this.WebBrowser1.ReadyState != WebBrowserReadyState.Loading)) && (this.WebBrowser1.ReadyState != WebBrowserReadyState.Uninitialized))
                {
                    this.WebBrowser1.Visible = true;
                    this.TabControl1.Enabled = true;
                    this.RadioButton1.Checked = false;
                    this.RadioButton2.Checked = false;
                    this.RadioButton3.Checked = false;
                    this.RadioButton4.Checked = false;
                    this.RadioButton5.Checked = false;
                    this.RadioButton6.Checked = false;
                    this.RadioButton7.Checked = false;
                    this.RadioButton8.Checked = false;
                    this.RadioButton9.Checked = false;
                    this.RadioButton10.Checked = false;
                    this.RadioButton11.Checked = false;
                    this.RadioButton12.Checked = false;
                    this.RadioButton13.Checked = false;
                    this.RadioButton14.Checked = false;
                    this.RadioButton15.Checked = false;
                    this.RadioButton16.Checked = false;
                    this.RadioButton17.Checked = false;
                    MSLogin = true;
                    MessageBox.Show(rm.GetString("MicrosoftLogin"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.TabControl1.Enabled = true;
                    MyProject.Forms.Form3.ShowDialog();
                }
                switchLanguage = false;
            }
            isIdle = true;
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

        private void DownloadDropdown()
        {
            StreamReader reader;
            this.Button1.Enabled = false;
            this.Button2.Enabled = false;
            this.Button3.Enabled = false;
            enableButtons = false;
            if (!(this.RadioButton1.Enabled | this.RadioButton6.Enabled))
            {
                this.TabControl1.Enabled = false;
            }
            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://www.heidoc.net/php/{winVersion}");
            request.UserAgent = $"Windows ISO Downloader/{"8.03"}";
            bool flag = false;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                internetError = true;
                flag = true;
                ProjectData.ClearProjectError();
            }
            if (!flag)
            {
                reader = new StreamReader(response.GetResponseStream());
            }
            else
            {
                reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream($"Windows_ISO_Downloader.{winVersion}"));
            }
            dropText = reader.ReadToEnd();
        }

        private void FillDellTables()
        {
            DataColumn column = new DataColumn {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "model",
                ReadOnly = false,
                Unique = false
            };
            systemTable.Columns.Add(column);
            column = new DataColumn {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "os",
                ReadOnly = false,
                Unique = false
            };
            systemTable.Columns.Add(column);
            column = new DataColumn {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "model",
                ReadOnly = false,
                Unique = false
            };
            serviceTable.Columns.Add(column);
            column = new DataColumn {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "servicetag",
                ReadOnly = false,
                Unique = false
            };
            serviceTable.Columns.Add(column);
            StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Windows_ISO_Downloader.dell.xml"));
            XmlDocument document1 = new XmlDocument();
            document1.LoadXml(reader.ReadToEnd());
            XmlNodeList elementsByTagName = document1.GetElementsByTagName("image");
            int num = elementsByTagName.Count - 1;
            for (int i = 0; i <= num; i++)
            {
                DataRow row;
                string innerText = elementsByTagName[i].ChildNodes.Item(0).InnerText;
                char[] separator = new char[] { ',' };
                foreach (string str2 in elementsByTagName[i].ChildNodes.Item(1).InnerText.Split(separator))
                {
                    row = systemTable.NewRow();
                    row["model"] = innerText;
                    row["os"] = str2;
                    systemTable.Rows.Add(row);
                }
                int num4 = elementsByTagName[i].ChildNodes.Count - 1;
                for (int j = 2; j <= num4; j++)
                {
                    row = serviceTable.NewRow();
                    row["model"] = innerText;
                    row["servicetag"] = elementsByTagName[i].ChildNodes.Item(j).InnerText;
                    serviceTable.Rows.Add(row);
                }
            }
        }

        private void FilterDell()
        {
            IEnumerator<DataRow> enumerator;
            this.ComboBox2.Items.Clear();
            this.ComboBox3.Items.Clear();
            this.TextBox1.Text = string.Empty;
            this.TextBox2.Text = string.Empty;
            this.TextBox3.Text = string.Empty;
            this.TextBox4.Text = string.Empty;
            EnumerableRowCollection<DataRow> rows = systemTable.AsEnumerable().Where<DataRow>((_Closure$__.$I111-0 == null) ? (_Closure$__.$I111-0 = new Func<DataRow, bool>(_Closure$__.$I._Lambda$__111-0)) : _Closure$__.$I111-0);
            try
            {
                enumerator = rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow current = enumerator.Current;
                    this.ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(current[0]));
                }
            }
            finally
            {
                if (enumerator != null)
                {
                    enumerator.Dispose();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str;
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
            this.LinkLabel1.Parent = this.PictureBox1;
            this.LinkLabel1.Location = new Point(0, 0);
            this.LinkLabel1.BringToFront();
            this.LinkLabel2.Parent = this.PictureBox2;
            this.LinkLabel2.Location = new Point(0, 0);
            this.LinkLabel2.BringToFront();
            this.LinkLabel3.Parent = this.PictureBox3;
            this.LinkLabel3.Location = new Point(0, 0);
            this.LinkLabel3.BringToFront();
            this.LinkLabel4.Parent = this.PictureBox4;
            this.LinkLabel4.Location = new Point(0, 0);
            this.LinkLabel4.BringToFront();
            this.LinkLabel5.Parent = this.PictureBox5;
            this.LinkLabel5.Location = new Point(0, 0);
            this.LinkLabel5.BringToFront();
            this.LinkLabel6.Parent = this.PictureBox6;
            this.LinkLabel6.Location = new Point(0, 0);
            this.LinkLabel6.BringToFront();
            string s = CultureInfo.CurrentCulture.ToString().ToUpper().Substring(0, 2);
            switch (<PrivateImplementationDetails>.ComputeStringHash(s))
            {
                case 0x20f56251:
                    if (s == "TH")
                    {
                        rm = ResourceThai.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x24;
                        goto Label_0BC3;
                    }
                    break;

                case 0x21eea81f:
                    if (s == "KO")
                    {
                        rm = ResourceKorean.ResourceManager;
                        this.ComboBox1.SelectedIndex = 20;
                        goto Label_0BC3;
                    }
                    break;

                case 0x19dd5266:
                    if (s == "BG")
                    {
                        rm = ResourceBulgarian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 1;
                        goto Label_0BC3;
                    }
                    break;

                case 0x1ecc1124:
                    if (s == "EL")
                    {
                        rm = ResourceGreek.ResourceManager;
                        this.ComboBox1.SelectedIndex = 9;
                        goto Label_0BC3;
                    }
                    break;

                case 0x24fff5f9:
                    if (s == "PL")
                    {
                        rm = ResourcePolish.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x1a;
                        goto Label_0BC3;
                    }
                    break;

                case 0x2517fadf:
                    if (s == "ZH")
                    {
                        if (CultureInfo.CurrentCulture.ToString().ToUpper() == "ZH-HK")
                        {
                            rm = ResourceChineseHk.ResourceManager;
                            this.ComboBox1.SelectedIndex = 4;
                        }
                        else if (CultureInfo.CurrentCulture.ToString().ToUpper() == "ZH-TW")
                        {
                            rm = ResourceChineseTw.ResourceManager;
                            this.ComboBox1.SelectedIndex = 5;
                        }
                        else
                        {
                            rm = ResourceChinese.ResourceManager;
                            this.ComboBox1.SelectedIndex = 3;
                        }
                        goto Label_0BC3;
                    }
                    break;

                case 0x25cc1c29:
                    if (s == "ES")
                    {
                        if (CultureInfo.CurrentCulture.ToString().ToUpper() == "ES-ES")
                        {
                            rm = ResourceSpanish.ResourceManager;
                            this.ComboBox1.SelectedIndex = 12;
                        }
                        else
                        {
                            rm = ResourceSpanishMx.ResourceManager;
                            this.ComboBox1.SelectedIndex = 13;
                        }
                        goto Label_0BC3;
                    }
                    break;

                case 0x26cc1dbc:
                    if (s == "ET")
                    {
                        rm = ResourceEstonian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 8;
                        goto Label_0BC3;
                    }
                    break;

                case 0x37ce7716:
                    if (s == "DA")
                    {
                        rm = ResourceDanish.ResourceManager;
                        this.ComboBox1.SelectedIndex = 6;
                        goto Label_0BC3;
                    }
                    break;

                case 0x3bce7d62:
                    if (s == "DE")
                    {
                        rm = ResourceGerman.ResourceManager;
                        this.ComboBox1.SelectedIndex = 7;
                        goto Label_0BC3;
                    }
                    break;

                case 0x26f56bc3:
                    if (s == "TR")
                    {
                        rm = ResourceTurkish.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x25;
                        goto Label_0BC3;
                    }
                    break;

                case 0x36e67a69:
                    if (s == "NB")
                    {
                        rm = ResourceNorwegian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x19;
                        goto Label_0BC3;
                    }
                    break;

                case 0x3cd53aba:
                    if (s == "AR")
                    {
                        rm = ResourceArabic.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0;
                        goto Label_0BC3;
                    }
                    break;

                case 0x3d001bc1:
                    if (s == "PT")
                    {
                        if (CultureInfo.CurrentCulture.ToString().ToUpper() == "PT-BR")
                        {
                            rm = ResourcePortugueseBr.ResourceManager;
                            this.ComboBox1.SelectedIndex = 0x1b;
                        }
                        else
                        {
                            rm = ResourcePortuguese.ResourceManager;
                            this.ComboBox1.SelectedIndex = 0x1c;
                        }
                        goto Label_0BC3;
                    }
                    break;

                case 0x40e68a27:
                    if (s == "NL")
                    {
                        rm = ResourceDutch.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x18;
                        goto Label_0BC3;
                    }
                    break;

                case 0x4bf128d4:
                    if (s == "JA")
                    {
                        rm = ResourceJapanese.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x13;
                        goto Label_0BC3;
                    }
                    break;

                case 0x65d9f873:
                    if (s == "CS")
                    {
                        rm = ResourceCzech.ResourceManager;
                        this.ComboBox1.SelectedIndex = 2;
                        goto Label_0BC3;
                    }
                    break;

                case 0x66e90490:
                    if (s == "IT")
                    {
                        rm = ResourceItalian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x12;
                        goto Label_0BC3;
                    }
                    break;

                case 0x5e028e4b:
                    if (s == "SK")
                    {
                        rm = ResourceSlovak.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x1f;
                        goto Label_0BC3;
                    }
                    break;

                case 0x6302962a:
                    if (s == "SL")
                    {
                        rm = ResourceSlovenian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x20;
                        goto Label_0BC3;
                    }
                    break;

                case 0x6804dca0:
                    if (s == "RU")
                    {
                        rm = ResourceRussian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 30;
                        goto Label_0BC3;
                    }
                    break;

                case 0x69029f9c:
                    if (s == "SV")
                    {
                        rm = ResourceSwedish.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x23;
                        goto Label_0BC3;
                    }
                    break;

                case 0x6beb4b06:
                    if (s == "HU")
                    {
                        rm = ResourceHungarian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x17;
                        goto Label_0BC3;
                    }
                    break;

                case 0x6e04e612:
                    if (s == "RS")
                    {
                        rm = ResourceSerbian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x21;
                        goto Label_0BC3;
                    }
                    break;

                case 0x7ae26847:
                    if (s == "LV")
                    {
                        rm = ResourceLatvian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x15;
                        goto Label_0BC3;
                    }
                    break;

                case 0x7bd35f50:
                    if (s == "FI")
                    {
                        rm = ResourceFinnish.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x22;
                        goto Label_0BC3;
                    }
                    break;

                case 0x6eeb4fbf:
                    if (s == "HR")
                    {
                        rm = ResourceCroatian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x11;
                        goto Label_0BC3;
                    }
                    break;

                case 0x76d35771:
                    if (s == "FR")
                    {
                        if (CultureInfo.CurrentCulture.ToString().ToUpper() == "FR-CA")
                        {
                            rm = ResourceFrenchCa.ResourceManager;
                            this.ComboBox1.SelectedIndex = 14;
                        }
                        else
                        {
                            rm = ResourceFrench.ResourceManager;
                            this.ComboBox1.SelectedIndex = 15;
                        }
                        goto Label_0BC3;
                    }
                    break;

                case 0x7beb6436:
                    if (s == "HE")
                    {
                        rm = ResourceHebrew.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x10;
                        goto Label_0BC3;
                    }
                    break;

                case 0x7ce26b6d:
                    if (s == "LT")
                    {
                        rm = ResourceLithuanian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x16;
                        goto Label_0BC3;
                    }
                    break;

                case 0x7df3b621:
                    if (s == "UK")
                    {
                        rm = ResourceUkrainian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x26;
                        goto Label_0BC3;
                    }
                    break;

                case 0x8205058e:
                    if (s == "RO")
                    {
                        rm = ResourceRomanian.ResourceManager;
                        this.ComboBox1.SelectedIndex = 0x1d;
                        goto Label_0BC3;
                    }
                    break;
            }
            if (((CultureInfo.CurrentCulture.ToString().ToUpper() == "EN-US") | (CultureInfo.CurrentCulture.ToString().ToUpper() == "EN-PH")) | (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(CultureInfo.CurrentCulture.ToString().ToUpper().Substring(0, 2), "EN", false) > 0))
            {
                rm = ResourceEnglishUs.ResourceManager;
                this.ComboBox1.SelectedIndex = 11;
            }
            else
            {
                rm = ResourceEnglish.ResourceManager;
                this.ComboBox1.SelectedIndex = 10;
            }
        Label_0BC3:
            str = Interaction.GetSetting("Windows ISO Downloader", "Settings", "Language", "");
            string str2 = Interaction.GetSetting("Windows ISO Downloader", "Settings", "ExpertView", "");
            string str3 = Interaction.GetSetting("Windows ISO Downloader", "Settings", "NoAds", "");
            if (str != string.Empty)
            {
                this.ComboBox1.SelectedIndex = Conversions.ToInteger(str);
                this.CheckBox3.Checked = true;
            }
            if (str2 != string.Empty)
            {
                if (str2 == "True")
                {
                    this.CheckBox1.Checked = true;
                }
                else
                {
                    this.CheckBox1.Checked = false;
                }
                this.CheckBox3.Checked = true;
            }
            if (str3 != string.Empty)
            {
                if (str3 == "True")
                {
                    this.CheckBox2.Enabled = true;
                    this.CheckBox2.Checked = true;
                }
                else
                {
                    this.CheckBox2.Checked = false;
                }
                this.CheckBox3.Checked = true;
            }
            TechBenchUrl = rm.GetString("TechBenchUrl");
            this.Button1.Text = rm.GetString("CopyLink32");
            this.Button2.Text = rm.GetString("CopyLink64");
            this.Button3.Text = rm.GetString("CopyLinkOther");
            this.Button4.Text = rm.GetString("Download");
            this.LinkLabel1.Text = HttpUtility.HtmlDecode(rm.GetString("About"));
            this.LinkLabel2.Text = rm.GetString("Forum");
            this.LinkLabel3.Text = rm.GetString("MailingList");
            this.LinkLabel4.Text = rm.GetString("IsoTools");
            this.LinkLabel5.Text = rm.GetString("BuyLicense");
            this.LinkLabel6.Text = rm.GetString("Donation");
            this.RadioButton12.Text = rm.GetString("Developer");
            this.CheckBox1.Text = rm.GetString("ExpertView");
            this.CheckBox2.Text = rm.GetString("DonateShort");
            this.CheckBox3.Text = rm.GetString("SettingsRemember");
            this.ToolTip1.ToolTipTitle = rm.GetString("ExpertView");
            this.ToolTip1.SetToolTip(this.CheckBox1, rm.GetString("ExpertViewMsg"));
            this.Label1.Text = rm.GetString("SelectEdition");
            this.ComboBox2.AccessibleName = rm.GetString("SelectEdition");
            this.Label2.Text = rm.GetString("SelectLanguage");
            this.ComboBox3.AccessibleName = rm.GetString("SelectLanguage");
            this.Label3.Text = rm.GetString("LanguageName");
            this.ComboBox1.AccessibleName = rm.GetString("LanguageName");
            this.TabPage3.Text = rm.GetString("Settings");
            this.TabPage4.Text = rm.GetString("Other");
            this.RadioButton10.Text = rm.GetString("NewAdditions");
            this.GroupBox1.Text = rm.GetString("dell_tools");
            this.Label4.Text = rm.GetString("dell_filter");
            this.Label5.Text = rm.GetString("isotools_fileName");
            this.Label6.Text = rm.GetString("isotools_fileSize");
            this.Label7.Text = rm.GetString("dell_sha256");
            this.Label8.Text = rm.GetString("isotools_ReleaseDate");
            this.Text = $"HeiDoc.net Windows ISO Downloader {"8.03"}";
            enableButtons = false;
            MSLogin = false;
            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://www.heidoc.net/php/whatsnew.html");
            request.UserAgent = $"Windows ISO Downloader/{"8.03"}";
            bool flag = false;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (Exception exception4)
            {
                ProjectData.SetProjectError(exception4);
                Exception exception2 = exception4;
                this.ToolStripStatusLabel1.Text = exception2.Message;
                internetError = true;
                flag = true;
                ProjectData.ClearProjectError();
            }
            if (!flag)
            {
                whatsNew = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            this.WebBrowser1.Navigate("about:blank");
            this.WebBrowser1.Document.Write(string.Empty);
            this.CreateDocText();
            this.WebBrowser1.DocumentText = docText;
            request = (HttpWebRequest) WebRequest.Create("https://www.heidoc.net/php/newadditions.php");
            request.UserAgent = $"Windows ISO Downloader/{"8.03"}";
            flag = false;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (Exception exception5)
            {
                ProjectData.SetProjectError(exception5);
                Exception exception3 = exception5;
                this.ToolStripStatusLabel1.Text = exception3.Message;
                internetError = true;
                flag = true;
                ProjectData.ClearProjectError();
            }
            if (!flag)
            {
                dropNewAdditions = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            if (dropNewAdditions != string.Empty)
            {
                this.RadioButton10.Enabled = true;
                this.RadioButton10.ForeColor = Color.Red;
            }
            this.FillDellTables();
            this.Timer1.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (this.WebBrowser1.Version.Major < 8)
            {
                MessageBox.Show(rm.GetString("RequireIE11Line1") + "\r\n" + rm.GetString("RequireIE11Line2"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                string str = Dns.GetHostEntry("aa.online-metrix.net").AddressList[0].ToString();
                string str2 = Dns.GetHostEntry("c.bing.com").AddressList[0].ToString();
                if ((((((((str == "0.0.0.0") | (str == "127.0.0.1")) | (str == "::1")) | (str == "::")) | (str2 == "0.0.0.0")) | (str2 == "127.0.0.1")) | (str2 == "::1")) | (str2 == "::"))
                {
                    MessageBox.Show($"{rm.GetString("HostsFileWarning")}{"\r\n"}0.0.0.0 aa.online-metrix.net{"\r\n"}0.0.0.0 c.bing.com", "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                if (!internetError)
                {
                    this.ToolStripStatusLabel1.Text = exception.Message;
                }
                ProjectData.ClearProjectError();
            }
            if (!this.CheckBox2.Checked)
            {
                MyProject.Forms.Form4.Show();
            }
        }

        private void GetLink2013()
        {
            string newValue = string.Empty;
            string str2 = string.Empty;
            if (this.RadioButton8.Checked)
            {
                link2013 = "https://officeredir.microsoft.com/r/rlidO15C2RMediaDownload?p1=db&p2=xxxxx&p3=yyyyy";
            }
            else if (this.RadioButton7.Checked)
            {
                link2013 = "https://officecdn.microsoft.com/pr/MacOffice2011/xxxxx/MicrosoftOffice2011.dmg";
            }
            else
            {
                link2013 = "https://officecdn.microsoft.com/db/492350F6-3A01-4F97-B9C0-C7C6DDF67D60/media/xxxxx/yyyyy.img";
            }
            object[] arguments = new object[] { "Personal" };
            string[] argumentNames = new string[] { "value" };
            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", arguments, argumentNames, null, null)))
            {
                newValue = "ja-JP";
                link2013 = link2013.Replace("xxxxx", newValue);
            }
            else
            {
                object[] objArray2 = new object[] { "Project" };
                string[] textArray2 = new string[] { "value" };
                object[] objArray3 = new object[] { "Visio" };
                string[] textArray3 = new string[] { "value" };
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray2, textArray2, null, null), NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray3, textArray3, null, null))))
                {
                    switch (this.ComboBox3.SelectedIndex)
                    {
                        case 0:
                            newValue = "ar-SA";
                            break;

                        case 1:
                            newValue = "cs-CZ";
                            break;

                        case 2:
                            newValue = "zh-CN";
                            break;

                        case 3:
                            newValue = "zh-TW";
                            break;

                        case 4:
                            newValue = "da-DK";
                            break;

                        case 5:
                            newValue = "de-DE";
                            break;

                        case 6:
                            newValue = "el-GR";
                            break;

                        case 7:
                            newValue = "en-US";
                            break;

                        case 8:
                            newValue = "es-ES";
                            break;

                        case 9:
                            newValue = "fr-FR";
                            break;

                        case 10:
                            newValue = "he-IL";
                            break;

                        case 11:
                            newValue = "it-IT";
                            break;

                        case 12:
                            newValue = "ja-JP";
                            break;

                        case 13:
                            newValue = "ko-KR";
                            break;

                        case 14:
                            newValue = "hu-HU";
                            break;

                        case 15:
                            newValue = "nl-NL";
                            break;

                        case 0x10:
                            newValue = "nb-NO";
                            break;

                        case 0x11:
                            newValue = "pl-PL";
                            break;

                        case 0x12:
                            newValue = "pt-BR";
                            break;

                        case 0x13:
                            newValue = "pt-PT";
                            break;

                        case 20:
                            newValue = "ro-RO";
                            break;

                        case 0x15:
                            newValue = "ru-RU";
                            break;

                        case 0x16:
                            newValue = "sk-SK";
                            break;

                        case 0x17:
                            newValue = "sl-SI";
                            break;

                        case 0x18:
                            newValue = "fi-FI";
                            break;

                        case 0x19:
                            newValue = "sv-SE";
                            break;

                        case 0x1a:
                            newValue = "tr-TR";
                            break;

                        case 0x1b:
                            newValue = "uk-UA";
                            break;
                    }
                }
                else
                {
                    object[] objArray4 = new object[] { "2011" };
                    string[] textArray4 = new string[] { "value" };
                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray4, textArray4, null, null)))
                    {
                        switch (this.ComboBox3.SelectedIndex)
                        {
                            case 0:
                                newValue = "zh-CN";
                                break;

                            case 1:
                                newValue = "zh-TW";
                                break;

                            case 2:
                                newValue = "da-DK";
                                break;

                            case 3:
                                newValue = "de-DE";
                                break;

                            case 4:
                                newValue = "en-US";
                                break;

                            case 5:
                                newValue = "es-ES";
                                break;

                            case 6:
                                newValue = "fr-FR";
                                break;

                            case 7:
                                newValue = "it-IT";
                                break;

                            case 8:
                                newValue = "ja-JP";
                                break;

                            case 9:
                                newValue = "nl-NL";
                                break;

                            case 10:
                                newValue = "nb-NO";
                                break;

                            case 11:
                                newValue = "pl-PL";
                                break;

                            case 12:
                                newValue = "ru-RU";
                                break;

                            case 13:
                                newValue = "fi-FI";
                                break;

                            case 14:
                                newValue = "sv-SE";
                                break;
                        }
                    }
                    else
                    {
                        switch (this.ComboBox3.SelectedIndex)
                        {
                            case 0:
                                newValue = "ar-SA";
                                break;

                            case 1:
                                newValue = "id-ID";
                                break;

                            case 2:
                                newValue = "ms-MY";
                                break;

                            case 3:
                                newValue = "bg-BG";
                                break;

                            case 4:
                                newValue = "cs-CZ";
                                break;

                            case 5:
                                newValue = "zh-CN";
                                break;

                            case 6:
                                newValue = "zh-TW";
                                break;

                            case 7:
                                newValue = "da-DK";
                                break;

                            case 8:
                                newValue = "de-DE";
                                break;

                            case 9:
                                newValue = "et-EE";
                                break;

                            case 10:
                                newValue = "el-GR";
                                break;

                            case 11:
                                newValue = "en-US";
                                break;

                            case 12:
                                newValue = "es-ES";
                                break;

                            case 13:
                                newValue = "fr-FR";
                                break;

                            case 14:
                                newValue = "he-IL";
                                break;

                            case 15:
                                newValue = "hi-IN";
                                break;

                            case 0x10:
                                newValue = "hr-HR";
                                break;

                            case 0x11:
                                newValue = "it-IT";
                                break;

                            case 0x12:
                                newValue = "ja-JP";
                                break;

                            case 0x13:
                                newValue = "kk-KZ";
                                break;

                            case 20:
                                newValue = "ko-KR";
                                break;

                            case 0x15:
                                newValue = "lv-LV";
                                break;

                            case 0x16:
                                newValue = "lt-LT";
                                break;

                            case 0x17:
                                newValue = "hu-HU";
                                break;

                            case 0x18:
                                newValue = "nl-NL";
                                break;

                            case 0x19:
                                newValue = "nb-NO";
                                break;

                            case 0x1a:
                                newValue = "pl-PL";
                                break;

                            case 0x1b:
                                newValue = "pt-BR";
                                break;

                            case 0x1c:
                                newValue = "pt-PT";
                                break;

                            case 0x1d:
                                newValue = "ro-RO";
                                break;

                            case 30:
                                newValue = "ru-RU";
                                break;

                            case 0x1f:
                                newValue = "sk-SK";
                                break;

                            case 0x20:
                                newValue = "sl-SI";
                                break;

                            case 0x21:
                                newValue = "sr-latn-RS";
                                break;

                            case 0x22:
                                newValue = "fi-FI";
                                break;

                            case 0x23:
                                newValue = "sv-SE";
                                break;

                            case 0x24:
                                newValue = "th-TH";
                                break;

                            case 0x25:
                                newValue = "vi-VN";
                                break;

                            case 0x26:
                                newValue = "tr-TR";
                                break;

                            case 0x27:
                                newValue = "uk-UA";
                                break;
                        }
                    }
                }
            }
            link2013 = link2013.Replace("xxxxx", newValue);
            object selectedItem = this.ComboBox2.SelectedItem;
            if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2013 Home and Student", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2016 Home and Student", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2019 Home and Student", false)))))
            {
                str2 = "HomeStudentRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2013 Personal", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2016 Personal", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2019 Personal", false)))))
            {
                str2 = "PersonalRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2013 Home and Business", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2016 Home and Business", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2019 Home and Business", false)))))
            {
                str2 = "HomeBusinessRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2013 Professional", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2016 Professional", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2019 Professional", false)))))
            {
                str2 = "ProfessionalRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2013 Professional Plus", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2016 Professional Plus", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Office 2019 Professional Plus", false)))))
            {
                str2 = "ProPlusRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Word 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Word 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Word 2019", false)))))
            {
                str2 = "WordRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Excel 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Excel 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Excel 2019", false)))))
            {
                str2 = "ExcelRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "PowerPoint 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "PowerPoint 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "PowerPoint 2019", false)))))
            {
                str2 = "PowerPointRetail";
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, "OneNote 2013", false))
            {
                str2 = "OneNoteRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Outlook 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Outlook 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Outlook 2019", false)))))
            {
                str2 = "OutlookRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Publisher 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Publisher 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Publisher 2019", false)))))
            {
                str2 = "PublisherRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Access 2013", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Access 2016", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Access 2019", false)))))
            {
                str2 = "AccessRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2013 Standard", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2016 Standard", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2019 Standard", false)))))
            {
                str2 = "ProjectStdRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2013 Professional", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2016 Professional", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Project 2019 Professional", false)))))
            {
                str2 = "ProjectProRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2013 Standard", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2016 Standard", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2019 Standard", false)))))
            {
                str2 = "VisioStdRetail";
            }
            else if (Conversions.ToBoolean((Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2013 Professional", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2016 Professional", false))) ? ((object) 1) : ((object) Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, "Visio 2019 Professional", false)))))
            {
                str2 = "VisioProRetail";
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, "Office 365 Home Premium", false))
            {
                str2 = "O365HomePremRetail";
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, "Office 365 Business", false))
            {
                str2 = "O365BusinessRetail";
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, "Office 365 Professional Plus", false))
            {
                str2 = "O365ProPlusRetail";
            }
            if (this.ComboBox2.SelectedItem.ToString().Contains("2019"))
            {
                str2 = str2.Replace("Retail", "2019Retail");
            }
            link2013 = link2013.Replace("yyyyy", str2);
        }

        private void GetLink2016Mac()
        {
            link2013 = "https://officecdn.microsoft.com/pr/C1297A47-86C4-4C1F-97FA-950631F94777/MacAutoupdate/Microsoft_xxxxx_yyyyy_Installer.pkg";
            if (this.RadioButton11.Checked)
            {
                link2013 = link2013.Replace("/MacAutoupdate/", "/OfficeMac/");
            }
            object[] arguments = new object[] { "Office 2019 Business Pro" };
            string[] argumentNames = new string[] { "value" };
            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", arguments, argumentNames, null, null)))
            {
                link2013 = link2013.Replace("xxxxx", "Office").Replace("_Installer.pkg", "_BusinessPro_Installer.pkg");
            }
            else
            {
                object[] objArray2 = new object[] { "Office" };
                string[] textArray2 = new string[] { "value" };
                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray2, textArray2, null, null)))
                {
                    if (this.RadioButton11.Checked)
                    {
                        link2013 = link2013.Replace("xxxxx", "Office_2016");
                    }
                    else
                    {
                        link2013 = link2013.Replace("xxxxx", "Office");
                    }
                }
                else
                {
                    object[] objArray3 = new object[] { "Word" };
                    string[] textArray3 = new string[] { "value" };
                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray3, textArray3, null, null)))
                    {
                        link2013 = link2013.Replace("xxxxx", "Word");
                    }
                    else
                    {
                        object[] objArray4 = new object[] { "Excel" };
                        string[] textArray4 = new string[] { "value" };
                        if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray4, textArray4, null, null)))
                        {
                            link2013 = link2013.Replace("xxxxx", "Excel");
                        }
                        else
                        {
                            object[] objArray5 = new object[] { "PowerPoint" };
                            string[] textArray5 = new string[] { "value" };
                            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray5, textArray5, null, null)))
                            {
                                link2013 = link2013.Replace("xxxxx", "PowerPoint");
                            }
                            else
                            {
                                object[] objArray6 = new object[] { "Outlook" };
                                string[] textArray6 = new string[] { "value" };
                                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray6, textArray6, null, null)))
                                {
                                    link2013 = link2013.Replace("xxxxx", "Outlook");
                                }
                                else
                                {
                                    object[] objArray7 = new object[] { "OneNote" };
                                    string[] textArray7 = new string[] { "value" };
                                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray7, textArray7, null, null)))
                                    {
                                        link2013 = link2013.Replace("xxxxx", "OneNote");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            object[] objArray8 = new object[] { "16.22.0" };
            string[] textArray8 = new string[] { "value" };
            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray8, textArray8, null, null)))
            {
                link2013 = link2013.Replace("yyyyy", "16.22.19021100");
            }
            else
            {
                object[] objArray9 = new object[] { "16.21.0" };
                string[] textArray9 = new string[] { "value" };
                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray9, textArray9, null, null)))
                {
                    link2013 = link2013.Replace("yyyyy", "16.21.19011500");
                }
                else
                {
                    object[] objArray10 = new object[] { "16.20.0" };
                    string[] textArray10 = new string[] { "value" };
                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray10, textArray10, null, null)))
                    {
                        link2013 = link2013.Replace("yyyyy", "16.20.18120801");
                    }
                    else
                    {
                        object[] objArray11 = new object[] { "16.19.0" };
                        string[] textArray11 = new string[] { "value" };
                        if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray11, textArray11, null, null)))
                        {
                            link2013 = link2013.Replace("yyyyy", "16.19.18110915");
                        }
                        else
                        {
                            object[] objArray12 = new object[] { "16.18.0" };
                            string[] textArray12 = new string[] { "value" };
                            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray12, textArray12, null, null)))
                            {
                                link2013 = link2013.Replace("yyyyy", "16.18.18101400");
                            }
                            else
                            {
                                object[] objArray13 = new object[] { "16.17.0" };
                                string[] textArray13 = new string[] { "value" };
                                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray13, textArray13, null, null)))
                                {
                                    link2013 = link2013.Replace("yyyyy", "16.17.18090901");
                                }
                                else
                                {
                                    object[] objArray14 = new object[] { "16.16.0" };
                                    string[] textArray14 = new string[] { "value" };
                                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray14, textArray14, null, null)))
                                    {
                                        link2013 = link2013.Replace("yyyyy", "16.16.18081201");
                                    }
                                    else
                                    {
                                        object[] objArray15 = new object[] { "16.15.0" };
                                        string[] textArray15 = new string[] { "value" };
                                        if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray15, textArray15, null, null)))
                                        {
                                            link2013 = link2013.Replace("yyyyy", "16.15.18070902");
                                        }
                                        else
                                        {
                                            object[] objArray16 = new object[] { "16.14.1" };
                                            string[] textArray16 = new string[] { "value" };
                                            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray16, textArray16, null, null)))
                                            {
                                                link2013 = link2013.Replace("yyyyy", "16.14.18061302");
                                            }
                                            else
                                            {
                                                object[] objArray17 = new object[] { "16.14.0" };
                                                string[] textArray17 = new string[] { "value" };
                                                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray17, textArray17, null, null)))
                                                {
                                                    link2013 = link2013.Replace("yyyyy", "16.14.18061000");
                                                }
                                                else
                                                {
                                                    object[] objArray18 = new object[] { "16.13.1" };
                                                    string[] textArray18 = new string[] { "value" };
                                                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray18, textArray18, null, null)))
                                                    {
                                                        link2013 = link2013.Replace("yyyyy", "16.13.18052304");
                                                    }
                                                    else
                                                    {
                                                        object[] objArray19 = new object[] { "16.12.0" };
                                                        string[] textArray19 = new string[] { "value" };
                                                        if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray19, textArray19, null, null)))
                                                        {
                                                            link2013 = link2013.Replace("yyyyy", "16.12.18041000");
                                                        }
                                                        else
                                                        {
                                                            object[] objArray20 = new object[] { "16.11.0" };
                                                            string[] textArray20 = new string[] { "value" };
                                                            if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray20, textArray20, null, null)))
                                                            {
                                                                link2013 = link2013.Replace("yyyyy", "16.11.18031100");
                                                            }
                                                            else
                                                            {
                                                                object[] objArray21 = new object[] { "16.10.0" };
                                                                string[] textArray21 = new string[] { "value" };
                                                                if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray21, textArray21, null, null)))
                                                                {
                                                                    link2013 = link2013.Replace("yyyyy", "16.10.18021001");
                                                                }
                                                                else
                                                                {
                                                                    object[] objArray22 = new object[] { "16.9.0" };
                                                                    string[] textArray22 = new string[] { "value" };
                                                                    if (Conversions.ToBoolean(NewLateBinding.LateGet(this.ComboBox2.SelectedItem, null, "Contains", objArray22, textArray22, null, null)))
                                                                    {
                                                                        link2013 = link2013.Replace("yyyyy", "16.9.18011602");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GetLinkDell()
        {
            Match match = new Regex("\"url\":\"([^\"]+)\",\"osCode\":\"([^\"]+)\",\"osCode90\":\\[([^\\[\\]]+)\\],\"size\":\"([^\"]+)\",\"sha256\":\"([^\"]+)\",\"title\":\"([^\"]+)\",\"shippedOS\":([^\"]+),\"swbId\":\"([^\"]+)\",\"releaseDate\":\"([^\"]+)\"").Match(apidp);
            int selectedIndex = this.ComboBox3.SelectedIndex;
            for (int i = 0; i <= selectedIndex; i++)
            {
                link2013 = match.Groups[1].ToString();
                match = match.NextMatch();
            }
        }

        private void GetLinkExp()
        {
            switch (this.ComboBox2.SelectedIndex)
            {
                case 0:
                    switch (this.ComboBox3.SelectedIndex)
                    {
                        case 0:
                            link2013 = "https://download.microsoft.com/download/E/D/C/EDC7D9A2-5649-49CB-B0D0-C13CF607454F/Web_Trial_zh-Hans.exe";
                            return;

                        case 1:
                            link2013 = "https://download.microsoft.com/download/2/B/E/2BE7AA64-07FA-4E37-99CD-BC9722691FB7/Web_Trial_zh-Hant.exe";
                            return;

                        case 2:
                            link2013 = "https://download.microsoft.com/download/4/C/D/4CD17612-4DD7-4968-9B2B-26D68CFB1A63/Web_Trial_de.exe";
                            return;

                        case 3:
                            link2013 = "https://download.microsoft.com/download/F/D/8/FD88D81D-52B5-486A-A53F-CCDB485D5258/Web_Trial_en.exe";
                            return;

                        case 4:
                            link2013 = "https://download.microsoft.com/download/E/D/F/EDF72C01-578E-40A2-9502-9C15F70EC524/Web_Trial_es.exe";
                            return;

                        case 5:
                            link2013 = "https://download.microsoft.com/download/3/A/E/3AEA9622-43FF-4806-9918-36C367C26AFF/Web_Trial_fr.exe";
                            return;

                        case 6:
                            link2013 = "https://download.microsoft.com/download/9/B/E/9BEDC17B-52BE-40A7-96B2-54E4E7E76905/Web_Trial_it.exe";
                            return;

                        case 7:
                            link2013 = "https://download.microsoft.com/download/8/3/2/8326FD52-3C69-4BD5-BE8C-EB509A5ACB7A/Web_Trial_ja.exe";
                            return;

                        case 8:
                            link2013 = "https://download.microsoft.com/download/1/0/2/1028A09D-3DE8-477A-96BD-5BE562E2C925/Web_Trial_ko.exe";
                            return;
                    }
                    return;

                case 1:
                    switch (this.ComboBox3.SelectedIndex)
                    {
                        case 0:
                            link2013 = "https://download.microsoft.com/download/A/F/6/AF67E8A2-F74C-41E4-8A71-12F8B0782E33/SuperPreview_Trial_zh-Hans.exe";
                            return;

                        case 1:
                            link2013 = "https://download.microsoft.com/download/C/F/2/CF2E22A2-FBAE-4A98-943F-966D9DB862C7/SuperPreview_Trial_zh-Hant.exe";
                            return;

                        case 2:
                            link2013 = "https://download.microsoft.com/download/0/5/9/059CC742-3883-40FF-886A-705A9B5CF69C/SuperPreview_Trial_de.exe";
                            return;

                        case 3:
                            link2013 = "https://download.microsoft.com/download/7/9/6/796296D9-A564-4D37-AF95-3D3D47EE82E9/SuperPreview_Trial_en.exe";
                            return;

                        case 4:
                            link2013 = "https://download.microsoft.com/download/6/D/2/6D20DC9D-6F2F-4174-AC6D-88B3C8FA0C04/SuperPreview_Trial_es.exe";
                            return;

                        case 5:
                            link2013 = "https://download.microsoft.com/download/0/C/2/0C2EB5B3-0709-4E2A-B52A-D547FF6A751E/SuperPreview_Trial_fr.exe";
                            return;

                        case 6:
                            link2013 = "https://download.microsoft.com/download/1/2/9/1293BBBE-1939-420E-882C-06B8B0D0DFE5/SuperPreview_Trial_it.exe";
                            return;

                        case 7:
                            link2013 = "https://download.microsoft.com/download/6/5/A/65A8E7B1-738B-41E3-BB15-FFBC22A6E094/SuperPreview_Trial_ja.exe";
                            return;

                        case 8:
                            link2013 = "https://download.microsoft.com/download/0/4/0/040D9D75-1A99-46D2-8568-F6CF69E42263/SuperPreview_Trial_ko.exe";
                            return;
                    }
                    return;

                case 2:
                    switch (this.ComboBox3.SelectedIndex)
                    {
                        case 0:
                            link2013 = "https://download.microsoft.com/download/E/5/8/E586D2D2-DAD7-4CD2-B1FE-1D2780698219/Encoder_zh-Hans.exe";
                            return;

                        case 1:
                            link2013 = "https://download.microsoft.com/download/1/C/9/1C9697C7-F367-4B85-AFDA-2ACF2BABA3AE/Encoder_zh-Hant.exe";
                            return;

                        case 2:
                            link2013 = "https://download.microsoft.com/download/F/8/A/F8A92CD1-A18E-4D05-962A-123EF03485D1/Encoder_de.exe";
                            return;

                        case 3:
                            link2013 = "https://download.microsoft.com/download/4/3/2/4328EFC5-4F3B-47C8-B21D-75CAD2E575C2/Encoder_en.exe";
                            return;

                        case 4:
                            link2013 = "https://download.microsoft.com/download/6/4/A/64AAFD0F-8BAB-4FBE-8982-FA199FC07C59/Encoder_es.exe";
                            return;

                        case 5:
                            link2013 = "https://download.microsoft.com/download/8/5/F/85F2FFF8-39E0-4712-B659-03119F3318BC/Encoder_fr.exe";
                            return;

                        case 6:
                            link2013 = "https://download.microsoft.com/download/0/D/B/0DBE0A36-07B3-4FDF-A4B7-3E637C5A7288/Encoder_ja.exe";
                            return;

                        case 7:
                            link2013 = "https://download.microsoft.com/download/9/C/9/9C92F393-42A2-4E4E-BE73-E1FB2B96A716/Encoder_ko.exe";
                            return;

                        case 8:
                            link2013 = string.Empty;
                            return;
                    }
                    return;

                case 3:
                    switch (this.ComboBox3.SelectedIndex)
                    {
                        case 0:
                            link2013 = "https://download.microsoft.com/download/2/1/7/217124F7-B295-4E5E-B463-B84205ACB85C/Design_Trial_zh-Hans.exe";
                            return;

                        case 1:
                            link2013 = "https://download.microsoft.com/download/6/E/E/6EECDD57-75D1-4388-9FA6-0EF308B3099E/Design_Trial_zh-Hant.exe";
                            return;

                        case 2:
                            link2013 = "https://download.microsoft.com/download/6/B/7/6B7D00BB-1B30-4B8A-B416-DFDDECE15A2A/Design_Trial_de.exe";
                            return;

                        case 3:
                            link2013 = "https://download.microsoft.com/download/C/6/8/C6866D29-E373-4F3F-98F0-E80903E77852/Design_Trial_en.exe";
                            return;

                        case 4:
                            link2013 = "https://download.microsoft.com/download/0/9/F/09F43A7D-635D-4CB5-9F59-48A8CF1C23E9/Design_Trial_es.exe";
                            return;

                        case 5:
                            link2013 = "https://download.microsoft.com/download/C/C/9/CC910D3D-AD61-42E1-81B5-6A31DA2431EB/Design_Trial_fr.exe";
                            return;

                        case 6:
                            link2013 = "https://download.microsoft.com/download/B/2/2/B22166C6-DC8A-4E62-AF54-E90BFF64666E/Design_Trial_it.exe";
                            return;

                        case 7:
                            link2013 = "https://download.microsoft.com/download/1/F/5/1F52F901-147A-45FB-A46E-B8D2823761AD/Design_Trial_ja.exe";
                            return;

                        case 8:
                            link2013 = "https://download.microsoft.com/download/D/3/F/D3F87368-1D8C-4A0E-A9FC-01D61940A5FC/Design_Trial_ko.exe";
                            return;
                    }
                    return;
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
            this.StatusStrip1 = new StatusStrip();
            this.CheckBox1 = new CheckBox();
            this.Button4 = new Button();
            this.ComboBox3 = new ComboBox();
            this.Label2 = new Label();
            this.ComboBox2 = new ComboBox();
            this.Label1 = new Label();
            this.RichTextBox1 = new RichTextBox();
            this.ComboBox1 = new ComboBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button3 = new Button();
            this.Button1 = new Button();
            this.RadioButton11 = new RadioButton();
            this.RadioButton10 = new RadioButton();
            this.RadioButton9 = new RadioButton();
            this.RadioButton7 = new RadioButton();
            this.RadioButton8 = new RadioButton();
            this.RadioButton6 = new RadioButton();
            this.RadioButton5 = new RadioButton();
            this.RadioButton4 = new RadioButton();
            this.RadioButton3 = new RadioButton();
            this.RadioButton2 = new RadioButton();
            this.RadioButton1 = new RadioButton();
            this.Button2 = new Button();
            this.RadioButton12 = new RadioButton();
            this.WebBrowser1 = new WebBrowser();
            this.ToolTip1 = new ToolTip(this.components);
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.RadioButton17 = new RadioButton();
            this.TabPage2 = new TabPage();
            this.RadioButton16 = new RadioButton();
            this.TabPage4 = new TabPage();
            this.RadioButton13 = new RadioButton();
            this.RadioButton15 = new RadioButton();
            this.RadioButton14 = new RadioButton();
            this.TabPage3 = new TabPage();
            this.CheckBox3 = new CheckBox();
            this.CheckBox2 = new CheckBox();
            this.Label3 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.LinkLabel2 = new LinkLabel();
            this.LinkLabel3 = new LinkLabel();
            this.LinkLabel4 = new LinkLabel();
            this.LinkLabel5 = new LinkLabel();
            this.LinkLabel6 = new LinkLabel();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.LinkLabel7 = new LinkLabel();
            this.GroupBox1 = new GroupBox();
            this.PictureBox10 = new PictureBox();
            this.RadioButton31 = new RadioButton();
            this.RadioButton30 = new RadioButton();
            this.Label4 = new Label();
            this.TextBox4 = new TextBox();
            this.Label8 = new Label();
            this.TextBox3 = new TextBox();
            this.Label7 = new Label();
            this.TextBox2 = new TextBox();
            this.Label6 = new Label();
            this.TextBox1 = new TextBox();
            this.Label5 = new Label();
            this.RadioButton29 = new RadioButton();
            this.RadioButton28 = new RadioButton();
            this.RadioButton27 = new RadioButton();
            this.RadioButton26 = new RadioButton();
            this.RadioButton25 = new RadioButton();
            this.RadioButton24 = new RadioButton();
            this.RadioButton22 = new RadioButton();
            this.RadioButton21 = new RadioButton();
            this.RadioButton20 = new RadioButton();
            this.RadioButton19 = new RadioButton();
            this.RadioButton23 = new RadioButton();
            this.RadioButton18 = new RadioButton();
            this.PictureBox9 = new PictureBox();
            this.PictureBox8 = new PictureBox();
            this.PictureBox7 = new PictureBox();
            this.PictureBox6 = new PictureBox();
            this.PictureBox5 = new PictureBox();
            this.PictureBox4 = new PictureBox();
            this.PictureBox3 = new PictureBox();
            this.PictureBox2 = new PictureBox();
            this.PictureBox1 = new PictureBox();
            this.StatusStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox10).BeginInit();
            ((ISupportInitialize) this.PictureBox9).BeginInit();
            ((ISupportInitialize) this.PictureBox8).BeginInit();
            ((ISupportInitialize) this.PictureBox7).BeginInit();
            ((ISupportInitialize) this.PictureBox6).BeginInit();
            ((ISupportInitialize) this.PictureBox5).BeginInit();
            ((ISupportInitialize) this.PictureBox4).BeginInit();
            ((ISupportInitialize) this.PictureBox3).BeginInit();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.ToolStripStatusLabel1.AccessibleRole = AccessibleRole.StatusBar;
            this.ToolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new Size(0x3db, 0x11);
            this.ToolStripStatusLabel1.Spring = true;
            this.ToolStripStatusLabel1.Text = "OK";
            this.ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            this.StatusStrip1.AccessibleRole = AccessibleRole.StatusBar;
            this.StatusStrip1.AutoSize = false;
            this.StatusStrip1.ImageScalingSize = new Size(20, 20);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripStatusLabel1 };
            this.StatusStrip1.Items.AddRange(toolStripItems);
            this.StatusStrip1.Location = new Point(0, 0x237);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new Size(0x3ea, 0x16);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 0x40;
            this.StatusStrip1.Text = "StatusStrip1";
            this.CheckBox1.AccessibleRole = AccessibleRole.CheckButton;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = CheckState.Checked;
            this.CheckBox1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CheckBox1.Location = new Point(6, 0x3e);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new Size(0x66, 0x17);
            this.CheckBox1.TabIndex = 0x15;
            this.CheckBox1.Text = "Expert View";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.Button4.AccessibleRole = AccessibleRole.PushButton;
            this.Button4.Enabled = false;
            this.Button4.Location = new Point(30, 0xab);
            this.Button4.Name = "Button4";
            this.Button4.Size = new Size(100, 0x1c);
            this.Button4.TabIndex = 0x27;
            this.Button4.Text = "Download";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Visible = false;
            this.ComboBox3.AccessibleName = "Select the product language";
            this.ComboBox3.AccessibleRole = AccessibleRole.DropList;
            this.ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new Point(260, 0x79);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new Size(0x1e6, 0x1b);
            this.ComboBox3.TabIndex = 0x26;
            this.ComboBox3.Visible = false;
            this.Label2.AccessibleRole = AccessibleRole.StaticText;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x1b, 0x81);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(180, 0x13);
            this.Label2.TabIndex = 0x25;
            this.Label2.Text = "Select the product language";
            this.Label2.Visible = false;
            this.ComboBox2.AccessibleName = "Select Edition";
            this.ComboBox2.AccessibleRole = AccessibleRole.DropList;
            this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new Point(260, 0x54);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new Size(0x1e6, 0x1b);
            this.ComboBox2.TabIndex = 0x24;
            this.ComboBox2.Visible = false;
            this.Label1.AccessibleRole = AccessibleRole.StaticText;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x1b, 0x5c);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(90, 0x13);
            this.Label1.TabIndex = 0x23;
            this.Label1.Text = "Select Edition";
            this.Label1.Visible = false;
            this.RichTextBox1.AccessibleRole = AccessibleRole.StaticText;
            this.RichTextBox1.BorderStyle = BorderStyle.None;
            this.RichTextBox1.Enabled = false;
            this.RichTextBox1.Font = new Font("Segoe UI", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RichTextBox1.Location = new Point(30, 0x21);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new Size(370, 0x2d);
            this.RichTextBox1.TabIndex = 0x22;
            this.RichTextBox1.Text = "Office 2013";
            this.RichTextBox1.Visible = false;
            this.ComboBox1.AccessibleName = "Language";
            this.ComboBox1.AccessibleRole = AccessibleRole.DropList;
            this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBox1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBox1.FormattingEnabled = true;
            object[] items = new object[] { 
                "Arabic (العربية)", "Български", "Čeština", "Chinese, CN (简体中文, 中国)", "Chinese, HK (繁體中文, 香港)", "Chinese, TW (繁體中文, 台灣)", "Dansk", "Deutsch", "Eesti", "Ελληνικά", "English, UK", "English, US", "Espa\x00f1ol, ES", "Espa\x00f1ol, MX", "Fran\x00e7ais, CA", "Fran\x00e7ais, FR",
                "Hebrew (עברית)", "Hrvatska", "Italiano", "Japanese (日本語)", "Korean (한국어)", "Latviešu", "Lietuvių", "Magyar", "Nederlands", "Norsk bokm\x00e5l", "Polski", "Portugu\x00eas, BR", "Portugu\x00eas, PT", "Rom\x00e2nă", "Русский", "Slovenčina",
                "Slovenščina", "Srpski", "Suomi", "Svenska", "Thai (ไทย)", "T\x00fcrk\x00e7e", "Українська"
            };
            this.ComboBox1.Items.AddRange(items);
            this.ComboBox1.Location = new Point(6, 0x1d);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new Size(0xb1, 0x1b);
            this.ComboBox1.TabIndex = 20;
            this.Button3.AccessibleRole = AccessibleRole.PushButton;
            this.Button3.Enabled = false;
            this.Button3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button3.Location = new Point(0x30a, 0x148);
            this.Button3.Name = "Button3";
            this.Button3.Size = new Size(0xd6, 0x1c);
            this.Button3.TabIndex = 0x1a;
            this.Button3.Text = "Copy Link (other)";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button1.AccessibleRole = AccessibleRole.PushButton;
            this.Button1.Enabled = false;
            this.Button1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button1.Location = new Point(0x30a, 0x108);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0xd6, 0x1c);
            this.Button1.TabIndex = 0x18;
            this.Button1.Text = "Copy Link for 32 bit";
            this.Button1.UseVisualStyleBackColor = true;
            this.RadioButton11.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton11.AutoSize = true;
            this.RadioButton11.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton11.Location = new Point(6, 0x97);
            this.RadioButton11.Name = "RadioButton11";
            this.RadioButton11.Size = new Size(0x98, 0x17);
            this.RadioButton11.TabIndex = 14;
            this.RadioButton11.TabStop = true;
            this.RadioButton11.Text = "Office 2016 for Mac";
            this.RadioButton11.UseVisualStyleBackColor = true;
            this.RadioButton10.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton10.AutoSize = true;
            this.RadioButton10.Enabled = false;
            this.RadioButton10.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton10.Location = new Point(6, 180);
            this.RadioButton10.Name = "RadioButton10";
            this.RadioButton10.Size = new Size(0x77, 0x17);
            this.RadioButton10.TabIndex = 8;
            this.RadioButton10.TabStop = true;
            this.RadioButton10.Text = "New Additions";
            this.RadioButton10.UseVisualStyleBackColor = true;
            this.RadioButton9.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton9.AutoSize = true;
            this.RadioButton9.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton9.Location = new Point(6, 0x40);
            this.RadioButton9.Name = "RadioButton9";
            this.RadioButton9.Size = new Size(0x65, 0x17);
            this.RadioButton9.TabIndex = 11;
            this.RadioButton9.TabStop = true;
            this.RadioButton9.Text = "Office 2016";
            this.RadioButton9.UseVisualStyleBackColor = true;
            this.RadioButton7.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton7.AutoSize = true;
            this.RadioButton7.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton7.Location = new Point(6, 0x7a);
            this.RadioButton7.Name = "RadioButton7";
            this.RadioButton7.Size = new Size(0x98, 0x17);
            this.RadioButton7.TabIndex = 13;
            this.RadioButton7.TabStop = true;
            this.RadioButton7.Text = "Office 2011 for Mac";
            this.RadioButton7.UseVisualStyleBackColor = true;
            this.RadioButton8.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton8.AutoSize = true;
            this.RadioButton8.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton8.Location = new Point(6, 0x23);
            this.RadioButton8.Name = "RadioButton8";
            this.RadioButton8.Size = new Size(0x65, 0x17);
            this.RadioButton8.TabIndex = 10;
            this.RadioButton8.TabStop = true;
            this.RadioButton8.Text = "Office 2013";
            this.RadioButton8.UseVisualStyleBackColor = true;
            this.RadioButton6.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton6.AutoSize = true;
            this.RadioButton6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton6.Location = new Point(6, 6);
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.Size = new Size(0x65, 0x17);
            this.RadioButton6.TabIndex = 9;
            this.RadioButton6.TabStop = true;
            this.RadioButton6.Text = "Office 2010";
            this.RadioButton6.UseVisualStyleBackColor = true;
            this.RadioButton5.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton5.Location = new Point(6, 0x5d);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new Size(0x65, 0x17);
            this.RadioButton5.TabIndex = 12;
            this.RadioButton5.TabStop = true;
            this.RadioButton5.Text = "Office 2019";
            this.RadioButton5.UseVisualStyleBackColor = true;
            this.RadioButton4.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton4.Location = new Point(6, 0x7a);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new Size(0x7a, 0x17);
            this.RadioButton4.TabIndex = 6;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "Insider Preview";
            this.RadioButton4.UseVisualStyleBackColor = true;
            this.RadioButton3.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton3.Location = new Point(6, 0x40);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new Size(0x6a, 0x17);
            this.RadioButton3.TabIndex = 4;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Windows 10";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton2.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton2.Location = new Point(6, 0x23);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new Size(0x6d, 0x17);
            this.RadioButton2.TabIndex = 3;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Windows 8.1";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton1.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton1.Location = new Point(6, 6);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(0x62, 0x17);
            this.RadioButton1.TabIndex = 2;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Windows 7";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.Button2.AccessibleRole = AccessibleRole.PushButton;
            this.Button2.Enabled = false;
            this.Button2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button2.Location = new Point(0x30a, 0x128);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0xd6, 0x1c);
            this.Button2.TabIndex = 0x19;
            this.Button2.Text = "Copy Link for 64 bit";
            this.Button2.UseVisualStyleBackColor = true;
            this.RadioButton12.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton12.AutoSize = true;
            this.RadioButton12.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton12.Location = new Point(6, 0x97);
            this.RadioButton12.Name = "RadioButton12";
            this.RadioButton12.Size = new Size(0x5c, 0x17);
            this.RadioButton12.TabIndex = 7;
            this.RadioButton12.TabStop = true;
            this.RadioButton12.Text = "Developer";
            this.RadioButton12.UseVisualStyleBackColor = true;
            this.WebBrowser1.AllowWebBrowserDrop = false;
            this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser1.Location = new Point(4, 12);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.ScrollBarsEnabled = false;
            this.WebBrowser1.Size = new Size(770, 0x227);
            this.WebBrowser1.TabIndex = 0;
            this.WebBrowser1.Url = new Uri("", UriKind.Relative);
            this.WebBrowser1.WebBrowserShortcutsEnabled = false;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.ToolTipIcon = ToolTipIcon.Warning;
            this.TabControl1.AccessibleRole = AccessibleRole.Pane;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new Point(0x30a, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0xd6, 0xf6);
            this.TabControl1.TabIndex = 1;
            this.TabPage1.Controls.Add(this.RadioButton17);
            this.TabPage1.Controls.Add(this.RadioButton12);
            this.TabPage1.Controls.Add(this.RadioButton10);
            this.TabPage1.Controls.Add(this.RadioButton1);
            this.TabPage1.Controls.Add(this.RadioButton2);
            this.TabPage1.Controls.Add(this.RadioButton3);
            this.TabPage1.Controls.Add(this.RadioButton4);
            this.TabPage1.Location = new Point(4, 0x1c);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0xce, 0xd6);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Windows";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.RadioButton17.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton17.AutoSize = true;
            this.RadioButton17.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton17.Location = new Point(6, 0x5d);
            this.RadioButton17.Name = "RadioButton17";
            this.RadioButton17.Size = new Size(0x3d, 0x17);
            this.RadioButton17.TabIndex = 5;
            this.RadioButton17.TabStop = true;
            this.RadioButton17.Text = "DELL";
            this.RadioButton17.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.RadioButton16);
            this.TabPage2.Controls.Add(this.RadioButton11);
            this.TabPage2.Controls.Add(this.RadioButton5);
            this.TabPage2.Controls.Add(this.RadioButton9);
            this.TabPage2.Controls.Add(this.RadioButton6);
            this.TabPage2.Controls.Add(this.RadioButton8);
            this.TabPage2.Controls.Add(this.RadioButton7);
            this.TabPage2.Location = new Point(4, 0x1c);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0xce, 0xd6);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Office";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.RadioButton16.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton16.AutoSize = true;
            this.RadioButton16.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton16.Location = new Point(6, 180);
            this.RadioButton16.Name = "RadioButton16";
            this.RadioButton16.Size = new Size(0x98, 0x17);
            this.RadioButton16.TabIndex = 15;
            this.RadioButton16.TabStop = true;
            this.RadioButton16.Text = "Office 2019 for Mac";
            this.RadioButton16.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.RadioButton13);
            this.TabPage4.Controls.Add(this.RadioButton15);
            this.TabPage4.Controls.Add(this.RadioButton14);
            this.TabPage4.Location = new Point(4, 0x1c);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0xce, 0xd6);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Other";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.RadioButton13.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton13.AutoSize = true;
            this.RadioButton13.Enabled = false;
            this.RadioButton13.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton13.Location = new Point(6, 6);
            this.RadioButton13.Name = "RadioButton13";
            this.RadioButton13.Size = new Size(0xa3, 0x17);
            this.RadioButton13.TabIndex = 0x10;
            this.RadioButton13.TabStop = true;
            this.RadioButton13.Text = "Xbox Deveopment Kit";
            this.RadioButton13.UseVisualStyleBackColor = true;
            this.RadioButton15.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton15.AutoSize = true;
            this.RadioButton15.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton15.Location = new Point(6, 0x40);
            this.RadioButton15.Name = "RadioButton15";
            this.RadioButton15.Size = new Size(0x9c, 0x17);
            this.RadioButton15.TabIndex = 0x12;
            this.RadioButton15.TabStop = true;
            this.RadioButton15.Text = "Microsoft Expression";
            this.RadioButton15.UseVisualStyleBackColor = true;
            this.RadioButton14.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton14.AutoSize = true;
            this.RadioButton14.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RadioButton14.Location = new Point(6, 0x23);
            this.RadioButton14.Name = "RadioButton14";
            this.RadioButton14.Size = new Size(0xaf, 0x17);
            this.RadioButton14.TabIndex = 0x11;
            this.RadioButton14.TabStop = true;
            this.RadioButton14.Text = "Windows Admin Center";
            this.RadioButton14.UseVisualStyleBackColor = true;
            this.TabPage3.AccessibleRole = AccessibleRole.CheckButton;
            this.TabPage3.Controls.Add(this.CheckBox3);
            this.TabPage3.Controls.Add(this.CheckBox2);
            this.TabPage3.Controls.Add(this.Label3);
            this.TabPage3.Controls.Add(this.CheckBox1);
            this.TabPage3.Controls.Add(this.ComboBox1);
            this.TabPage3.Location = new Point(4, 0x1c);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0xce, 0xd6);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Settings";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.CheckBox3.AccessibleRole = AccessibleRole.CheckButton;
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CheckBox3.Location = new Point(6, 120);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new Size(0x70, 0x17);
            this.CheckBox3.TabIndex = 0x17;
            this.CheckBox3.Text = "Save Settings";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox2.AccessibleRole = AccessibleRole.CheckButton;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Enabled = false;
            this.CheckBox2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CheckBox2.Location = new Point(6, 0x5b);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new Size(0x69, 0x17);
            this.CheckBox2.TabIndex = 0x16;
            this.CheckBox2.Text = "Remove ads";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.Label3.AccessibleRole = AccessibleRole.StaticText;
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(6, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x45, 0x13);
            this.Label3.TabIndex = 0x13;
            this.Label3.Text = "Language";
            this.LinkLabel1.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel1.AutoEllipsis = true;
            this.LinkLabel1.BackColor = Color.Transparent;
            this.LinkLabel1.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel1.Location = new Point(0x306, 0x169);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new Size(0x67, 0x18);
            this.LinkLabel1.TabIndex = 0x1b;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "About...";
            this.LinkLabel1.TextAlign = ContentAlignment.TopCenter;
            this.LinkLabel2.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel2.AutoEllipsis = true;
            this.LinkLabel2.BackColor = Color.Transparent;
            this.LinkLabel2.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel2.Location = new Point(0x373, 0x169);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new Size(0x67, 0x18);
            this.LinkLabel2.TabIndex = 0x1c;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Forum";
            this.LinkLabel2.TextAlign = ContentAlignment.TopCenter;
            this.LinkLabel3.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel3.AutoEllipsis = true;
            this.LinkLabel3.BackColor = Color.Transparent;
            this.LinkLabel3.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel3.Location = new Point(0x306, 0x19d);
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.Size = new Size(0x67, 0x18);
            this.LinkLabel3.TabIndex = 0x1d;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "Mailing List";
            this.LinkLabel3.TextAlign = ContentAlignment.TopCenter;
            this.LinkLabel4.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel4.AutoEllipsis = true;
            this.LinkLabel4.BackColor = Color.Transparent;
            this.LinkLabel4.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel4.Location = new Point(0x373, 0x19d);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new Size(0x67, 0x18);
            this.LinkLabel4.TabIndex = 30;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "ISO Tools";
            this.LinkLabel4.TextAlign = ContentAlignment.TopCenter;
            this.LinkLabel5.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel5.AutoEllipsis = true;
            this.LinkLabel5.BackColor = Color.Transparent;
            this.LinkLabel5.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel5.Location = new Point(0x30a, 0x1d1);
            this.LinkLabel5.Name = "LinkLabel5";
            this.LinkLabel5.Size = new Size(0x67, 0x18);
            this.LinkLabel5.TabIndex = 0x1f;
            this.LinkLabel5.TabStop = true;
            this.LinkLabel5.Text = "Buy Windows or Office";
            this.LinkLabel5.TextAlign = ContentAlignment.TopCenter;
            this.LinkLabel6.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel6.AutoEllipsis = true;
            this.LinkLabel6.BackColor = Color.Transparent;
            this.LinkLabel6.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel6.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel6.Location = new Point(0x373, 0x1d1);
            this.LinkLabel6.Name = "LinkLabel6";
            this.LinkLabel6.Size = new Size(0x67, 0x18);
            this.LinkLabel6.TabIndex = 0x20;
            this.LinkLabel6.TabStop = true;
            this.LinkLabel6.Text = "Donation";
            this.LinkLabel6.TextAlign = ContentAlignment.TopCenter;
            this.OpenFileDialog1.Filter = manager.GetString("OpenFileDialog1.Filter");
            this.OpenFileDialog1.Title = "HeiDoc.net";
            this.LinkLabel7.AccessibleRole = AccessibleRole.Link;
            this.LinkLabel7.AutoSize = true;
            this.LinkLabel7.Font = new Font("Segoe UI", 8f);
            this.LinkLabel7.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkLabel7.LinkColor = Color.Yellow;
            this.LinkLabel7.Location = new Point(0x30a, 0x221);
            this.LinkLabel7.Name = "LinkLabel7";
            this.LinkLabel7.Size = new Size(0xd3, 0x13);
            this.LinkLabel7.TabIndex = 0x21;
            this.LinkLabel7.TabStop = true;
            this.LinkLabel7.Text = "HeiDoc.net vs. Amazon Full Story";
            this.GroupBox1.Controls.Add(this.PictureBox10);
            this.GroupBox1.Controls.Add(this.RadioButton31);
            this.GroupBox1.Controls.Add(this.RadioButton30);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.RadioButton29);
            this.GroupBox1.Controls.Add(this.RadioButton28);
            this.GroupBox1.Controls.Add(this.RadioButton27);
            this.GroupBox1.Controls.Add(this.RadioButton26);
            this.GroupBox1.Controls.Add(this.RadioButton25);
            this.GroupBox1.Controls.Add(this.RadioButton24);
            this.GroupBox1.Controls.Add(this.RadioButton22);
            this.GroupBox1.Controls.Add(this.RadioButton21);
            this.GroupBox1.Controls.Add(this.RadioButton20);
            this.GroupBox1.Controls.Add(this.RadioButton19);
            this.GroupBox1.Controls.Add(this.RadioButton23);
            this.GroupBox1.Controls.Add(this.RadioButton18);
            this.GroupBox1.Location = new Point(30, 0xd4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x2cc, 0x13b);
            this.GroupBox1.TabIndex = 40;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "DELL Tools";
            this.GroupBox1.Visible = false;
            this.PictureBox10.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox10.Location = new Point(7, 0xb3);
            this.PictureBox10.Name = "PictureBox10";
            this.PictureBox10.Size = new Size(0x81, 0x81);
            this.PictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox10.TabIndex = 0x3f;
            this.PictureBox10.TabStop = false;
            this.RadioButton31.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton31.AutoSize = true;
            this.RadioButton31.Location = new Point(0x1a1, 0xc5);
            this.RadioButton31.Name = "RadioButton31";
            this.RadioButton31.Size = new Size(0x127, 0x17);
            this.RadioButton31.TabIndex = 0x3b;
            this.RadioButton31.TabStop = true;
            this.RadioButton31.Text = "Windows 10 Professional S 64-Bit Compact";
            this.RadioButton31.UseVisualStyleBackColor = true;
            this.RadioButton30.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton30.AutoSize = true;
            this.RadioButton30.Location = new Point(0x1a1, 0xaf);
            this.RadioButton30.Name = "RadioButton30";
            this.RadioButton30.Size = new Size(0xec, 0x17);
            this.RadioButton30.TabIndex = 0x3a;
            this.RadioButton30.TabStop = true;
            this.RadioButton30.Text = "Windows 10 Professional S 64-Bit";
            this.RadioButton30.UseVisualStyleBackColor = true;
            this.Label4.AccessibleRole = AccessibleRole.StaticText;
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(6, 0x9c);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x27, 0x13);
            this.Label4.TabIndex = 0x31;
            this.Label4.Text = "Filter";
            this.TextBox4.Location = new Point(0xa3, 0x79);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new Size(0x223, 0x1a);
            this.TextBox4.TabIndex = 0x30;
            this.Label8.AccessibleRole = AccessibleRole.StaticText;
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(6, 0x7c);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x57, 0x13);
            this.Label8.TabIndex = 0x2f;
            this.Label8.Text = "Release Date";
            this.TextBox3.Location = new Point(0xa3, 0x59);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new Size(0x223, 0x1a);
            this.TextBox3.TabIndex = 0x2e;
            this.Label7.AccessibleRole = AccessibleRole.StaticText;
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(6, 0x5c);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x5e, 0x13);
            this.Label7.TabIndex = 0x2d;
            this.Label7.Text = "SHA256 Hash";
            this.TextBox2.Location = new Point(0xa3, 0x39);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new Size(0x223, 0x1a);
            this.TextBox2.TabIndex = 0x2c;
            this.Label6.AccessibleRole = AccessibleRole.StaticText;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(6, 60);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x79, 0x13);
            this.Label6.TabIndex = 0x2b;
            this.Label6.Text = "File Size in MBytes";
            this.TextBox1.Location = new Point(0xa3, 0x19);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new Size(0x223, 0x1a);
            this.TextBox1.TabIndex = 0x2a;
            this.Label5.AccessibleRole = AccessibleRole.StaticText;
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(6, 0x1c);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x79, 0x13);
            this.Label5.TabIndex = 0x29;
            this.Label5.Text = "Original File Name";
            this.RadioButton29.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton29.AutoSize = true;
            this.RadioButton29.Location = new Point(0x1a1, 0x11d);
            this.RadioButton29.Name = "RadioButton29";
            this.RadioButton29.Size = new Size(0x4d, 0x17);
            this.RadioButton29.TabIndex = 0x3f;
            this.RadioButton29.TabStop = true;
            this.RadioButton29.Text = "Ubuntu";
            this.RadioButton29.UseVisualStyleBackColor = true;
            this.RadioButton28.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton28.AutoSize = true;
            this.RadioButton28.Location = new Point(0x1a1, 0x107);
            this.RadioButton28.Name = "RadioButton28";
            this.RadioButton28.Size = new Size(0xbb, 0x17);
            this.RadioButton28.TabIndex = 0x3e;
            this.RadioButton28.TabStop = true;
            this.RadioButton28.Text = "Windows 10 China 64-Bit";
            this.RadioButton28.UseVisualStyleBackColor = true;
            this.RadioButton27.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton27.AutoSize = true;
            this.RadioButton27.Location = new Point(0x1a1, 0x9a);
            this.RadioButton27.Name = "RadioButton27";
            this.RadioButton27.Size = new Size(0xe1, 0x17);
            this.RadioButton27.TabIndex = 0x39;
            this.RadioButton27.TabStop = true;
            this.RadioButton27.Text = "Windows 10 Professional 64-Bit";
            this.RadioButton27.UseVisualStyleBackColor = true;
            this.RadioButton26.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton26.AutoSize = true;
            this.RadioButton26.Location = new Point(0xa3, 0x11d);
            this.RadioButton26.Name = "RadioButton26";
            this.RadioButton26.Size = new Size(0xf8, 0x17);
            this.RadioButton26.TabIndex = 0x38;
            this.RadioButton26.TabStop = true;
            this.RadioButton26.Text = "Windows 10 Home 64-Bit Compact";
            this.RadioButton26.UseVisualStyleBackColor = true;
            this.RadioButton25.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton25.AutoSize = true;
            this.RadioButton25.Location = new Point(0xa3, 0x107);
            this.RadioButton25.Name = "RadioButton25";
            this.RadioButton25.Size = new Size(0xbd, 0x17);
            this.RadioButton25.TabIndex = 0x37;
            this.RadioButton25.TabStop = true;
            this.RadioButton25.Text = "Windows 10 Home 64-Bit";
            this.RadioButton25.UseVisualStyleBackColor = true;
            this.RadioButton24.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton24.AutoSize = true;
            this.RadioButton24.Location = new Point(0x1a1, 0xf1);
            this.RadioButton24.Name = "RadioButton24";
            this.RadioButton24.Size = new Size(0xe1, 0x17);
            this.RadioButton24.TabIndex = 0x3d;
            this.RadioButton24.TabStop = true;
            this.RadioButton24.Text = "Windows 10 SL 64-Bit Compact";
            this.RadioButton24.UseVisualStyleBackColor = true;
            this.RadioButton22.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton22.AutoSize = true;
            this.RadioButton22.Location = new Point(0xa3, 0xf1);
            this.RadioButton22.Name = "RadioButton22";
            this.RadioButton22.Size = new Size(0x97, 0x17);
            this.RadioButton22.TabIndex = 0x36;
            this.RadioButton22.TabStop = true;
            this.RadioButton22.Text = "Windows 8.1 64-Bit";
            this.RadioButton22.UseVisualStyleBackColor = true;
            this.RadioButton21.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton21.AutoSize = true;
            this.RadioButton21.Location = new Point(0xa3, 0xdb);
            this.RadioButton21.Name = "RadioButton21";
            this.RadioButton21.Size = new Size(0xd9, 0x17);
            this.RadioButton21.TabIndex = 0x35;
            this.RadioButton21.TabStop = true;
            this.RadioButton21.Text = "Windows 7 Professional 64-Bit";
            this.RadioButton21.UseVisualStyleBackColor = true;
            this.RadioButton20.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton20.AutoSize = true;
            this.RadioButton20.Location = new Point(0xa3, 0xc5);
            this.RadioButton20.Name = "RadioButton20";
            this.RadioButton20.Size = new Size(0xd9, 0x17);
            this.RadioButton20.TabIndex = 0x34;
            this.RadioButton20.TabStop = true;
            this.RadioButton20.Text = "Windows 7 Professional 32-Bit";
            this.RadioButton20.UseVisualStyleBackColor = true;
            this.RadioButton19.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton19.AutoSize = true;
            this.RadioButton19.Location = new Point(0xa3, 0xaf);
            this.RadioButton19.Name = "RadioButton19";
            this.RadioButton19.Size = new Size(0xd7, 0x17);
            this.RadioButton19.TabIndex = 0x33;
            this.RadioButton19.TabStop = true;
            this.RadioButton19.Text = "Windows 7 Home Basic 64-Bit";
            this.RadioButton19.UseVisualStyleBackColor = true;
            this.RadioButton23.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton23.AutoSize = true;
            this.RadioButton23.Location = new Point(0x1a1, 0xdb);
            this.RadioButton23.Name = "RadioButton23";
            this.RadioButton23.Size = new Size(0xa6, 0x17);
            this.RadioButton23.TabIndex = 60;
            this.RadioButton23.TabStop = true;
            this.RadioButton23.Text = "Windows 10 SL 64-Bit";
            this.RadioButton23.UseVisualStyleBackColor = true;
            this.RadioButton18.AccessibleRole = AccessibleRole.RadioButton;
            this.RadioButton18.AutoSize = true;
            this.RadioButton18.Location = new Point(0xa3, 0x99);
            this.RadioButton18.Name = "RadioButton18";
            this.RadioButton18.Size = new Size(0xd7, 0x17);
            this.RadioButton18.TabIndex = 50;
            this.RadioButton18.TabStop = true;
            this.RadioButton18.Text = "Windows 7 Home Basic 32-Bit";
            this.RadioButton18.UseVisualStyleBackColor = true;
            this.PictureBox9.AccessibleName = "YouTube";
            this.PictureBox9.AccessibleRole = AccessibleRole.Link;
            this.PictureBox9.Cursor = Cursors.Hand;
            this.PictureBox9.Image = (Image) manager.GetObject("PictureBox9.Image");
            this.PictureBox9.Location = new Point(0x3c7, 0x205);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new Size(0x19, 0x19);
            this.PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox9.TabIndex = 60;
            this.PictureBox9.TabStop = false;
            this.PictureBox8.AccessibleName = "Twitter";
            this.PictureBox8.AccessibleRole = AccessibleRole.Link;
            this.PictureBox8.Cursor = Cursors.Hand;
            this.PictureBox8.Image = Windows_ISO_Downloader.My.Resources.Resources.twitter_square_brands;
            this.PictureBox8.Location = new Point(0x3a8, 0x205);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new Size(0x19, 0x19);
            this.PictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox8.TabIndex = 0x3b;
            this.PictureBox8.TabStop = false;
            this.PictureBox7.AccessibleName = "Facebook";
            this.PictureBox7.AccessibleRole = AccessibleRole.Link;
            this.PictureBox7.Cursor = Cursors.Hand;
            this.PictureBox7.Image = Windows_ISO_Downloader.My.Resources.Resources.facebook_brands;
            this.PictureBox7.Location = new Point(0x389, 0x205);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new Size(0x19, 0x19);
            this.PictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox7.TabIndex = 0x3a;
            this.PictureBox7.TabStop = false;
            this.PictureBox6.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox6.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox6.Image = Windows_ISO_Downloader.My.Resources.Resources.cc_paypal_brands;
            this.PictureBox6.Location = new Point(0x377, 0x1d1);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new Size(0x69, 0x2e);
            this.PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox6.TabIndex = 0x39;
            this.PictureBox6.TabStop = false;
            this.PictureBox5.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox5.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox5.Image = Windows_ISO_Downloader.My.Resources.Resources.windows_brands;
            this.PictureBox5.Location = new Point(0x30a, 0x1d1);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new Size(0x69, 0x2e);
            this.PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 0x38;
            this.PictureBox5.TabStop = false;
            this.PictureBox4.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox4.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox4.Image = Windows_ISO_Downloader.My.Resources.Resources.compact_disc;
            this.PictureBox4.Location = new Point(0x377, 0x19d);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new Size(0x69, 0x2e);
            this.PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox4.TabIndex = 0x37;
            this.PictureBox4.TabStop = false;
            this.PictureBox3.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox3.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox3.Image = Windows_ISO_Downloader.My.Resources.Resources.envelope_square_solid;
            this.PictureBox3.Location = new Point(0x30a, 0x19d);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new Size(0x69, 0x2e);
            this.PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 0x36;
            this.PictureBox3.TabStop = false;
            this.PictureBox2.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = Windows_ISO_Downloader.My.Resources.Resources.wincert;
            this.PictureBox2.Location = new Point(0x377, 0x169);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x69, 0x2e);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x35;
            this.PictureBox2.TabStop = false;
            this.PictureBox1.AccessibleRole = AccessibleRole.Graphic;
            this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox1.Image = Windows_ISO_Downloader.My.Resources.Resources.info_circle_solid;
            this.PictureBox1.Location = new Point(0x30a, 0x169);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x69, 0x2e);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0x34;
            this.PictureBox1.TabStop = false;
            base.AccessibleRole = AccessibleRole.Application;
            base.AutoScaleDimensions = new SizeF(8f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3ea, 0x24d);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.LinkLabel7);
            base.Controls.Add(this.PictureBox9);
            base.Controls.Add(this.PictureBox8);
            base.Controls.Add(this.PictureBox7);
            base.Controls.Add(this.LinkLabel6);
            base.Controls.Add(this.LinkLabel5);
            base.Controls.Add(this.LinkLabel4);
            base.Controls.Add(this.LinkLabel3);
            base.Controls.Add(this.LinkLabel2);
            base.Controls.Add(this.LinkLabel1);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.StatusStrip1);
            base.Controls.Add(this.Button4);
            base.Controls.Add(this.ComboBox3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.ComboBox2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.RichTextBox1);
            base.Controls.Add(this.Button3);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.Button2);
            base.Controls.Add(this.WebBrowser1);
            base.Controls.Add(this.PictureBox6);
            base.Controls.Add(this.PictureBox5);
            base.Controls.Add(this.PictureBox4);
            base.Controls.Add(this.PictureBox3);
            base.Controls.Add(this.PictureBox2);
            base.Controls.Add(this.PictureBox1);
            this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            this.MaximumSize = new Size(0x400, 640);
            this.MinimumSize = new Size(0x400, 640);
            base.Name = "Form1";
            this.Text = "HeiDoc.net Windows ISO Downloader";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((ISupportInitialize) this.PictureBox10).EndInit();
            ((ISupportInitialize) this.PictureBox9).EndInit();
            ((ISupportInitialize) this.PictureBox8).EndInit();
            ((ISupportInitialize) this.PictureBox7).EndInit();
            ((ISupportInitialize) this.PictureBox6).EndInit();
            ((ISupportInitialize) this.PictureBox5).EndInit();
            ((ISupportInitialize) this.PictureBox4).EndInit();
            ((ISupportInitialize) this.PictureBox3).EndInit();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel1.LinkVisited = true;
            MyProject.Forms.Form5.ShowDialog();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel2.LinkVisited = true;
            try
            {
                Process.Start(rm.GetString("ForumUrl"));
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel3.LinkVisited = true;
            try
            {
                Process.Start("https://heidoc.net/mailman/listinfo/win-iso_heidoc.net?language=" + rm.GetString("language"));
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OpenFileDialog1.FileName = string.Empty;
            this.OpenFileDialog1.ShowDialog();
            if (this.OpenFileDialog1.FileName != string.Empty)
            {
                MyProject.Forms.Form2.ShowDialog();
            }
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel5.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/joomla/technology-science/microsoft/67-microsoft-windows-and-office-iso-download-tool?showall=&start=3");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel6.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/php/donations.php");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinkLabel7.LinkVisited = true;
            try
            {
                Process.Start("https://www.heidoc.net/joomla/amazon-global/46-heidoc-net-vs-amazon-com-part-1-the-history-of-a-legal-dispute");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.heidoc.net/joomla/technology-science/microsoft/67-microsoft-windows-and-office-iso-download-tool?showall=&start=3");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(rm.GetString("ForumUrl"));
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://twitter.com/heidocnetwork");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.facebook.com/HeiDoc/");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.youtube.com/c/HeiDocnet");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.ToolStripStatusLabel1.Text = exception.Message;
                ProjectData.ClearProjectError();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton1.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                if (dropWin7 == string.Empty)
                {
                    winVersion = "win7.html";
                    this.DownloadDropdown();
                    dropWin7 = dropText;
                }
                else
                {
                    dropText = dropWin7;
                }
                this.DisplayDownload();
            }
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton10.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                dropText = dropNewAdditions;
                this.DisplayTechbench();
            }
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton11.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2016 for Mac";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.15.0");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.14.1");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.14.0");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.13.1");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.12.0");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.11.0");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.10.0");
                this.ComboBox2.Items.Add("Office 2016 for Mac 16.9.0");
            }
        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton12.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                if (dropWin10dev == string.Empty)
                {
                    winVersion = "win10developer.html";
                    this.DownloadDropdown();
                    dropWin10dev = dropText;
                }
                else
                {
                    dropText = dropWin10dev;
                }
                this.DisplayTechbench();
            }
        }

        private void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton14.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton16.Checked = false;
                this.RadioButton17.Checked = false;
                if (dropHonolulu == string.Empty)
                {
                    winVersion = "honolulu.html";
                    this.DownloadDropdown();
                    dropHonolulu = dropText;
                }
                else
                {
                    dropText = dropHonolulu;
                }
                this.DisplayTechbench();
            }
        }

        private void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton15.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton16.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Microsoft Expression";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Microsoft Expression Web 4");
                this.ComboBox2.Items.Add("Microsoft Expression Web 4 Super Preview");
                this.ComboBox2.Items.Add("Microsoft Expression Encoder 4");
                this.ComboBox2.Items.Add("Microsoft Expression Design 4");
            }
        }

        private void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton16.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2019 for Mac";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.Add2016Mac("16.22.0");
                this.Add2016Mac("16.21.0");
                this.ComboBox2.Items.Add("Office 2019 for Mac 16.20.0");
                this.ComboBox2.Items.Add("Word 2019 for Mac 16.20.0");
                this.ComboBox2.Items.Add("Excel 2019 for Mac 16.20.0");
                this.ComboBox2.Items.Add("PowerPoint 2019 for Mac 16.20.0");
                this.ComboBox2.Items.Add("Outlook 2019 for Mac 16.20.0");
            }
        }

        private void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton17.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                this.RichTextBox1.Text = rm.GetString("DellOEM");
                this.Label1.Text = rm.GetString("Model");
                this.Label2.Text = rm.GetString("Image");
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = true;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.RadioButton18.Checked = false;
                this.RadioButton19.Checked = false;
                this.RadioButton20.Checked = false;
                this.RadioButton21.Checked = false;
                this.RadioButton22.Checked = false;
                this.RadioButton23.Checked = false;
                this.RadioButton24.Checked = false;
                this.RadioButton25.Checked = false;
                this.RadioButton26.Checked = false;
                this.RadioButton27.Checked = false;
                this.RadioButton28.Checked = false;
                this.RadioButton29.Checked = false;
                this.RadioButton31.Checked = false;
                this.RadioButton29.Checked = false;
                this.TextBox1.Text = string.Empty;
                this.TextBox2.Text = string.Empty;
                this.TextBox3.Text = string.Empty;
                this.TextBox4.Text = string.Empty;
                this.PictureBox10.Image = null;
                IEnumerable<string> enumerable = systemTable.AsEnumerable().Select<DataRow, string>(((_Closure$__.$I62-0 == null) ? (_Closure$__.$I62-0 = new Func<DataRow, string>(_Closure$__.$I._Lambda$__62-0)) : _Closure$__.$I62-0)).Distinct<string>();
                foreach (string str in enumerable)
                {
                    this.ComboBox2.Items.Add(str);
                }
            }
        }

        private void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W7H32";
            this.FilterDell();
        }

        private void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W7H64";
            this.FilterDell();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton2.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                if (dropWin8 == string.Empty)
                {
                    winVersion = "win8.html";
                    this.DownloadDropdown();
                    dropWin8 = dropText;
                }
                else
                {
                    dropText = dropWin8;
                }
                this.DisplayTechbench();
            }
        }

        private void RadioButton20_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W7P32";
            this.FilterDell();
        }

        private void RadioButton21_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W7P64";
            this.FilterDell();
        }

        private void RadioButton22_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W8";
            this.FilterDell();
        }

        private void RadioButton23_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10S";
            this.FilterDell();
        }

        private void RadioButton24_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10SC";
            this.FilterDell();
        }

        private void RadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10H";
            this.FilterDell();
        }

        private void RadioButton26_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10HC";
            this.FilterDell();
        }

        private void RadioButton27_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10P";
            this.FilterDell();
        }

        private void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10C";
            this.FilterDell();
        }

        private void RadioButton29_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "U";
            this.FilterDell();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton3.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                if (dropWin10 == string.Empty)
                {
                    winVersion = "win10.html";
                    this.DownloadDropdown();
                    dropWin10 = dropText;
                }
                else
                {
                    dropText = dropWin10;
                }
                this.DisplayTechbench();
            }
        }

        private void RadioButton30_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10PS";
            this.FilterDell();
        }

        private void RadioButton31_CheckedChanged(object sender, EventArgs e)
        {
            dellOS = "W10PSC";
            this.FilterDell();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton4.Checked)
            {
                this.RadioButton5.Checked = false;
                this.RadioButton6.Checked = false;
                this.RadioButton7.Checked = false;
                this.RadioButton8.Checked = false;
                this.RadioButton9.Checked = false;
                this.RadioButton11.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton16.Checked = false;
                if (dropWin10ins == string.Empty)
                {
                    winVersion = "win10insider.html";
                    this.DownloadDropdown();
                    dropWin10ins = dropText;
                }
                else
                {
                    dropText = dropWin10ins;
                }
                this.DisplayTechbench();
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton5.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2019";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Office 2019 Home and Student");
                this.ComboBox2.Items.Add("Office 2019 Personal");
                this.ComboBox2.Items.Add("Office 2019 Home and Business");
                this.ComboBox2.Items.Add("Office 2019 Professional");
                this.ComboBox2.Items.Add("Office 2019 Professional Plus");
                this.ComboBox2.Items.Add("Word 2019");
                this.ComboBox2.Items.Add("Excel 2019");
                this.ComboBox2.Items.Add("PowerPoint 2019");
                this.ComboBox2.Items.Add("Outlook 2019");
                this.ComboBox2.Items.Add("Publisher 2019");
                this.ComboBox2.Items.Add("Access 2019");
                this.ComboBox2.Items.Add("Project 2019 Standard");
                this.ComboBox2.Items.Add("Project 2019 Professional");
                this.ComboBox2.Items.Add("Visio 2019 Standard");
                this.ComboBox2.Items.Add("Visio 2019 Professional");
            }
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton6.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                if (dropOffice10 == string.Empty)
                {
                    winVersion = "office2010.html";
                    this.DownloadDropdown();
                    dropOffice10 = dropText;
                }
                else
                {
                    dropText = dropOffice10;
                }
                this.DisplayDownload();
            }
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton7.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2011 for Mac";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Office 2011");
            }
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton8.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2013";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Office 2013 Home and Student");
                this.ComboBox2.Items.Add("Office 2013 Personal");
                this.ComboBox2.Items.Add("Office 2013 Home and Business");
                this.ComboBox2.Items.Add("Office 2013 Professional");
                this.ComboBox2.Items.Add("Word 2013");
                this.ComboBox2.Items.Add("Excel 2013");
                this.ComboBox2.Items.Add("PowerPoint 2013");
                this.ComboBox2.Items.Add("OneNote 2013");
                this.ComboBox2.Items.Add("Outlook 2013");
                this.ComboBox2.Items.Add("Publisher 2013");
                this.ComboBox2.Items.Add("Access 2013");
                this.ComboBox2.Items.Add("Project 2013 Standard");
                this.ComboBox2.Items.Add("Project 2013 Professional");
                this.ComboBox2.Items.Add("Visio 2013 Standard");
                this.ComboBox2.Items.Add("Visio 2013 Professional");
                this.ComboBox2.Items.Add("Office 365 Home Premium");
            }
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton9.Checked)
            {
                this.RadioButton1.Checked = false;
                this.RadioButton2.Checked = false;
                this.RadioButton3.Checked = false;
                this.RadioButton4.Checked = false;
                this.RadioButton10.Checked = false;
                this.RadioButton12.Checked = false;
                this.RadioButton13.Checked = false;
                this.RadioButton14.Checked = false;
                this.RadioButton15.Checked = false;
                this.RadioButton17.Checked = false;
                this.WebBrowser1.Visible = false;
                this.GroupBox1.Visible = false;
                this.RichTextBox1.Visible = true;
                this.Label1.Visible = true;
                this.Label2.Visible = true;
                this.ComboBox2.Visible = true;
                this.ComboBox3.Visible = true;
                this.Button4.Visible = true;
                this.Button4.Enabled = false;
                this.RichTextBox1.Text = "Office 2016";
                this.Label1.Text = rm.GetString("SelectEdition");
                this.Label2.Text = rm.GetString("SelectLanguage");
                this.ComboBox2.Items.Clear();
                this.ComboBox3.Items.Clear();
                this.ComboBox2.Items.Add("Office 2016 Home and Student");
                this.ComboBox2.Items.Add("Office 2016 Personal");
                this.ComboBox2.Items.Add("Office 2016 Home and Business");
                this.ComboBox2.Items.Add("Office 2016 Professional");
                this.ComboBox2.Items.Add("Office 2016 Professional Plus");
                this.ComboBox2.Items.Add("Word 2016");
                this.ComboBox2.Items.Add("Excel 2016");
                this.ComboBox2.Items.Add("PowerPoint 2016");
                this.ComboBox2.Items.Add("Outlook 2016");
                this.ComboBox2.Items.Add("Publisher 2016");
                this.ComboBox2.Items.Add("Access 2016");
                this.ComboBox2.Items.Add("Project 2016 Standard");
                this.ComboBox2.Items.Add("Project 2016 Professional");
                this.ComboBox2.Items.Add("Visio 2016 Standard");
                this.ComboBox2.Items.Add("Visio 2016 Professional");
                this.ComboBox2.Items.Add("Office 365 Home Premium");
                this.ComboBox2.Items.Add("Office 365 Business");
                this.ComboBox2.Items.Add("Office 365 Professional Plus");
            }
        }

        private void TabPage3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickOrder = $"L{clickOrder}";
            }
            else if (e.Button == MouseButtons.Right)
            {
                clickOrder = $"R{clickOrder}";
            }
            if (clickOrder.Length > 9)
            {
                clickOrder = clickOrder.Substring(0, 9);
            }
            if (clickOrder == "RRRLLRRLR")
            {
                this.CheckBox2.Enabled = true;
                this.CheckBox2.Checked = true;
                this.CheckBox3.Checked = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool flag = false;
            if (!this.LinkLabel7.LinkVisited)
            {
                byte num;
                byte num2;
                byte num3;
                byte num4 = (byte) (colour % 0x100);
                if ((colour >= 0) && (colour < 0x100))
                {
                    num = 0xff;
                    num2 = (byte) (0xff - num4);
                    num3 = 0;
                }
                else if ((colour >= 0x100) && (colour < 0x200))
                {
                    num = (byte) (0xff - num4);
                    num2 = 0;
                    num3 = num4;
                }
                else if ((colour >= 0x200) && (colour < 0x300))
                {
                    num = 0;
                    num2 = num4;
                    num3 = (byte) (0xff - num4);
                }
                else
                {
                    num = num4;
                    num2 = 0xff;
                    num3 = 0;
                }
                this.LinkLabel7.LinkColor = Color.FromArgb(num, num2, num3);
                colour++;
                if (colour >= 0x400)
                {
                    colour = 0;
                }
            }
            if ((((this.RadioButton5.Checked | this.RadioButton7.Checked) | this.RadioButton8.Checked) | this.RadioButton9.Checked) | this.RadioButton15.Checked)
            {
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                if (this.Button4.Enabled)
                {
                    this.Button3.Enabled = true;
                    flag = true;
                }
                else
                {
                    this.Button3.Enabled = false;
                }
            }
            if (this.RadioButton11.Checked | this.RadioButton16.Checked)
            {
                this.Button3.Enabled = false;
                if (this.Button4.Enabled && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.ComboBox2.SelectedItem, string.Empty, false))
                {
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = true;
                    flag = true;
                }
                else
                {
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = false;
                }
            }
            if (this.RadioButton17.Checked)
            {
                if (this.ComboBox3.Text == string.Empty)
                {
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                }
                else if (this.ComboBox3.Text.Contains("32"))
                {
                    this.Button1.Enabled = true;
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                }
                else if (this.ComboBox3.Text.Contains("64"))
                {
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = true;
                    this.Button3.Enabled = false;
                }
                else
                {
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = true;
                }
            }
            if ((this.WebBrowser1.ReadyState != WebBrowserReadyState.Complete) && !enableButtons)
            {
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                enableButtons = false;
                if (!flag)
                {
                    this.Button3.Enabled = false;
                }
            }
            else if ((this.WebBrowser1.Document.Body != null) && !(((((((this.RadioButton5.Checked | this.RadioButton7.Checked) | this.RadioButton8.Checked) | this.RadioButton9.Checked) | this.RadioButton11.Checked) | this.RadioButton15.Checked) | this.RadioButton16.Checked) | this.RadioButton17.Checked))
            {
                enableButtons = true;
                if (this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\": IsoX86") | this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\":IsoX86"))
                {
                    this.Button1.Enabled = true;
                }
                else
                {
                    this.Button1.Enabled = false;
                }
                if (this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\": IsoX64") | this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\":IsoX64"))
                {
                    this.Button2.Enabled = true;
                }
                else
                {
                    this.Button2.Enabled = false;
                }
                if (this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\": Unknown") | this.WebBrowser1.Document.Body.OuterHtml.Contains("\"DownloadType\":Unknown"))
                {
                    this.Button3.Enabled = true;
                }
                else if (!flag)
                {
                    this.Button3.Enabled = false;
                }
            }
            if ((MSLogin && (this.WebBrowser1.Document.Url.Host != "login.live.com")) && isIdle)
            {
                MSLogin = false;
                this.DisplayTechbench();
            }
            if (this.WebBrowser1.Visible && ((this.WebBrowser1.Document.Url.Host == "account.microsoft.com") | (this.WebBrowser1.Document.Url.Host == "signup.live.com")))
            {
                this.DisplayTechbench();
            }
            if (this.WebBrowser1.Visible && isIdle)
            {
                try
                {
                    if (this.WebBrowser1.Document.GetElementById("uhfLogo").Style != "display: none;")
                    {
                        reload = true;
                        this.DisplayTechbench();
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    ProjectData.ClearProjectError();
                }
            }
            if ((((((((this.RadioButton2.Checked | this.RadioButton3.Checked) | this.RadioButton4.Checked) | this.RadioButton10.Checked) | this.RadioButton12.Checked) | this.RadioButton14.Checked) && (this.WebBrowser1.ReadyState == WebBrowserReadyState.Complete)) && ((this.WebBrowser1.Document.Body.OuterHtml.Contains("<h2 id=\"errorModalTitle\">") | this.WebBrowser1.Document.Body.OuterHtml.Contains("<h2 id=errorModalTitle>")) && !this.WebBrowser1.Document.Body.OuterHtml.Contains("715-123130"))) && !liveLogin)
            {
                liveLogin = true;
                MessageBox.Show(rm.GetString("MicrosoftLogin"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Wait(float seconds)
        {
            this.$STATIC$Wait$2011C$start = (float) DateAndTime.Timer;
            while (DateAndTime.Timer < (this.$STATIC$Wait$2011C$start + seconds))
            {
                Application.DoEvents();
            }
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString().StartsWith("https://www.heidoc.net"))
            {
                e.Cancel = true;
                if (e.Url.ToString() == "https://www.heidoc.net/selectedition")
                {
                    prodIDW7 = this.WebBrowser1.Document.GetElementById("product-edition").GetAttribute("value");
                    if (prodIDW7 == string.Empty)
                    {
                        this.WebBrowser1.Document.GetElementById("selectlanguage").Style = "display: none;";
                        this.WebBrowser1.Document.GetElementById("result").Style = "display: none;";
                    }
                    else
                    {
                        this.WebBrowser1.Document.GetElementById("selectlanguage").Style = "display: inherit;";
                        try
                        {
                            this.WebBrowser1.Document.GetElementById("product-languages").OuterHtml = "<select class=\"form-control\" id=\"product-languages\">" + langDropdown.GetString($"prod_{prodIDW7}").Replace("Choose one", rm.GetString("ChooseOne")) + "</select>";
                        }
                        catch (Exception exception1)
                        {
                            ProjectData.SetProjectError(exception1);
                            Exception exception = exception1;
                            MessageBox.Show($"Product ID {prodIDW7} Is currently unsupported!", "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            ProjectData.ClearProjectError();
                        }
                    }
                }
                else if (e.Url.ToString() == "https://www.heidoc.net/selectlanguage")
                {
                    langIDW7 = this.WebBrowser1.Document.GetElementById("product-languages").GetAttribute("value");
                    if (langIDW7 != string.Empty)
                    {
                        HttpWebResponse response = null;
                        HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://www.heidoc.net/php/isounlockv6.php?productEditionId={prodIDW7}&languageId={langIDW7}&luminati=1");
                        request.UserAgent = $"Windows ISO Downloader/{"8.03"}";
                        bool flag = false;
                        try
                        {
                            response = (HttpWebResponse) request.GetResponse();
                        }
                        catch (Exception exception3)
                        {
                            ProjectData.SetProjectError(exception3);
                            Exception exception2 = exception3;
                            MessageBox.Show(rm.GetString("CheckConnection"), "HeiDoc.net", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            this.ToolStripStatusLabel1.Text = exception2.Message;
                            flag = true;
                            ProjectData.ClearProjectError();
                        }
                        if (!flag)
                        {
                            string str = new StreamReader(response.GetResponseStream()).ReadToEnd().Replace("<button", "<button onclick=\"closeModal()\"");
                            this.WebBrowser1.Document.GetElementById("result").Style = "display: inherit;";
                            this.WebBrowser1.Document.GetElementById("selectedition").Style = "display: none;";
                            this.WebBrowser1.Document.GetElementById("selectlanguage").Style = "display: none;";
                            this.WebBrowser1.Document.GetElementById("result").InnerHtml = str;
                        }
                        else
                        {
                            this.WebBrowser1.Document.GetElementById("result").Style = "display: none;";
                        }
                    }
                    else
                    {
                        this.WebBrowser1.Document.GetElementById("result").Style = "display: none;";
                    }
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

        internal virtual Button Button3
        {
            [CompilerGenerated]
            get => 
                this._Button3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Button3_Click);
                Button button = this._Button3;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button3 = value;
                button = this._Button3;
                if (button != null)
                {
                    button.Click += handler;
                }
            }
        }

        internal virtual Button Button4
        {
            [CompilerGenerated]
            get => 
                this._Button4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Button4_Click);
                Button button = this._Button4;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button4 = value;
                button = this._Button4;
                if (button != null)
                {
                    button.Click += handler;
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

        internal virtual CheckBox CheckBox3
        {
            [CompilerGenerated]
            get => 
                this._CheckBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox3_CheckedChanged);
                CheckBox box = this._CheckBox3;
                if (box != null)
                {
                    box.CheckedChanged -= handler;
                }
                this._CheckBox3 = value;
                box = this._CheckBox3;
                if (box != null)
                {
                    box.CheckedChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBox1
        {
            [CompilerGenerated]
            get => 
                this._ComboBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
                ComboBox box = this._ComboBox1;
                if (box != null)
                {
                    box.SelectedIndexChanged -= handler;
                }
                this._ComboBox1 = value;
                box = this._ComboBox1;
                if (box != null)
                {
                    box.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBox2
        {
            [CompilerGenerated]
            get => 
                this._ComboBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ComboBox2_SelectedIndexChanged);
                ComboBox box = this._ComboBox2;
                if (box != null)
                {
                    box.SelectedIndexChanged -= handler;
                }
                this._ComboBox2 = value;
                box = this._ComboBox2;
                if (box != null)
                {
                    box.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBox3
        {
            [CompilerGenerated]
            get => 
                this._ComboBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ComboBox3_SelectedIndexChanged);
                ComboBox box = this._ComboBox3;
                if (box != null)
                {
                    box.SelectedIndexChanged -= handler;
                }
                this._ComboBox3 = value;
                box = this._ComboBox3;
                if (box != null)
                {
                    box.SelectedIndexChanged += handler;
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

        internal virtual LinkLabel LinkLabel5
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel5_LinkClicked);
                LinkLabel label = this._LinkLabel5;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel5 = value;
                label = this._LinkLabel5;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel6
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel6_LinkClicked);
                LinkLabel label = this._LinkLabel6;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel6 = value;
                label = this._LinkLabel6;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel7
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel7_LinkClicked);
                LinkLabel label = this._LinkLabel7;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel7 = value;
                label = this._LinkLabel7;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this._OpenFileDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._OpenFileDialog1 = value;
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

        internal virtual PictureBox PictureBox10
        {
            [CompilerGenerated]
            get => 
                this._PictureBox10;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox10 = value;
            }
        }

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this._PictureBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox2 = value;
            }
        }

        internal virtual PictureBox PictureBox3
        {
            [CompilerGenerated]
            get => 
                this._PictureBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox3 = value;
            }
        }

        internal virtual PictureBox PictureBox4
        {
            [CompilerGenerated]
            get => 
                this._PictureBox4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox4 = value;
            }
        }

        internal virtual PictureBox PictureBox5
        {
            [CompilerGenerated]
            get => 
                this._PictureBox5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox5 = value;
            }
        }

        internal virtual PictureBox PictureBox6
        {
            [CompilerGenerated]
            get => 
                this._PictureBox6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox6 = value;
            }
        }

        internal virtual PictureBox PictureBox7
        {
            [CompilerGenerated]
            get => 
                this._PictureBox7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PictureBox7_Click);
                PictureBox box = this._PictureBox7;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox7 = value;
                box = this._PictureBox7;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox8
        {
            [CompilerGenerated]
            get => 
                this._PictureBox8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PictureBox8_Click);
                PictureBox box = this._PictureBox8;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox8 = value;
                box = this._PictureBox8;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox9
        {
            [CompilerGenerated]
            get => 
                this._PictureBox9;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PictureBox9_Click);
                PictureBox box = this._PictureBox9;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox9 = value;
                box = this._PictureBox9;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton1
        {
            [CompilerGenerated]
            get => 
                this._RadioButton1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton1_CheckedChanged);
                RadioButton button = this._RadioButton1;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton1 = value;
                button = this._RadioButton1;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton10
        {
            [CompilerGenerated]
            get => 
                this._RadioButton10;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton10_CheckedChanged);
                RadioButton button = this._RadioButton10;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton10 = value;
                button = this._RadioButton10;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton11
        {
            [CompilerGenerated]
            get => 
                this._RadioButton11;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton11_CheckedChanged);
                RadioButton button = this._RadioButton11;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton11 = value;
                button = this._RadioButton11;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton12
        {
            [CompilerGenerated]
            get => 
                this._RadioButton12;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton12_CheckedChanged);
                RadioButton button = this._RadioButton12;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton12 = value;
                button = this._RadioButton12;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton13
        {
            [CompilerGenerated]
            get => 
                this._RadioButton13;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._RadioButton13 = value;
            }
        }

        internal virtual RadioButton RadioButton14
        {
            [CompilerGenerated]
            get => 
                this._RadioButton14;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton14_CheckedChanged);
                RadioButton button = this._RadioButton14;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton14 = value;
                button = this._RadioButton14;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton15
        {
            [CompilerGenerated]
            get => 
                this._RadioButton15;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton15_CheckedChanged);
                RadioButton button = this._RadioButton15;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton15 = value;
                button = this._RadioButton15;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton16
        {
            [CompilerGenerated]
            get => 
                this._RadioButton16;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton16_CheckedChanged);
                RadioButton button = this._RadioButton16;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton16 = value;
                button = this._RadioButton16;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton17
        {
            [CompilerGenerated]
            get => 
                this._RadioButton17;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton17_CheckedChanged);
                RadioButton button = this._RadioButton17;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton17 = value;
                button = this._RadioButton17;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton18
        {
            [CompilerGenerated]
            get => 
                this._RadioButton18;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton18_CheckedChanged);
                RadioButton button = this._RadioButton18;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton18 = value;
                button = this._RadioButton18;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton19
        {
            [CompilerGenerated]
            get => 
                this._RadioButton19;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton19_CheckedChanged);
                RadioButton button = this._RadioButton19;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton19 = value;
                button = this._RadioButton19;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton2
        {
            [CompilerGenerated]
            get => 
                this._RadioButton2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton2_CheckedChanged);
                RadioButton button = this._RadioButton2;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton2 = value;
                button = this._RadioButton2;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton20
        {
            [CompilerGenerated]
            get => 
                this._RadioButton20;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton20_CheckedChanged);
                RadioButton button = this._RadioButton20;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton20 = value;
                button = this._RadioButton20;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton21
        {
            [CompilerGenerated]
            get => 
                this._RadioButton21;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton21_CheckedChanged);
                RadioButton button = this._RadioButton21;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton21 = value;
                button = this._RadioButton21;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton22
        {
            [CompilerGenerated]
            get => 
                this._RadioButton22;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton22_CheckedChanged);
                RadioButton button = this._RadioButton22;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton22 = value;
                button = this._RadioButton22;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton23
        {
            [CompilerGenerated]
            get => 
                this._RadioButton23;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton23_CheckedChanged);
                RadioButton button = this._RadioButton23;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton23 = value;
                button = this._RadioButton23;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton24
        {
            [CompilerGenerated]
            get => 
                this._RadioButton24;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton24_CheckedChanged);
                RadioButton button = this._RadioButton24;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton24 = value;
                button = this._RadioButton24;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton25
        {
            [CompilerGenerated]
            get => 
                this._RadioButton25;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton25_CheckedChanged);
                RadioButton button = this._RadioButton25;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton25 = value;
                button = this._RadioButton25;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton26
        {
            [CompilerGenerated]
            get => 
                this._RadioButton26;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton26_CheckedChanged);
                RadioButton button = this._RadioButton26;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton26 = value;
                button = this._RadioButton26;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton27
        {
            [CompilerGenerated]
            get => 
                this._RadioButton27;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton27_CheckedChanged);
                RadioButton button = this._RadioButton27;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton27 = value;
                button = this._RadioButton27;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton28
        {
            [CompilerGenerated]
            get => 
                this._RadioButton28;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton28_CheckedChanged);
                RadioButton button = this._RadioButton28;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton28 = value;
                button = this._RadioButton28;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton29
        {
            [CompilerGenerated]
            get => 
                this._RadioButton29;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton29_CheckedChanged);
                RadioButton button = this._RadioButton29;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton29 = value;
                button = this._RadioButton29;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton3
        {
            [CompilerGenerated]
            get => 
                this._RadioButton3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton3_CheckedChanged);
                RadioButton button = this._RadioButton3;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton3 = value;
                button = this._RadioButton3;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton30
        {
            [CompilerGenerated]
            get => 
                this._RadioButton30;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton30_CheckedChanged);
                RadioButton button = this._RadioButton30;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton30 = value;
                button = this._RadioButton30;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton31
        {
            [CompilerGenerated]
            get => 
                this._RadioButton31;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton31_CheckedChanged);
                RadioButton button = this._RadioButton31;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton31 = value;
                button = this._RadioButton31;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton4
        {
            [CompilerGenerated]
            get => 
                this._RadioButton4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton4_CheckedChanged);
                RadioButton button = this._RadioButton4;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton4 = value;
                button = this._RadioButton4;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton5
        {
            [CompilerGenerated]
            get => 
                this._RadioButton5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton5_CheckedChanged);
                RadioButton button = this._RadioButton5;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton5 = value;
                button = this._RadioButton5;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton6
        {
            [CompilerGenerated]
            get => 
                this._RadioButton6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton6_CheckedChanged);
                RadioButton button = this._RadioButton6;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton6 = value;
                button = this._RadioButton6;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton7
        {
            [CompilerGenerated]
            get => 
                this._RadioButton7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton7_CheckedChanged);
                RadioButton button = this._RadioButton7;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton7 = value;
                button = this._RadioButton7;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton8
        {
            [CompilerGenerated]
            get => 
                this._RadioButton8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton8_CheckedChanged);
                RadioButton button = this._RadioButton8;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton8 = value;
                button = this._RadioButton8;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButton9
        {
            [CompilerGenerated]
            get => 
                this._RadioButton9;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RadioButton9_CheckedChanged);
                RadioButton button = this._RadioButton9;
                if (button != null)
                {
                    button.CheckedChanged -= handler;
                }
                this._RadioButton9 = value;
                button = this._RadioButton9;
                if (button != null)
                {
                    button.CheckedChanged += handler;
                }
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

        internal virtual StatusStrip StatusStrip1
        {
            [CompilerGenerated]
            get => 
                this._StatusStrip1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._StatusStrip1 = value;
            }
        }

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this._TabControl1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TabControl1 = value;
            }
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this._TabPage1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TabPage1 = value;
            }
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this._TabPage2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TabPage2 = value;
            }
        }

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this._TabPage3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.TabPage3_MouseDown);
                TabPage page = this._TabPage3;
                if (page != null)
                {
                    page.MouseDown -= handler;
                }
                this._TabPage3 = value;
                page = this._TabPage3;
                if (page != null)
                {
                    page.MouseDown += handler;
                }
            }
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this._TabPage4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TabPage4 = value;
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

        internal virtual System.Windows.Forms.Timer Timer1
        {
            [CompilerGenerated]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                System.Windows.Forms.Timer timer = this._Timer1;
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

        internal virtual ToolStripStatusLabel ToolStripStatusLabel1
        {
            [CompilerGenerated]
            get => 
                this._ToolStripStatusLabel1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._ToolStripStatusLabel1 = value;
            }
        }

        internal virtual ToolTip ToolTip1
        {
            [CompilerGenerated]
            get => 
                this._ToolTip1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._ToolTip1 = value;
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
                WebBrowserNavigatingEventHandler handler2 = new WebBrowserNavigatingEventHandler(this.WebBrowser1_Navigating);
                WebBrowser browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.NewWindow -= handler;
                    browser.Navigating -= handler2;
                }
                this._WebBrowser1 = value;
                browser = this._WebBrowser1;
                if (browser != null)
                {
                    browser.NewWindow += handler;
                    browser.Navigating += handler2;
                }
            }
        }

        [Serializable, CompilerGenerated]
        internal sealed class _Closure$__
        {
            public static readonly Form1._Closure$__ $I = new Form1._Closure$__();
            public static Func<DataRow, bool> $I111-0;
            public static Func<DataRow, string> $I62-0;

            internal bool _Lambda$__111-0(DataRow row) => 
                (row.Field<string>("os") == Form1.dellOS);

            internal string _Lambda$__62-0(DataRow row) => 
                row.Field<string>("model");
        }
    }
}

