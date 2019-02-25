namespace Windows_ISO_Downloader
{
    using System;
    using System.Runtime.InteropServices;

    internal sealed class NativeMethods
    {
        private const int URLMON_OPTION_USERAGENT = 0x10000001;

        public void ChangeUserAgent(string Agent)
        {
            UrlMkSetSessionOption(0x10000001, Agent, Agent.Length, 0);
        }

        [DllImport("urlmon.dll", CharSet=CharSet.Unicode)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
    }
}

