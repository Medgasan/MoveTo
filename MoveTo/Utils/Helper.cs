using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MoveTo.Utils
{
    internal class Helper
    {
        private const string SOFTWAREKEY = @"SOFTWARE\MoveTo";
        private const string SHELLCONTEXTKEY = @"SOFTWARE\Classes\Directory\shell\Move To...";
        public const string SOFTLINK = "SoftLink";
        public const string CREATECONTEXT = "ShellContext";
        public const string ADDNAME = "AddFolderName";
        public static Dictionary<string, object> config = new Dictionary<string, object>();


        [DllImport("shell32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsUserAnAdmin();


        public enum SymbolicLink
        {
            File = 0x0,
            Directory = 0x1
        }

        [DllImport("kernel32.dll")]
        public static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);


        public static void RunAsAdmin(string commandline)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.Arguments = "\"" + commandline + "\"";
            proc.FileName = Application.ExecutablePath;
            proc.Verb = "runas";
            try
            {
                Process.Start(proc);
            }
            catch
            {
                return;
            }
        }

        public static void AddToContextMenu()
        {
            /*
                [HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\Move To...]
                "Icon"="\"C:\\Users\\franm\\source\\repos\\MoveTo\\MoveTo\\bin\\Debug\\MoveTo.exe\""
                [HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\Move To...\command]
                @="\"C:\\Users\\franm\\source\\repos\\MoveTo\\MoveTo\\bin\\Debug\\MoveTo.exe\" \"%V\""             
             */

            Registry.SetValue("HKEY_CURRENT_USER\\" + SHELLCONTEXTKEY, "Icon", Environment.CurrentDirectory + "\\MoveTo.exe ,0", RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_CURRENT_USER\\" + SHELLCONTEXTKEY + "\\command", "", Application.ExecutablePath + " \"%V\"", RegistryValueKind.ExpandString);

        }

        public static void DelToContextMenu()
        {
            Registry.CurrentUser.DeleteSubKeyTree(SHELLCONTEXTKEY, false);
        }

        public static void SaveConfig()
        {
            Registry.SetValue(
                "HKEY_CURRENT_USER\\" + SOFTWAREKEY, ADDNAME, config[ADDNAME].ToString(), RegistryValueKind.String);
            Registry.SetValue(
                "HKEY_CURRENT_USER\\" + SOFTWAREKEY, CREATECONTEXT, config[CREATECONTEXT].ToString(), RegistryValueKind.String);
            Registry.SetValue(
                "HKEY_CURRENT_USER\\" + SOFTWAREKEY, SOFTLINK, config[SOFTLINK].ToString(), RegistryValueKind.String);
        }

        public static void LoadConfig()
        {
            config.Clear();
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(SOFTWAREKEY);
            config.Add(ADDNAME, bool.Parse(registryKey.GetValue(ADDNAME, "true").ToString()));
            config.Add(CREATECONTEXT, bool.Parse(registryKey.GetValue(CREATECONTEXT, "true").ToString()));
            config.Add(SOFTLINK, bool.Parse(registryKey.GetValue(SOFTLINK, "true").ToString()));
        }

    }
}
