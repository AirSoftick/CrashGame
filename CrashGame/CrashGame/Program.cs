using System;
using System.IO;
using System.Windows.Forms;

namespace CrashGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            InitializeSettings();

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CrashGame());
            }
            catch { }
        }

        private static void InitializeSettings()
        {
            string settingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "CrashGame", "settings.txt");

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(settingsFilePath));
                if (!File.Exists(settingsFilePath))
                {
                    using (StreamWriter output = File.CreateText(settingsFilePath))
                    {
                        output.Write("Bind");
                    }
                }
            }
            catch { }
        }
    }
}
