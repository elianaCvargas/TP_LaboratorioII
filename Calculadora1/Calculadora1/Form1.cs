using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Numero numeroUno ;

        Numero numeroDos ;
      
        private void txtNumero1_TextChanged_1(object sender, EventArgs e)
        {
            
            numeroUno  = new Numero(txtNumero1.Text);
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            numeroDos = new Numero(txtNumero2.Text);
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculadora.ValidarOperador(cmbOperacion.Text );
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);
            lblResultado.Text = Convert.ToString(Calculadora.Operar(num1, num2, Calculadora.ValidarOperador(this.cmbOperacion.Text)));
            
            //lblResultado.Text = Convert.ToString(Calculadora.Operar(txtNumero1_TextChanged_1( sender,  e),txtNumero2_TextChanged( sender,  e) , cmbOperacion.Text) );

            //lblResultado.Text = Convert.ToString(Calculadora.Operar(numeroUno.getNumero(), numeroDos.getNumero(), cmbOperacion.Text));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //esto en  realidad debiera ir en cmbOperar
            this.cmbOperacion.Items.Add("+");
            this.cmbOperacion.Items.Add("-");
            this.cmbOperacion.Items.Add("*");
            this.cmbOperacion.Items.Add("/");

        }

        

       
    }
}
