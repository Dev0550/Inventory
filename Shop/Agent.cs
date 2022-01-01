using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
namespace Inventory
{
    public partial class Agent : Form
    {
        private bool FlagIsTest;
     
        public Agent()
        {
            InitializeComponent();
          
        }

        private string CpuName(int Type)
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                if (Type == 1)
                {
                    id = mo["ProcessorId"].ToString();
                }

                else
                {
                    id = mo["Name"].ToString();
                }
            }
            return id;
        }
        public static string GetWorkGroup()
        {
            ManagementObject computer_system = new ManagementObject(
                        string.Format(
                        "Win32_ComputerSystem.Name='{0}'",
                        Environment.MachineName));

            object result = computer_system["Workgroup"];
            return result.ToString();
        }
        private double HDD()
        {
            string Inf = "";

            double totalhddsize = 0;
            foreach (DriveInfo info in DriveInfo.GetDrives())
            {
                if (info.IsReady && info.DriveType == DriveType.Fixed)
                {
                    totalhddsize += info.TotalSize;
                }
            }
            return ((totalhddsize / 1024) / 1024) / 1024;

      

        }
        private string HddDeviceId()
        {
            //Select item from drop down menu
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string drvnum = "";
            foreach (ManagementObject moDisk in mosDisks.Get())
            {
               
                 drvnum = moDisk["DeviceID"].ToString();

                cmbHdd.Items.Add(drvnum );
                
                break;
            }
            return drvnum;
        }
        private string HddModel()
        {
            //Select item from drop down menu
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string devid = "";
            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                 devid = moDisk["Model"].ToString();
                 break;
            }
            return devid;
        }
        private decimal HddSize(string HddDeviceId)
           {
               decimal Size=0;
               int f = HddDeviceId.Length - 3;
               string device = HddDeviceId.Substring(3, f);

               ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE DeviceID = '\\\\\\\\.\\" + device + "'");
               
                   foreach (ManagementObject moDisk in mosDisks.Get())
                   {
                   

                       if (!string.IsNullOrEmpty(moDisk["Size"].ToString()))
                       {
                          Size = Math.Round((Convert.ToDecimal(moDisk["Size"]) / 1073741824), 2);
                         
                       }
                   }
            
              

               return Size;
           }
        private string MotherBoard(int Type)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            foreach (ManagementObject mo in moc)
            {
                if (Type == 1)
                {
                    serial = (string)mo["SerialNumber"];
                }
                else
                {

                    serial = (string)mo["Manufacturer"];
                }
            }
            return serial;
        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
         
                foreach (NetworkInterface adapter in nics)
                {
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
             return sMacAddress;
        }
        private string MacAddress()
        {
            string MacAddress = "";
        //  ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
        //    ManagementObjectCollection collection = searcher.Get();
        //    //--
        //    //Iterate through results until the property 'MacAddress' is found.
        //    foreach (ManagementObject obj in collection)
        //    {
        //        if (obj.Properties["MacAddress"] != null)
        //        {

        //            MacAddress = obj.Properties["MacAddress"].Value.ToString();
        //        }
        //    }
        //

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    MacAddress += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return MacAddress;
        }
        public string VideoCard(int Type)
        {
            string Info="";
            ManagementObjectSearcher searcher =  new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject mo in searcher.Get())
            {
                if (Type == 2)
                {
                    //PropertyData currentBitsPerPixel = mo.Properties["CurrentBitsPerPixel"];
                    //PropertyData description = mo.Properties["Description"];
                    //if (currentBitsPerPixel != null && description != null)
                    //{
                    //    if (currentBitsPerPixel.Value != null)
                    //        Info = description.Value.ToString();
                    //}
                    Info = mo["Name"].ToString();
                    break;
                }
               if(Type==1)
                {
                    Info = mo["AdapterRAM"].ToString();
                    break;
                }
               if (Type == 3)
               {
                   Info = mo["DeviceID"].ToString();
                   break;   
               }
                
            }
            return Info;

        }
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
        static string GetComputerName()
        {
            return SystemInformation.ComputerName.ToString();
        }
        public string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
        static string OSName()
        {
            string OS = "" ;
            //OperatingSystem os = Environment.OSVersion;
            //OS = os.VersionString;

            WqlObjectQuery objectQuery = new WqlObjectQuery("select * from win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(objectQuery);

            string s, os;

            foreach (ManagementObject MO in searcher.Get())
            {

                s = MO["name"].ToString();

                string[] split1 = s.Split('|');

                OS = split1[0];

              

            }
            return OS;
        }
        private string Monitor(int Type)
         {
             ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
             ManagementObjectCollection moc = mos.Get();
             string serial = "";
             foreach (ManagementObject mo in moc)
             {
                 if (Type == 1)
                 {
                     serial = (string)mo["Name"];
                 }
                 else
                 {

                     serial = (string)mo["DeviceID"];
                 }
             }
             return serial;
         }

        private void Insert()
        {
            try
            {

                Model.Computer computer = new Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                Model.Hdd hdd = new Model.Hdd(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

                computer.CpuName = CpuName(2);
                computer.CpuId = CpuName(1);
                computer.MotherBoardName = MotherBoard(2);
                computer.MotherBoardId = MotherBoard(1);
                computer.Ram = ((GetTotalMemoryInBytes() / 1024) / 1024);
                computer.MacAddress = MacAddress();
                computer.Os = OSName();
                if (Environment.Is64BitOperatingSystem == true)
                {
                    computer.SystemType = (64).ToString() + "bit";
                }
                else
                {
                    computer.SystemType = (32).ToString() + "bit";
                }
                computer.CompName = GetComputerName();
                computer.Domain = Environment.UserDomainName;
                computer.UserName = Environment.UserName;
                computer.HddFullName = HddModel();
                computer.HddDeviceId = HddDeviceId();
                computer.HddSize = HddSize(HddDeviceId());
                computer.VideoCard = VideoCard(2);
                computer.VideoId = VideoCard(3);
                //if (VideoCard(1).Length > 0)
                //{

                //    computer.VideoSize = Math.Round(((Convert.ToDecimal(VideoCard(1)) / 1024) / 1024), 2);
                //}
                //else
                //{
                //    computer.VideoSize = 0;
                //}
                try
                {
                    computer.VideoSize = VideoCard(1);
                }
                catch
                {
                    computer.VideoSize = "0";
                }
                computer.Ip = LocalIPAddress();
                computer.Insert();
                


                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Agent_Load(object sender, EventArgs e)
        {

            //this.ShowInTaskbar = false;
            Insert();
            //Start
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

            Ram.Text = ((GetTotalMemoryInBytes() / 1024) / 1024).ToString();
            txt_cpuName.Text = CpuName(2);
            CpuId.Text = CpuName(1);
            MotherBoardName.Text = MotherBoard(2);
            MotherBoardId.Text = MotherBoard(1);
            //HddName.Text = Math.Round(HDD(), 0).ToString() + " GB";

            CompName.Text = GetComputerName();
            OS.Text = OSName();
            if (Environment.Is64BitOperatingSystem == true)
            {
                OSType.Text = (64).ToString() + "bit";
            }
            else
            {
                OSType.Text = (32).ToString() + "bit";
            }
            textBox11.Text = Environment.UserName;
            textBox9.Text = LocalIPAddress();
            MonitorId.Text = Monitor(2);
            MonitorName.Text = Monitor(1);
            video.Text = VideoCard(2);
            VideoSize.Text = ((Convert.ToDecimal(VideoCard(1)) / 1024) / 1024).ToString();
            videoId.Text = VideoCard(3);
            macadress.Text = MacAddress();
            Domain.Text = Environment.UserDomainName;
            //HddName.Text = HDDNAme();
            if (FlagIsTest == true)
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send("192.168.1.42");

                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show("Статуси пайвастшави бо базаи маълумот: Бо муваффақият.");
                }
                else
                {
                    MessageBox.Show("Статуси пайвастшави бо базаи маълумот: Иштибоҳ рух дод.");
                }
            }
            //End

                //this.Close();
        }

        private void cmbHdd_SelectedIndexChanged(object sender, EventArgs e)
        {

            int f = cmbHdd.SelectedItem.ToString().Length - 3;
            int i = cmbHdd.SelectedItem.ToString().IndexOf(':');
            string device = cmbHdd.SelectedItem.ToString().Substring(3,f );
            
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE DeviceID = '\\\\\\\\.\\" + device + "'");
            try
            {
                foreach (ManagementObject moDisk in mosDisks.Get())
                {
                    //HddName.Text = moDisk["Availability"].ToString();

                    if (!string.IsNullOrEmpty(moDisk["Size"].ToString()))
                    {
                        hddSize.Text = Math.Round((Convert.ToDecimal(moDisk["Size"]) / 1073741824), 2).ToString() + "GB";
                        HddName.Text = moDisk["Model"].ToString();
                    }
                }
            }
            catch {
                hddSize.Text = "Unknown";
                HddName.Text = "Unknown";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
