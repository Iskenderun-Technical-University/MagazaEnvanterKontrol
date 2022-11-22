using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaEnvanterKontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if(kryptonTextBox1.Text == "Kullanıcı Adı")
            {
                kryptonTextBox1.Text = "";
                kryptonTextBox1.StateCommon.Content.Color1 = Color.WhiteSmoke;
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Kullanıcı Adı";
                kryptonTextBox1.StateCommon.Content.Color1 = Color.FromArgb(64,64,64);
            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Şifre")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.StateCommon.Content.Color1 = Color.WhiteSmoke;
                kryptonTextBox2.PasswordChar = '*';
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text = "Şifre";
                kryptonTextBox2.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
                kryptonTextBox2.PasswordChar = '\0';
            }
        }

        private void kryptonTextBox4_Enter(object sender, EventArgs e)
        {
            if(kryptonTextBox4.Text == "Kullanıcı Adı")
            {
                kryptonTextBox4.Text = "";
                kryptonTextBox4.StateCommon.Content.Color1 = Color.WhiteSmoke;
            }
        }

        private void kryptonTextBox4_Leave(object sender, EventArgs e)
        {
            if(kryptonTextBox4.Text == "")
            {
                kryptonTextBox4.Text = "Kullanıcı Adı";
                kryptonTextBox4.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            }
        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "E-Posta")
            {
                kryptonTextBox3.Text = "";
                kryptonTextBox3.StateCommon.Content.Color1 = Color.WhiteSmoke;
            }
        }

        private void kryptonTextBox3_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text = "E-Posta";
                kryptonTextBox3.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            }
        }

        private void kryptonTextBox5_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox5.Text == "Şifre")
            {
                kryptonTextBox5.Text = "";
                kryptonTextBox5.StateCommon.Content.Color1 = Color.WhiteSmoke;
                kryptonTextBox5.PasswordChar = '*';
            }
        }

        private void kryptonTextBox5_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox5.Text == "")
            {
                kryptonTextBox5.Text = "Şifre";
                kryptonTextBox5.StateCommon.Content.Color1 = Color.FromArgb(64,64,64);
                kryptonTextBox5.PasswordChar = '\0';
            }
        }

        private void kryptonTextBox6_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox6.Text == "Şifre")
            {
                kryptonTextBox6.Text = "";
                kryptonTextBox6.StateCommon.Content.Color1 = Color.WhiteSmoke;
                kryptonTextBox6.PasswordChar = '*';
            }
        }

        //1427;719

        string panel = "Login";
        string panelState = "";

        int x = 0;
        private void kryptonTextBox6_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox6.Text == "")
            {
                kryptonTextBox6.Text = "Şifre";
                kryptonTextBox6.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
                kryptonTextBox6.PasswordChar = '\0';
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            x = 650;
            panel = "Login";
            panelState = "LoginMoving";
            timer1.Start();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel = "Register";
            x = 650;
            panelState = "RegisterMoving";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel == "Login")
            {
                if (x < 1427 && panelState == "LoginMoving")
                {
                    x += 40;
                    panel1.Left = x; 
                }
                else
                {
                    panel1.Left = 1427;
                    panelState = "RegisterMoving";
                    if (x > 650 && panelState == "RegisterMoving")
                    {
                        x -= 40;
                        panel2.Left = x;
                    }
                    else
                    {
                        panel2.Left = 650;
                        panelState = "Done";
                        timer1.Stop();
                    }
                }
            }
            else
            {
                if (x < 1427 && panelState == "RegisterMoving")
                {
                    x += 40;
                    panel2.Left = x;
                }
                else
                {
                    panel2.Left = 1427;
                    panelState = "LoginMoving";
                    if (x > 650 && panelState == "LoginMoving")
                    {
                        x -= 40;
                        panel1.Left = x;
                    }
                    else
                    {
                        panel1.Left = 650;
                        panelState = "Done";
                        timer1.Stop();
                    }
                }
            }
        }


    }
}
