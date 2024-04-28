using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaymanProje
{
    public partial class BransForm : Form
    {
        public BransForm()
        {
            InitializeComponent();
        }
        saymandbEntities baglan = new saymandbEntities();
        private void BransForm_Load(object sender, EventArgs e)
        {
            doldur();
        }
        private void doldur()
        {
            var sorgu = baglan.Branslar.ToList();
            dataGridView1.DataSource = sorgu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Branslar bos = new Branslar();
            bos.BransAd = textBox1.Text;
            
            baglan.Branslar.Add(bos);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz?", "Brans Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int Id = Convert.ToInt16(textBox2.Text);
            if (cevap == DialogResult.Yes)
            {
                var sorgu = baglan.Branslar.Where(x => x.BransId == Id).FirstOrDefault();
                //sorgu ile veritabanın silinecek kaydı getir  sorgu içerisine ata
                baglan.Branslar.Remove(sorgu);
                baglan.SaveChanges();
                MessageBox.Show("Kaydınız Silinmiştir");
                doldur();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edilmiştir");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            //varsayılan satırın veya seçilen satırın numarasını al
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            //textbox1 bizim kullanıcı adımız datagridview1 seçilen satır numarasına göre
            //ikinci hücredeki kullanıcı atıyoruz.Textbox1 atıyoruz.
            textBox2.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            //Id değeri buradan alacak
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu Kaydı Değiştirme İstiyor musunuz?", "Admin Düzeltme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int Id = Convert.ToInt16(textBox2.Text);
            if (cevap == DialogResult.Yes)
            {
                var sorgu = baglan.Branslar.Where(x => x.BransId == Id).FirstOrDefault();
                //sorgu ile veritabanın silinecek kaydı getir  sorgu içerisine ata
                sorgu.BransAd = textBox1.Text;
               
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
            string ad = textBox3.Text;
          
            var sorgu = baglan.Branslar.Where(x => x.BransAd.StartsWith(ad)).ToList();
            
            dataGridView1.DataSource = sorgu;
        }
    }
}
