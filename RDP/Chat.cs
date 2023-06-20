using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTextMessage();
        }
        private void txtInput_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn không cho ký tự Enter được hiển thị trong TextBox
                DisplayTextMessage(); // Gửi tin nhắn khi nhấn phím Enter
            }
        }

        private void DisplayTextMessage()
        {
            string text = txtInput.Text;
            text = text + "\n";
            txtMessenger.Items.Add(text);
            txtInput.Clear();
        }

    }
}
