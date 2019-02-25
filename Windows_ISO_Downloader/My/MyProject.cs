namespace Windows_ISO_Downloader.My
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows_ISO_Downloader;

    [StandardModule, HideModuleName, GeneratedCode("MyTemplate", "11.0.0.0")]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [HelpKeyword("My.Application")]
        internal static MyApplication Application =>
            m_AppObjectProvider.GetInstance;

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer =>
            m_ComputerObjectProvider.GetInstance;

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms =>
            m_MyFormsObjectProvider.GetInstance;

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User =>
            m_UserObjectProvider.GetInstance;

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices =>
            m_MyWebServicesObjectProvider.GetInstance;

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Windows_ISO_Downloader.Form1 m_Form1;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Windows_ISO_Downloader.Form2 m_Form2;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Windows_ISO_Downloader.Form3 m_Form3;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Windows_ISO_Downloader.Form4 m_Form4;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Windows_ISO_Downloader.Form5 m_Form5;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                if ((Instance == null) || Instance.IsDisposed)
                {
                    TargetInvocationException exception;
                    if (m_FormBeingCreated != null)
                    {
                        if (m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                        }
                    }
                    else
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return Activator.CreateInstance<T>();
                    }
                    catch (TargetInvocationException exception1) when ((exception.InnerException > null))
                    {
                        ProjectData.SetProjectError(exception1);
                        string[] args = new string[] { exception.InnerException.Message };
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return Instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();

            public Windows_ISO_Downloader.Form1 Form1
            {
                get
                {
                    this.m_Form1 = Create__Instance__<Windows_ISO_Downloader.Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                set
                {
                    if (value != this.m_Form1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Windows_ISO_Downloader.Form1>(ref this.m_Form1);
                    }
                }
            }

            public Windows_ISO_Downloader.Form2 Form2
            {
                get
                {
                    this.m_Form2 = Create__Instance__<Windows_ISO_Downloader.Form2>(this.m_Form2);
                    return this.m_Form2;
                }
                set
                {
                    if (value != this.m_Form2)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Windows_ISO_Downloader.Form2>(ref this.m_Form2);
                    }
                }
            }

            public Windows_ISO_Downloader.Form3 Form3
            {
                get
                {
                    this.m_Form3 = Create__Instance__<Windows_ISO_Downloader.Form3>(this.m_Form3);
                    return this.m_Form3;
                }
                set
                {
                    if (value != this.m_Form3)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Windows_ISO_Downloader.Form3>(ref this.m_Form3);
                    }
                }
            }

            public Windows_ISO_Downloader.Form4 Form4
            {
                get
                {
                    this.m_Form4 = Create__Instance__<Windows_ISO_Downloader.Form4>(this.m_Form4);
                    return this.m_Form4;
                }
                set
                {
                    if (value != this.m_Form4)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Windows_ISO_Downloader.Form4>(ref this.m_Form4);
                    }
                }
            }

            public Windows_ISO_Downloader.Form5 Form5
            {
                get
                {
                    this.m_Form5 = Create__Instance__<Windows_ISO_Downloader.Form5>(this.m_Form5);
                    return this.m_Form5;
                }
                set
                {
                    if (value != this.m_Form5)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Windows_ISO_Downloader.Form5>(ref this.m_Form5);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            internal Type GetType() => 
                typeof(MyProject.MyWebServices);

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override string ToString() => 
                base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

