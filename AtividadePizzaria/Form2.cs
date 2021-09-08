using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadePizzaria
{
    public partial class Form2 : Form
    {
        Cliente info;
        public Form2(Cliente info)
        {
            InitializeComponent();
            this.info = info;
        }
        static int numeropedido = 0;

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {           
           
            Pedido infop = new Pedido();
            string pedidob = cboTBebidas.SelectedItem.ToString();
            string pedidop = cboTPSalgado.SelectedItem.ToString();
            infop.IdPedido = numeropedido + 1;
            
            infop.DescricaoPizza = ($"Uma Pizza {cboTPSalgado.SelectedItem} sabor {cboSPSalgado.SelectedItem}");
            if (pedidob == "Sem Bebida")
            {
                infop.DescricaoBebida = ("Sem Bebida");
            }
            else
            {                
                infop.DescricaoBebida = ($"um refrigente {cboSBebidas.SelectedItem} tamanho {cboTBebidas.SelectedItem}");
            }
            infop.CalculoPedidoP(pedidop);
            infop.CalculoPedidoB(pedidob);
            MessageBox.Show(infop.ToString());
            Form3 form3 = new Form3(info, infop);
            form3.Show();
            this.Hide();          
            


        }
    }
}
