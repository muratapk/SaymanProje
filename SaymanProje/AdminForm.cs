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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        saymandbEntities baglan = new saymandbEntities();
        bool dugme = false;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //select * from admin
            //var sorgu = baglan.admin.ToList();
            //dataGridView1.DataSource = sorgu;
            doldur();
            groupBox2.Visible = dugme;
        }
        private void doldur()
        {
            //geri veri dönmeyen methodlar için void
            var sorgu = baglan.admin.ToList();
            dataGridView1.DataSource = sorgu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin bos = new admin();
            bos.Username = textBox1.Text;
            bos.Password = textBox2.Text;
            bos.Authority = 1;
            baglan.admin.Add(bos);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            //varsayılan satırın veya seçilen satırın numarasını al
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            //textbox1 bizim kullanıcı adımız datagridview1 seçilen satır numarasına göre
            //ikinci hücredeki kullanıcı atıyoruz.Textbox1 atıyoruz.
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz?","Admin Silinecek",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            int Id =Convert.ToInt16(textBox3.Text);
            if(cevap==DialogResult.Yes)
            {
                var sorgu = baglan.admin.Where(x => x.AdminId == Id).FirstOrDefault();
                //sorgu ile veritabanın silinecek kaydı getir  sorgu içerisine ata
                baglan.admin.Remove(sorgu);
                baglan.SaveChanges();
                MessageBox.Show("Kaydınız Silinmiştir");
                doldur();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edilmiştir");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu Kaydı Değiştirme İstiyor musunuz?", "Admin Düzeltme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int Id = Convert.ToInt16(textBox3.Text);
            if (cevap == DialogResult.Yes)
            {
                var sorgu = baglan.admin.Where(x => x.AdminId == Id).FirstOrDefault();
                //sorgu ile veritabanın silinecek kaydı getir  sorgu içerisine ata
                sorgu.Username = textBox1.Text;
                sorgu.Password= textBox2.Text;
                sorgu.Authority =Convert.ToByte(comboBox1.Text);
                //baglan.admin.Remove(sorgu);
                baglan.SaveChanges();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                doldur();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edilmiştir");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dugme==false)
            {
                groupBox2.Visible = true;
                dugme = true;
            }
            else
            {
                groupBox2.Visible = false;
                dugme = false;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ad = textBox4.Text;
            //var sorgu = baglan.admin.Where(x => x.Username==ad).ToList();
            //bir aynı kelime üzerinden arama yapar

            //var sorgu = baglan.admin.Where(x => x.Username.Contains(ad)).ToList();
            //içinde geçen harf veya karakter atarma yapar
            var sorgu = baglan.admin.Where(x => x.Username.StartsWith(ad)).ToList();
            //başlangıç harfine göre arama yap EndsWith

            //datagridview bir liste yapısı tolist methodu istiyor
            dataGridView1.DataSource = sorgu;
        }
    }
}
