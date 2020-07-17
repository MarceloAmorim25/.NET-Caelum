using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Conta conta = new Conta();
            conta.Numero = 12345;


            Cliente cliente = new Cliente("Marcelo");
            conta.Titular = cliente;

            textTitular.Text = conta.Titular.Name;

        }

        private void textTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string digitado = textNumero.Text;
            double operacao = Convert.ToDouble(digitado);
            conta.Deposita(operacao);
            textSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");

        }




    }
}
