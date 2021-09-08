using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadePizzaria
{
    public partial class Form3 : Form
        
    {       

        public Form3(Cliente info, Pedido infop)
        {
            InitializeComponent();
            dataGridTabelaPedido.Rows.Add(new object[] { info.IdCliente, info.Nome, info.Telefone,infop.IdPedido,infop.DescricaoPizza,infop.DescricaoBebida,infop.ValorTotal });
            
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            dataGridTabelaPedido.Rows.Clear();
        }
    }
}
