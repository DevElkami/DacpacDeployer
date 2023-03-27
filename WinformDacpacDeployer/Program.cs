using DacpacDeployerCore;
using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using ReaLTaiizor.Manager;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WinformDacpacDeployer;

static class Program
{
    /// <summary>
    /// Main point entry
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            String directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "DevElkami", nameof(DacpacDeployerCore));
            FileTarget logfile = new("logfile")
            {
                FileName = Path.Combine(directory, "log.txt"),
                CreateDirs = true
            };

            logfile.Layout = Layout.FromString("${longdate}|${event-properties:item=EventId_Id}|${uppercase:${level}}|${logger}|${message} ${exception:format=tostring}");
            LoggingConfiguration config = new();
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile, "*");
            LogManager.Configuration = config;
        }
        catch (Exception except)
        {
            Debug.WriteLine(except.ToString());
            // No log, don't care
        }

        try
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);

            // Quick translate
            CultureInfo culture = new CultureInfo("en");
#if DEBUG                
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
#else
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag != "fr-FR")
            {
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
#endif
            // Theme                                
            MaterialSkinManager.Instance.EnforceBackcolorOnAllComponents = true;
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;

            // Run app
            DeployerCore deployerCore = new DeployerCore();
            Application.Run(new MainForm(ref deployerCore));
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
        }
    }
}
