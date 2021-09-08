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
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Pedido infop = new Pedido();
            infop.DescricaoPizza = ($"Uma Pizza {cboTPSalgado.SelectedItem} sabor {cboSPSalgado.SelectedItem}");
            


        }
    }
}
