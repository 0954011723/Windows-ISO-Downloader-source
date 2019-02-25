namespace Windows_ISO_Downloader.My.Resources
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [StandardModule, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"), DebuggerNonUserCode, CompilerGenerated, HideModuleName]
    internal sealed class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal static Bitmap cc_paypal_brands =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("cc_paypal_brands", resourceCulture)));

        internal static Bitmap compact_disc =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("compact_disc", resourceCulture)));

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => 
                resourceCulture;
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap envelope_square_solid =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("envelope_square_solid", resourceCulture)));

        internal static Bitmap facebook_brands =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("facebook_brands", resourceCulture)));

        internal static Bitmap info_circle_solid =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("info_circle_solid", resourceCulture)));

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    resourceMan = new System.Resources.ResourceManager("Windows_ISO_Downloader.Resources", typeof(Windows_ISO_Downloader.My.Resources.Resources).Assembly);
                }
                return resourceMan;
            }
        }

        internal static Bitmap twitter_square_brands =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("twitter_square_brands", resourceCulture)));

        internal static Bitmap wincert =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("wincert", resourceCulture)));

        internal static Bitmap windows_brands =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("windows_brands", resourceCulture)));

        internal static Bitmap youtube_square_brands =>
            ((Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("youtube_square_brands", resourceCulture)));
    }
}

