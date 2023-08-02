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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnvolta2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_retangulo_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtlado.Text);
            double altura = Convert.ToDouble(txtaltura.Text);

            double resultado2 = altura * lado;

            txtresultado2.Text = resultado2.ToString();
        }

        private void btnfechar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form f1 = new frmmenu();
            f1.ShowDialog();
        }

        private void btnlimpar2_Click(object sender, EventArgs e)
        {
            txtlado.Clear();
            txtaltura.Clear();
            txtresultado2.Clear();
        }
    }
}
