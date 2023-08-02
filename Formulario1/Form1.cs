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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnchama2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form frm2 = new frm2();
            frm2.ShowDialog();
        }

        private void btncalcular_quadrado_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtlado.Text);
            double resultado = Convert.ToDouble(txtlado.Text);

            resultado = lado * lado;

            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlado.Clear();
            txtresultado.Clear();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form f1 = new frmmenu();
            f1.ShowDialog();
        }
    }
}
