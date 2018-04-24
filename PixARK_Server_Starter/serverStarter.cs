using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixARK_Server_Starter
{
    public partial class serverStarter : Form
    {
        string InstallPath = Properties.Settings.Default.ServerInstallPath;
        string PyArkRconPath = Properties.Settings.Default.pyArkRconInstallPath;
        private bool downloadComplete = false;
        public serverStarter()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            Properties.Settings.Default.Upgrade();
            label2.Text= Properties.Settings.Default.ServerInstallPath;
            gameUserSettingsBox.Text = Properties.Settings.Default.GUS; //populates GUS.ini tab
            //Has user select server and pyARKRcon install location on first run
            if (InstallPath.Equals(""))
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.Description = "Select PixARK Server Install Location";
                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    InstallPath = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.ServerInstallPath = InstallPath.ToString();
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Upgrade();
                }
            }
            if (PyArkRconPath.Equals(""))
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.Description = "Select Rcon Install Location (Required to for this application to function)";
                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    PyArkRconPath = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.pyArkRconInstallPath = PyArkRconPath.ToString();
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Upgrade();
                }
            }
            serverPassEnabled.Checked = Properties.Settings.Default.isServerPasswordProtected;
            gamePort.Value = Properties.Settings.Default.gamePort_S;
            queryPort.Value = Properties.Settings.Default.queryPort_S;
            rconPort.Value = Properties.Settings.Default.rconPort_S;
            cubePort.Value = Properties.Settings.Default.cubePort_S;
            adminPass.Text = Properties.Settings.Default.adminPassword_S;
            serverNameTxt.Text = Properties.Settings.Default.serverName_S;
            serverPasswordTxt.Visible = serverPassEnabled.Checked;
            if(serverPassEnabled.Checked)
            {
                serverPasswordTxt.Text = Properties.Settings.Default.serverPassword_S;
            }
        }

        private void serverInstallLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select PixARK Server Install Location";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                InstallPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.ServerInstallPath = InstallPath.ToString();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void tESTPrintInstallPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(InstallPath);
        }

        private void installServerButton_Click(object sender, EventArgs e)
        {
            //"start \"\" steamcmd/steamcmd.exe +login username password +force_install_dir" +"\""+InstallPath+"\""+ "+app_update 824360 validate +quit"
            string updateBat = @"" + InstallPath + "\\update.bat";

            //downloads SteamCMD
            if (!Directory.Exists(InstallPath + "\\steamcmd"))
            {
                WebClient webClient = new WebClient();  // Creates a webclient
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);// Uses the Event Handler to check whether the download is complete
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);  // Uses the Event Handler to check for progress made
                webClient.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"), @"" + InstallPath + "\\steamcmd.zip");
                while (!downloadComplete)
                {
                    Application.DoEvents();
                }
                downloadComplete = false;
                System.IO.Compression.ZipFile.ExtractToDirectory(InstallPath + "\\steamcmd.zip", InstallPath + "\\steamcmd");
                File.Delete(InstallPath + "\\steamcmd.zip");
            }

            //Downloads pyARKRcon
            if (!Directory.Exists(PyArkRconPath + "\\pyARKon"))
            {
                WebClient webClient = new WebClient();  // Creates a webclient
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);// Uses the Event Handler to check whether the download is complete
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);  // Uses the Event Handler to check for progress made
                webClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/nuthing/pyARKon/master/dist/pyARKon-v1.7.2-win32.zip"), @"" + PyArkRconPath + "\\pyARKon-v1.7.2-win32.zip");
                while (!downloadComplete)
                {
                    Application.DoEvents();
                }
                downloadComplete = false;
                System.IO.Compression.ZipFile.ExtractToDirectory(PyArkRconPath + "\\pyARKon-v1.7.2-win32.zip", PyArkRconPath + "\\pyARKon");
                File.Delete(PyArkRconPath + "\\pyARKon-v1.7.2-win32.zip");
            }

            //Creates the Server Update bat
            try
            {
                // Check if file already exists. If yes, delete it. 
                if (File.Exists(updateBat))
                {
                    File.Delete(updateBat);
                }

                // Create a new file 
                using (StreamWriter sw = File.CreateText(updateBat))
                {
                    // Creates then install bat
                    sw.WriteLine("start \"\" " +InstallPath+"\\steamcmd\\steamcmd.exe +login anonymous anonymous +force_install_dir " + "\"" + InstallPath + "\"" + " +app_update 824360 validate +quit");
                }
            }
            catch (Exception Ex)
            {
               // Console.WriteLine(Ex.ToString());
            }
            //Installs the server
            ExecuteCommand(InstallPath+"\\update.bat");

            //Generates a fresh GUS.ini file and installs it to the server!
            if (File.Exists(@""+InstallPath+"\\ShooterGame\\Saved\\Config\\WindowsServer\\GameUserSettings.ini"))
            {
                //do nothing
            }
            else
            {
                File.Copy(@"freshGUS.txt", @"" + InstallPath + "\\ShooterGame\\Saved\\Config\\WindowsServer\\GameUserSettings.ini");
            }
            
            string gusText = System.IO.File.ReadAllText(@"" + InstallPath + "\\ShooterGame\\Saved\\Config\\WindowsServer\\GameUserSettings.ini");
            gameUserSettingsBox.Text = gusText;
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // No changes in this method...
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                downloadComplete = true;
            });
        }

        //Excutes Cmd process
        static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

        static void StartServerCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

           // process.WaitForExit();

            //Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

        static void StopServerCommand(string command)
        {
            var processInfo = new ProcessStartInfo("powershell.exe", "/c " + command);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

        private void serverPassEnabled_CheckedChanged(object sender, EventArgs e)
        {
            serverPasswordTxt.Visible = serverPassEnabled.Checked;
            Properties.Settings.Default.isServerPasswordProtected = serverPassEnabled.Checked;
            Properties.Settings.Default.Save();
            if (serverPassEnabled.Visible)
            {
                serverPasswordTxt.Text = Properties.Settings.Default.serverPassword_S;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage3")//your specific tabname
            {
                MessageBox.Show(this,"Only Use this tab to edit the GameUserSettings.ini if you know what you are doing!");
            }

        }
        
        private string getIP()
        {
            // Old Code, gets internal IP
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
          //  string localIP = new WebClient().DownloadString("http://icanhazip.com");
            return localIP.TrimEnd('\n');


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ExecuteCommand(InstallPath + "\\update.bat");
        }

        private void serverPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.serverPassword_S = serverPasswordTxt.Text;
            Properties.Settings.Default.Save();
        }

        private void adminPass_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.adminPassword_S = adminPass.Text;
            Properties.Settings.Default.Save();
        }

        private void serverNameTxt_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.serverName_S = serverNameTxt.Text;
            Properties.Settings.Default.Save();
        }

        private void launchServerButton_Click(object sender, EventArgs e)
        {
            //Check ports
            //Check Game Port
            decimal gamePortValue = gamePort.Value;
            decimal queryPortValue = queryPort.Value;
            decimal rconPortValue = rconPort.Value;
            decimal cubePortValue = cubePort.Value;
            bool gamePortCheck = false; // false = game port equals another port. true = game port doesn't match other ports
            bool queryPortCheck = false;
            bool rconPortCheck = false;
            bool cubePortCheck = false;

            if(gamePortValue.Equals(queryPortValue)!= true && gamePortValue.Equals(rconPortValue) != true && gamePortValue.Equals(cubePortValue) != true)
            {
                gamePortCheck = true;
            }
            if(queryPortValue.Equals(gamePortValue) != true && queryPortValue.Equals(rconPortValue) != true && queryPortValue.Equals(cubePortValue) != true)
            {
                queryPortCheck = true;
            }
            if (rconPortValue.Equals(gamePortValue) != true && rconPortValue.Equals(queryPortValue) != true && rconPortValue.Equals(cubePortValue) != true)
            {
                rconPortCheck = true;
            }
            if (cubePortValue.Equals(gamePortValue) != true && cubePortValue.Equals(queryPortValue) != true && cubePortValue.Equals(rconPortValue) != true)
            {
                cubePortCheck = true;
            }

            //If all ports are seperate we will being the server launch process!
            //Default launch bat = start "" /NORMAL "C:\pixarkserver\ShooterGame\Binaries\Win64\PixARKServer.exe" "CubeWorld_Light?listen?MaxPlayers=YOURMAXPLAYERS?Port=27015?QueryPort=27016?RCONPort=27017?SessionName=YOURHOSTNAME?ServerAdminPassword=YOURADMINPASSWORD?CULTUREFORCOOKING=en" -NoBattlEye -NoHangDetection -CubePort=27018 -cubeworld=YOURWORLDNAME -Seed=YOURRANDOMSEED -nosteamclient -game -server -log
            if (gamePortCheck && queryPortCheck && rconPortCheck && cubePortCheck)
            {
                //generate rcon settings file
                string rconSettings = @"" + PyArkRconPath + "\\pyARKon\\settings.cfg";
                if(File.Exists(rconSettings))
                {
                    File.Delete(rconSettings);
                }

                using (StreamWriter sw1 = File.CreateText(rconSettings))
                {
                    sw1.Write("[pyARKon]\nhost = " + getIP() + "\nport = " + rconPortValue + "\npass = " + adminPass.Text + "\ntimeout = 15\nsleep = 3\ndebug = False\nogs = false\nlogs = False");
                }

                string launchBat = @"" + InstallPath + "\\launch.bat";
                // Check if file already exists. If yes, delete it. 
                if (File.Exists(launchBat))
                {
                    File.Delete(launchBat);
                }

                // Create a new file 
                using (StreamWriter sw = File.CreateText(launchBat))
                {
                    // Creates then install bat
                    sw.WriteLine("start \"\" /NORMAL " +"\"" + InstallPath +"\\ShooterGame\\Binaries\\Win64\\PixARKServer.exe\" \"CubeWorld_Light?listen?MaxPlayers=10?Port="+gamePortValue+"?QueryPort="+queryPortValue+ "?RCONEnabled=True?RCONPort=" + rconPortValue+"?SessionName="+serverNameTxt.Text+"?ServerAdminPassword="+adminPass.Text+"?CULTUREFORCOOKING=en\" "+ "-NoBattlEye -NoHangDetection -CubePort="+cubePortValue+" -cubeworld="+serverNameTxt.Text +" -Seed=2018 -nosteamclient -game -server -log" );
                }
                StartServerCommand(launchBat);
                // MessageBox.Show(this, "All ports are different!");
            }
            else
            {
                MessageBox.Show(this, "Please check to make sure all the ports are different values!","Incorrect Port Values!");
            }
        }

        private void stopServerButton_Click(object sender, EventArgs e)
        {
            string rconSettings = @"" + PyArkRconPath + "\\pyARKon\\settings.cfg";
            if (File.Exists(rconSettings))
            {
                File.Delete(rconSettings);
            }

            using (StreamWriter sw1 = File.CreateText(rconSettings))
            {
                sw1.Write("[pyARKon]\nhost = " + getIP() + "\nport = " + rconPort.Value + "\npass = " + adminPass.Text + "\ntimeout = 15\nsleep = 3\ndebug = False\nogs = false\nlogs = False");
            }
            string saveServer = PyArkRconPath + "\\pyARKon\\pyARKon.exe \"saveworld\"";
            string stopServer = PyArkRconPath + "\\pyARKon\\pyARKon.exe \"doexit\"";
            StopServerCommand(saveServer);
            StopServerCommand(stopServer);
        }
    }
}
