using Renci.SshNet;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RemoteConnectionToLinux
{
    public partial class MainWindow : Form, IDisposable
    {
        private string ARESTECH_IPC_IP;
        private string ARESTECH_IPC_USER;
        private string ARESTECH_IPC_PWD;
        private string AMRFLEET_IP;
        private string AMRFLEET_USER;
        private string AMRFLEET_PWD;

        public MainWindow()
        {

            #region Singleton 
            if (Program.Instance != null)
            {
                Trace.TraceError(string.Format("App is singleton use only 1 Instance"));
                Program.Instance.Close();
            }
            Program.Instance = this;
            #endregion


        }
        public static string? DetailedTraceInfo { get; set; }

        private void Instance_Shown(object? sender, EventArgs e)
        {
            this.SetDesktopLocation(Top, Left);
            this.Visible = true;
            this.BringToFront();
            this.PerformAutoScale();
            this.PerformLayout();
            this.Show();

        }

        public void btConnnect_Click(object sender, EventArgs e)
        {
            ColllectInfos();
            //Connect to the ArestechIPC
            using (var client = new SshClient(ARESTECH_IPC_IP,22,ARESTECH_IPC_USER, ARESTECH_IPC_USER))
            {
                try
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        Console.WriteLine("Connected to the ArestechIPC.");

                        DownloadFileFromRemote(client, ARESTECH_IPC_IP, ARESTECH_IPC_USER, ARESTECH_IPC_PWD, remoteFolderPath_ArestechIPC);

                    }
                    else
                        Trace.TraceError("Client is not connected!");

                }
                catch (Exception ex)
                {
                    Trace.TraceError(string.Format("Exception:\r\nMessage: {0}\r\nInnerException: {1}", ex.Message, ex.InnerException));
                }
                finally
                {
                    client.Disconnect();
                }

            }
            using (var client = new SshClient(AMRFLEET_IP, 22, AMRFLEET_USER, AMRFLEET_PWD))
            {
                try
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        Console.WriteLine("Connected to the Fleetmanager server: AMR.Fleet");

                        DownloadFileFromRemote(client, AMRFLEET_IP, AMRFLEET_USER, AMRFLEET_PWD,remoteFolderPath_AMRFleet);

                    }
                    else
                        Trace.TraceError("Client is not connected!");

                }
                catch (Exception ex)
                {
                    Trace.TraceError(string.Format("Exception:\r\nMessage: {0}\r\nInnerException: {1}", ex.Message, ex.InnerException));
                }
                finally
                {
                    client.Disconnect();
                }

            }
        }
        public string remoteFolderPath_AMRFleet= "/opt/server/logs/";
        public string remoteFolderPath_ArestechIPC = "/opt/robot/logs/";
        public string localFolderPath = @"d:\downWithHelper\";
        public void DownloadFileFromRemote(SshClient client_in,string ip, string user, string pwd,string remoteFolderPath_in)
        {
            // Create the ScpClient
            using (SftpClient sftp_client = new SftpClient(ip, user, pwd)) 
            {
                try
                {
                    sftp_client.Connect();

                    // Get a list of files in the remote folder
                    var remoteFiles = sftp_client.ListDirectory(remoteFolderPath_in);

                    // Create the local folder if it doesn't exist
                    if (!Directory.Exists(localFolderPath))
                    {
                        Directory.CreateDirectory(localFolderPath);
                    }

                    // Copy each file
                    foreach (var file in remoteFiles)
                    {
                        if (!file.IsDirectory && !file.Name.StartsWith(".")) // Ignore directories and hidden files
                        {
                            string remoteFilePath = Path.Combine(remoteFolderPath_in, file.Name);
                            string localFilePath = Path.Combine(localFolderPath, file.Name);

                            using (var inputFile = sftp_client.OpenRead(remoteFilePath))
                            using (var outputFile = File.Create(localFilePath))
                            {
                                inputFile.CopyTo(outputFile);
                            }

                            Console.WriteLine($"Copied: {remoteFilePath} to {localFilePath}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Trace.TraceError("Exception during copying logs from robot or fleetserver to host\r\nMessage:{0}\r\n{1}", ex.Message, ex.InnerException);
                    sftp_client.Disconnect();
                }finally
                { sftp_client.Disconnect(); }
            }

        }
        private void btCheckRemoteIP_Click(object sender, EventArgs e)
        {
            ColllectInfos();

        }

        public Dictionary<string, string> RequiredInformations = new Dictionary<string, string>();
        public void ColllectInfos()
        {

            if (CheckIfIPIsValid(tbArestechIPC_.Text))
                ARESTECH_IPC_IP = tbArestechIPC_.Text;

            ARESTECH_IPC_USER = tbArestechUser.Text;
            ARESTECH_IPC_PWD = tbArestechPassword.Text;
            if (CheckIfIPIsValid(tbAMRFleetIP.Text))
                AMRFLEET_IP = tbAMRFleetIP.Text;
            AMRFLEET_USER = tbFleetUser.Text;
            AMRFLEET_PWD = tbFleetPassword.Text;
        }

        private bool CheckIfIPIsValid(string ipAddress_in)
        {
            var IpRegEx = @"^(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])$";
            if (Regex.IsMatch(ipAddress_in, IpRegEx))
            {
                return true;
            }
            else
                return false;
        }
    }
}
