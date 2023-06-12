using RDPCOMAPILib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxRDPCOMAPILib;

namespace RDP
{
    public partial class ScreenShare : Form
    {
        string keyDetail;
        public ScreenShare(string Key)
        {
            keyDetail = Key;
            InitializeComponent();
        }

        public static void Connect(string invitation, AxRDPViewer display, string userName, string password)
        {
            display.Connect(invitation, userName, password);
        }

        public static void disconnect(AxRDPViewer display)
        {
            display.Disconnect();
        }

        private void ScreenShare_Load(object sender, EventArgs e)
        {
            try
            {
                Connect(keyDetail, this.axRDPViewer, "", "");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the Server");
            }
        }


        private void axRDPViewer_Enter(object sender, EventArgs e)
        {

        }
    }
}
