using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForm_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string x = "0000";
        private void B2_Click(object sender, EventArgs e)
        {
            passkey.Text += 2;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            passkey.Text += 1;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            passkey.Text += 3;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            passkey.Text += 4;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            passkey.Text += 5;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            passkey.Text += 6;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            passkey.Text += 7;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            passkey.Text += 8;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            passkey.Text += 9;
        }

        private void BCEL_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                SCR.Text = "請輸入密碼(初始密碼0000)";
                passkey.Text = "";
            }
            else
            {
                panel2.Visible = false;
                panel1.Visible = true;
                passkey.Visible=false;
                SCR.Text = "謝謝光臨!";
                System.Threading.Thread.Sleep(3000);
                SCR.Text = "請輸入密碼(初始密碼0000)";
                passkey.Visible = true;
            }
        }

        private void passkey_TextChanged(object sender, EventArgs e)
        {
            if (passkey.Text.Length > 16)
            {
                passkey.Text=passkey.Text.Substring(0,16);
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            passkey.Text += 0;
        }

        private void B00_Click(object sender, EventArgs e)
        {
            passkey.Text += 0;
            passkey.Text += 0;
        }

        private void BCLR_Click(object sender, EventArgs e)
        {
            if (passkey.Text.Length > 0)
            {
                passkey.Text = passkey.Text.Substring(0, passkey.Text.Length - 1);
            }
        }

        private void BENR_Click(object sender, EventArgs e)
        {
            if(passkey.Text!=x)
            {
                MessageBox.Show("密碼錯誤!");
            }
            else
            {
                SCR.Text = "請選擇服務項目";
                passkey.Text = "";
                panel1.Visible = false;
                panel2.Visible = true;

            }
        }

    }
}
