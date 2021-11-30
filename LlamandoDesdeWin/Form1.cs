using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDesdeWin
{
    public partial class Form_Mostrar : Form
    {
        public Form_Mostrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Metodo Variable
            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();
            int num1 = Int32.Parse(this.sum1.Text);
            int num2 = Int32.Parse(this.sum2.Text);

            this.txtSUMA.Text = ob1.suma(num1, num2).ToString();
            double fact = double.Parse(this.facto.Text);
            this.txtFACTO.Text = ob1.factorial(fact).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
