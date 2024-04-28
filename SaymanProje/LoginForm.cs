using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaymanProje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        saymandbEntities baglan = new saymandbEntities();
        //global tanımla
        private void button1_Click(object sender, EventArgs e)
        {
            string kul = textBox1.Text;
            //textbox1.Text veriyi kul atadım
            string sifre = textBox2.Text;
            //sifreye textbox2.Text
            var sorgu=baglan.admin.Where(x=>x.Username==kul && x.Password==sifre).FirstOrDefault();
            //where filtrelenen verilerden kullanıcı ve sifre eşit olan ilk
            //değeri getir
            //var hertürlü içeriği içinde tutuyor
            if(sorgu==null)
            {
                MessageBox.Show("Kullanıcı veya Şifre Hatalı");
            }
            else
            {
                Form1 anaform = new Form1();
                anaform.Show();
                this.Hide();
;
            }

        }
    }
}
