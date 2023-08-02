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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btncalcular_triangulo_Click(object sender, EventArgs e)
        {
            double bas = Convert.ToDouble(txtbase.Text);
            double altura = Convert.ToDouble(txtaltura.Text);

            double resultado = (bas* altura) /2;

            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbase.Clear();
            txtaltura.Clear();
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
