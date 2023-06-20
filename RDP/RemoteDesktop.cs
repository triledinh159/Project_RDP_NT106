using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using AxMSTSCLib;
using RDPCOMAPILib;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Windows.Automation;
using Newtonsoft.Json;
using ZeroTier.Core;



namespace RDP
{
    public partial class RemoteDesktop : Form
    {
        public static RDPSession currentSession = null;


        private bool isChatFormOpened = false;
        private Chat chatForm1;

        public static void createSession()
        {
            currentSession = new RDPSession();
        }

        public static void Connect(RDPSession session)
        {
            session.OnAttendeeConnected += Incoming;
            session.Open();
        }

        public static void Disconnect(RDPSession session)
        {
            session.Close();
        }

        public static string getConnectionString(RDPSession session, String authString,
            string group, string password, int clientLimit)
        {
            IRDPSRAPIInvitation invitation =
                session.Invitations.CreateInvitation
                (authString, group, password, clientLimit);
            return invitation.ConnectionString;
        }

        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }

        public RemoteDesktop()
        {
            InitializeComponent();
        }

        private void RemoteDesktop_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            createSession();
            Connect(currentSession);
            var url = AuthResponse.GetAutenticationURI(clientId, redirectURI).ToString();
            Process.Start(url);
            Node node = new Node();

            node.InitFromStorage("./node_id");

            node.Start();

            if (!node.Online)
            {
                Thread.Sleep(1000);
            }

            node.Join(0x8056c2e21c4cdf4d);

            Thread.Sleep(10000);


            //ushort serverPort = (ushort)Int16.Parse("6000");
            //IPAddress ipAddress = IPAddress.Parse("172.24.42.42");
            //IPEndPoint localEndPoint = new IPEndPoint(ipAddress, serverPort);
            //txtClientID.Text = localEndPoint.ToString();
            //SocketServer(localEndPoint);
            DisplayMemoryUsageInTitleAsync();
            KeyGen.Text = getConnectionString(currentSession, "test", "group7", "", 5);
        }


        public void SocketServer(IPEndPoint localEndPoint)
        {
            string data = null;

            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            Console.WriteLine(localEndPoint.ToString());
            ZeroTier.Sockets.Socket listener =
                new ZeroTier.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and
            // listen for incoming connections.

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                ZeroTier.Sockets.Socket handler;

                //handler = listener.Accept();


                // Release the socket.

            }
            catch (ZeroTier.Sockets.SocketException e)
            {

            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnDisconnect.Enabled = true;
                new ScreenShare(txtKey.Text).Show();
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            Disconnect(currentSession);
        }

        private void txtClientIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYourIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdp_OnConnecting(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void KeyGen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_KeyGen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public const string clientId = "644284478790-73drkf0a0hlkdk29ta6l36jhhb2ts9em.apps.googleusercontent.com";
        public const string clientSecret = "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";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";
        public bool flag = true;

        public AuthResponse access;

        private void DisplayMemoryUsageInTitleAsync()
        {
            BackgroundWorker wrkr = new BackgroundWorker();
            wrkr.WorkerReportsProgress = true;

            wrkr.DoWork += (object sender, DoWorkEventArgs e) => {

                bool result;
                while (result = GetAppoveCodeGoogle())
                {
                    wrkr.ReportProgress(0, result);
                    Thread.Sleep(100);
                }

                wrkr.Dispose();
                Process[] procsChrome = Process.GetProcessesByName("chrome");
                foreach (Process chrome in procsChrome)
                {
                    if (chrome.MainWindowHandle == IntPtr.Zero)
                        continue;

                    AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                    if (element != null)
                    {
                        Condition conditions = new AndCondition(
                       new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                       new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                       new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                       new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                        AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                        var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                        if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                        {

                            ChromeWrapper chromes = new ChromeWrapper();
                            var arr = url.Split('&');
                            var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 2].Replace("approvalCode=", ""));
                            //((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).SetValue("https://tabbycats.club/cat/423c03");
                            chromes.SendKey((char)13, chrome);//enter
                            this.BeginInvoke(new Action(() =>
                            {
                                GetProfile(approvalCode);
                            }));
                            GetProfile(approvalCode);

                        }
                    }
                }
                wrkr.Dispose();
            };
            wrkr.RunWorkerAsync();
        }

        public bool GetAppoveCodeGoogle()
        {
            Process[] procsChrome = Process.GetProcessesByName("chrome");
            foreach (Process chrome in procsChrome)
            {
                if (chrome.MainWindowHandle == IntPtr.Zero)
                    continue;

                AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                if (element != null)
                {
                    Condition conditions = new AndCondition(
                   new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                   new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                   new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                   new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                    AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                    var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;

                    if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                    {
                        var arr = url.Split('&');
                        var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 2].Replace("approvalCode=", ""));
                        return false;
                    }

                }


            }
            return true;
        }

        private void GetProfile(string approveCode)
        {
            access = AuthResponse.Exchange(approveCode, clientId, clientSecret, redirectURI);

            //AccessToken.Text = access.Access_token;
            //refreshToken.Text = access.refresh_token;

            //if (DateTime.Now < access.created.AddHours(1))
            //{
            //    Expire.Text = access.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString();
            //}
            var url = $"https://www.googleapis.com/oauth2/v3/userinfo?access_token={access.Access_token}";

            var wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.AcceptCharset, "utf-8");
            wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; …) Gecko/20100101 Firefox/55.0");
            wc.Encoding = Encoding.UTF8;
            var jsonProfile = wc.DownloadString(url);
            //var frm = new FrmProfile(jsonProfile);
            // frm.Show();
            OnShown(jsonProfile);
            
        }
        //--------------------------


        public class Profile
        {
            public string sub { get; set; }
            public string name { get; set; }
            public string given_name { get; set; }
            public string family_name { get; set; }
            public string picture { get; set; }
            public string email { get; set; }
            public bool email_verified { get; set; }
            public string locale { get; set; }
        }


        public void OnShown(string jsonProfile)
        {
            var profile = JsonConvert.DeserializeObject<Profile>(jsonProfile);
            pic_Profile.LoadAsync(profile.picture);
            txt_firstname.Text = profile.family_name;
            txt_lastName.Text = profile.given_name;
            txt_email.Text = profile.email;
            txt_fullname.Text = profile.name;
            WindowHelper.BringProcessToFront(Process.GetCurrentProcess());
        }



        //-----------------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isChatFormOpened)
            {
                MessageBox.Show("ChatServer form is already open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chatForm1 = new Chat();
            chatForm1.FormClosed += ChatForm_FormClosed; // Đăng ký sự kiện FormClosed
            chatForm1.Show();
            isChatFormOpened = true;
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isChatFormOpened = false; // Đặt lại giá trị của biến khi form Chat đã đóng
        }

        private void pic_Profile_Click(object sender, EventArgs e)
        {

        }
    }
    public static class WindowHelper
    {
        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }

        const int SW_RESTORE = 9;

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
    }
}
