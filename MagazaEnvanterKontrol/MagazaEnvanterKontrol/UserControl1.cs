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
    }
}
