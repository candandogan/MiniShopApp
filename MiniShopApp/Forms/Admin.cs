using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShopApp.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            checkBoxShowPassword_CheckedChanged(null,null); //To display the password as '*' on the screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxAdminName.Text=="" || textBoxAdminPassword.Text == "")
            {
                MessageBox.Show("KULLANICI ADI YA DA ŞİFRE BOŞ BIRAKILAMAZ!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxAdminName.Text != "candan" && textBoxAdminPassword.Text == "2357")
            {
                MessageBox.Show("KULLANICI ADINI YANLIŞ GİRDİNİZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (textBoxAdminName.Text == "candan" && textBoxAdminPassword.Text != "2357")
            {
                MessageBox.Show("ŞİFREYİ YANLIŞ GİRDİNİZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult dialogResult = MessageBox.Show("Şifre için ipucu ister misiniz?", "Yardım", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                {

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Tek basamaklı asal sayılar", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(textBoxAdminName.Text=="candan" && textBoxAdminPassword.Text == "2357")
            {
                HomePage a = new HomePage(); // If the username and password are entered correctly, the homepage opens.
                a.Show();
                
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
        }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //if checkBox is checked
            if (checkBoxShowPassword.Checked)
            {
                // show the password
                textBoxAdminPassword.PasswordChar = '\0';
            }
            //if not, substitute * for characters.
            else
            {
                textBoxAdminPassword.PasswordChar = '*';
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
