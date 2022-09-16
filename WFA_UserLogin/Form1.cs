using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
        int rndNumber;
        int temp = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRastgeleSayi.Text = randomNumber().ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (temp>1)
            {
                if (txtGirisAlani.Text != lblRastgeleSayi.Text)
                {

                    txtGirisAlani.Text = string.Empty;
                    lblRastgeleSayi.Text = randomNumber().ToString();
                    txtGirisAlani.Focus();
                    foreach (Control item in Controls)
                    {
                        if (item.Name.Contains("star") && item.Visible)
                        {
                            item.Visible = false;
                            break;
                        }
                    }
                    temp -= 1;
                }
                else
                {
                    MessageBox.Show("Hosh Geldiniz");
                }
            }
            else
            {
                lblRastgeleSayi.Text = "********";
                txtGirisAlani.Text = string.Empty;
                txtGirisAlani.Enabled=false;
                btnLogin.Enabled = false;
                Controls.OfType<PictureBox>().All(x => x.Visible = true);
                MessageBox.Show("Girish saglanmadi","Hata");
            }
            
           
        }

        private int randomNumber()
        {

            Random rnd = new Random();
            this.rndNumber = rnd.Next(10000000, 99999999);
            return this.rndNumber;

        }
        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
