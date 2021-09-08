using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        static int numero = 0;
        
        /*private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Cliente info = new Cliente();
            numero = numero + 1;
            info.IdCliente = numero;
            info.Nome = txtNome.Text;
            info.Telefone = txtTelefone.Text;
            MessageBox.Show("Dados Salvos");
        }*/        

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Cliente info = new Cliente();
            numero = numero + 1;
            info.IdCliente = numero;
            info.Nome = txtNome.Text;
            info.Telefone = txtTelefone.Text;
            MessageBox.Show("Dados Salvos");
            Form2 f2 = new Form2(info);
            f2.Show();
            this.Hide();
        }
    }
}
