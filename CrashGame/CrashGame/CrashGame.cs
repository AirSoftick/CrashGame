using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashGame
{
    public partial class CrashGame : Form
    {
        private bool isProcessRunning = false;
        private Thread processThread;
        public string pth = null;

        #region DLLs
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);


        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        #endregion

        public CrashGame()
        {
            InitializeComponent();

            try
            {
                string settingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "CrashGame", "settings.txt");
                if (File.Exists(settingsFilePath))
                {
                    string[] lines = File.ReadAllLines(settingsFilePath);
                    if (lines.Length > 0)
                    {
                        pth = lines[0];
                        buttonKeyBind.Text = pth;
                    }
                }
                else
                {
                    MessageBox.Show("Error: File not found", "Ooops");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error: File read error", "Ooops");
                this.Close();
            }
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static KeysConverter keyConverter = new KeysConverter();


        private void bttStartProcess_Click(object sender, EventArgs e)
        {
            if (!isProcessRunning)
            {
                StartProcess();
            }
            else
            {
                StopProcess();
            }
        }

        private void StartProcess()
        {
            bttStartProcess.Text = "STOP";
            buttonKeyBind.Enabled = false;

            processThread = new Thread(ProcessLoop);
            processThread.Start();

            isProcessRunning = true;
        }

        private void StopProcess()
        {
            if (processThread != null && processThread.IsAlive)
            {
                processThread.Abort();
            }

            bttStartProcess.Text = "START";
            buttonKeyBind.Enabled = true;

            isProcessRunning = false;
        }

        private void ProcessLoop()
        {
            while (true)
            {
                if (bttStartProcess.Text != "<Key>")
                {
                    try
                    {
                        Keys key = (Keys)keyConverter.ConvertFromString(buttonKeyBind.Text);

                        if (GetAsyncKeyState(key) < 0)
                        {
                            try
                            {
                                Process[] gameProcesses = Process.GetProcessesByName(txt.Text);
                                if (gameProcesses.Length > 0)
                                {
                                    string command = @"taskkill /IM " + txt.Text + ".exe /F";
                                    var startInfo = new ProcessStartInfo();
                                    startInfo.FileName = "cmd";
                                    startInfo.Arguments = "/c " + command;
                                    startInfo.Verb = "runas";
                                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                    var proc = Process.Start(startInfo);

                                    bttStartProcess.Text = "START";
                                    buttonKeyBind.Enabled = true;

                                    isProcessRunning = false;

                                    if (toggleCloseForCrash.Checked)
                                    {
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            this.Close();
                                        });
                                    }
                                }
                                else{}
                            }
                            catch{}

                            break;

                            if (toggleCloseForCrash.Checked)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    this.Close();
                                });
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                }

                if (!isProcessRunning)
                {
                    break;
                }
            }
        }


        private void toggleActiveTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = toggleActiveTopMost.Checked;
        }

        private void buttonKeyBind_Click(object sender, EventArgs e)
        {
            buttonKeyBind.Text = "<Key>";
        }

        private void RenameKey(string text, string replaceText)
        {
            if (buttonKeyBind.Text == text)
            {
                buttonKeyBind.Text = replaceText;
            }
        }

        private void buttonKeyBind_KeyUp(object sender, KeyEventArgs e)
        {
            if (buttonKeyBind.Text == "<Key>")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    buttonKeyBind.Text = "ClickBind";
                }
                else
                {
                    buttonKeyBind.Text = e.KeyCode.ToString();
                }

                try
                {
                    RenameKey("D0", "0");
                    RenameKey("D1", "1");
                    RenameKey("D2", "2");
                    RenameKey("D3", "3");
                    RenameKey("D4", "4");
                    RenameKey("D5", "5");
                    RenameKey("D6", "6");
                    RenameKey("D7", "7");
                    RenameKey("D8", "8");
                    RenameKey("D9", "9");
                    RenameKey("ShiftKey", "Shift");
                    RenameKey("Menu", "Alt");
                    RenameKey("Back", "Delete");
                    RenameKey("Oem5", @"\");
                    RenameKey("Return", "Enter");
                    RenameKey("Capital", "CapsLock");
                    RenameKey("ControlKey", "Ctrl");
                    RenameKey("OemQuestion", "/");
                    RenameKey("Oemplus", "+");
                    RenameKey("OemMinus", "-");
                    RenameKey("OemOpenBrackets", "[");
                    RenameKey("Oem6", "]");
                    RenameKey("Oem1", "*no bind key *");
                    RenameKey("Oem7", "'");
                    RenameKey("Oemcomma", ",");
                    RenameKey("OemPeriod", ".");
                }
                catch{}

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "CrashGame", "settings.txt");
                string st = buttonKeyBind.Text;

                using (FileStream fileStream = File.Open(filePath, FileMode.Create))
                {
                    using (StreamWriter output = new StreamWriter(fileStream))
                    {
                        output.Write(st);
                    }
                }
            }
        }
    }
}
