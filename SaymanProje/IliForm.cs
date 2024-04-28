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
    public partial class IliForm : Form
    {
        public IliForm()
        {
            InitializeComponent();
        }
        saymandbEntities baglan = new saymandbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Ili bos = new Ili();
            bos.IlAd = textBox1.Text;
            baglan.Ili.Add(bos);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            doldur();
        }
        private void doldur()
        {
            var sorgu = baglan.Ili.ToList();
            dataGridView1.DataSource = sorgu;
        }

        private void IliForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            //varsayılan satırın veya seçilen satırın numarasını al
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            //textbox1 bizim kullanıcı adımız datagridview1 seçilen satır numarasına göre
            //ikinci hücredeki kullanıcı atıyoruz.Textbox1 atıyoruz.
            textBox2.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silme Aktif Oldu");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzeltme Aktif Oldu");
        }
    }
}
