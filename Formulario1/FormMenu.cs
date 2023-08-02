using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new frm1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm2 = new frm2();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm3 = new frm3();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form frm1 = new frm1();
                frm1.ShowDialog();
        }

        private void retanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new frm1();
            frm1.ShowDialog();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new frm3();
            frm3.ShowDialog();
        }
    }
}