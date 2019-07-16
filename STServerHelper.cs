using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using Mono.Nat;
using System.Configuration;
using Telerik.WinControls.UI;
using System.Threading;

namespace ST
{
    public partial class STServerHelper : Telerik.WinControls.UI.RadForm
    {

        //TODO
        //Implement UPNP and assign it to the game server executable so then you can port forward temporarily for the user if their router supports it.
        //update thing - https://updates.skyrim-together.com/hashes_489830.txt line.split(' ')[0] if(line.contains("server.exe")).

        private bool isStarted = false;

        string ServerDirectory = ConfigurationManager.AppSettings["Server Directory"];

        BinaryHelper.BinaryStorageHelper Storage = new BinaryHelper.BinaryStorageHelper();

        public STServerHelper()
        {
            InitializeComponent();
            this.FormElement.TitleBar.ForeColor = System.Drawing.Color.White;
            this.FormClosed += StopBtn_Click;
            Test();
        }

        private void Test()
        {
            LocalStorage localStorage = new LocalStorage()
            {
                Signature = "f3efaf848f2d9f78b567cac334d4a4a5cf3df2c090b22c839468ee757f88bca1"
            };

            //Storage.WriteToBinaryFile(localStorage, true);
        }

        public void STServerHelper_Load(object sender, EventArgs e)
        {
            //NatCheck();
            if (isStarted == false) { stopBtn.Enabled = false; }

        }

        public void NatCheck()
        {          
            //NatUtility.DeviceFound += DeviceLost;
            NatUtility.DeviceFound += DeviceFound;
            NatUtility.StartDiscovery();
        }

        private void DeviceFound(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;

            PublicIP.Invoke(new Action(() => PublicIP.Text = device.GetExternalIP().ToString()));

            if (isStarted == true)
            {

                if (portEnabled.Value == true)
                {
                    device.GetSpecificMapping(Protocol.Tcp, Convert.ToInt32(portTxt.Text));

                    device.CreatePortMap(new Mapping(Protocol.Tcp, Convert.ToInt32(portTxt.Text), Convert.ToInt32(portTxt.Text)));

                }
                else
                {
                    device.GetSpecificMapping(Protocol.Tcp, 10578);

                    device.CreatePortMap(new Mapping(Protocol.Tcp, 10578, 10578));
                }

            }
            
        }

        private void DeviceLost(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;

            MessageBox.Show("Nat device lost!");

            if (portEnabled.Value == true)
            {
                device.DeletePortMap(new Mapping(Protocol.Tcp, Convert.ToInt32(portTxt.Text), Convert.ToInt32(portTxt.Text)));
            }
            else
            {
                device.DeletePortMap(new Mapping(Protocol.Tcp, 10578, 10578));
            }

        }

        private void ShowMappedPorts(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;

            foreach (Mapping portMap in device.GetAllMappings())
            {
                MessageBox.Show(portMap.ToString());
            }

        }

        private Dictionary<RadToggleSwitch, string> GetRelationships(STServerHelper st)
        {
            return new Dictionary<RadToggleSwitch, string>
            {
                { st.tokenEnabled, "-token " + st.txtToken.Text },
                { st.portEnabled, "-port " + st.portTxt.Text },
                { st.premiumEnabled, st.premiumEnabled.Value ? "-premium" : string.Empty}

            };
        }

        public void StartBtn_Click(object sender, EventArgs e)
        {
            string args = string.Empty;

            foreach(var data in GetRelationships(this))
            {
                if (data.Key.Value)
                {
                    args += data.Value + " ";
                }
            }

            Process process = new Process();
            process.StartInfo.FileName = ServerDirectory + "\\Server.exe";
            process.StartInfo.Arguments = args;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.OutputDataReceived += OutputReceived;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.BeginOutputReadLine();
            var pid = process.Id;
            ID = pid;
            isStarted = true;
            stopBtn.Enabled = true;
            startBtn.Enabled = false;
        }

        private void OutputReceived(object sender, DataReceivedEventArgs e)
        {
            consoleBox.Invoke(new Action(() => consoleBox.Text += e.Data + "\r\n"));
        }

        public int ID { get; set; }

        public void StopBtn_Click(object sender, EventArgs e)
        {
            if(isStarted == false) { return; }
            try
            {
                Process processByID = Process.GetProcessById(ID);
                Process process = processByID;
                process.Kill();
                isStarted = false;
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                consoleBox.AppendText("\r\n-------- Server Stopped ---------\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(restartEnabled.Value == true)
            {
                StartBtn_Click(sender, e);
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LocalIP.Text);
        }

        private void Copy2Btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PublicIP.Text);
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo( ServerDirectory + "\\logs");
            var myFile = directory.GetFiles()
                         .OrderByDescending(f => f.LastWriteTime)
                         .First();
            Process.Start(myFile.FullName);

        }

        private void PortBtn_Click(object sender, EventArgs e)
        {

            NatCheck();

        }

        private void LogsFolderBtn_Click(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(ServerDirectory + "\\logs");
            var myFile = directory.GetFiles()
                         .OrderByDescending(f => f.LastWriteTime)
                         .First();
            Process.Start(myFile.DirectoryName);
        }

        private void TxtToken_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToken.Text))
            {
                tokenEnabled.Value = true;
            }
            else
            {
                tokenEnabled.Value = false;
            }
        }

        private void PortTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(portTxt.Text))
            {
                portEnabled.Value = true;
            }
            else
            {
                portEnabled.Value = false;
            }
        }

        private void UpdatesBtn_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            using (var stream = client.OpenRead("https://updates.skyrim-together.com/hashes_489830.txt"))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("Server.exe"))
                    {
                        string serverSignature = line.Split(' ')[0];
                        MessageBox.Show(serverSignature);
                    }
                }
            }


        }

    }
}
