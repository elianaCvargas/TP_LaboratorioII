using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
       

        
        public LaCalculadora()
        {
            InitializeComponent();

            this.Text = "Calculadora de Carla 2 C";
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Width = 500;


            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            this.NumeroUno.Clear();
            this.NumeroDos.Clear();
            this.lblResultado.ResetText();
            this.cmbOperador.ResetText() ;
        }

        private  void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text =  (Operar(this.NumeroDos.Text, this.NumeroDos.Text, this.cmbOperador.Text)).ToString();           
        }
        private static double Operar(string numeroUno, string numeroDos, string operador)
        {
            Calculadora calculadora =  new Calculadora();
            Numero n1 = new Numero(numeroUno);
            Numero n2 = new Numero(numeroDos);
            return calculadora.Operar(n1, n2, operador);

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {

            Numero num = new Numero(this.lblResultado.Text);
            lblResultado.Text = num.DecimalBinario(this.lblResultado.Text);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero(lblResultado.Text);
            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
        }

        private void NumeroDos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
