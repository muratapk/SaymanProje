﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm yeni = new AdminForm();
            yeni.MdiParent = this;
            yeni.Show();
        }
    }
}
