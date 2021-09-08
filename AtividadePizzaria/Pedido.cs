using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePizzaria
{
   public class Pedido
    {
        public int IdPedido { get; set; }
        public string DescricaoPizza { get; set; }
        public string DescricaoBebida { get; set; }
        public double ValorTotal { get; set; }
        public double CalculoPedidoP(string pedido)
        {
            if(pedido == "Broto R$ 26,00")
            {
                ValorTotal += 26.00;
            }
            else
            {
                if(pedido == "Média R$ 30,00")
                {
                    ValorTotal += 30.00;
                }
                else
                {
                    ValorTotal += 36.00;
                }
            }
            return ValorTotal;

        }
        public double CalculoPedidoB(string pedidob)
        {
            if (pedidob == "Lata (350 ml) R$ 4,00")
            {
                ValorTotal += 4.00;
            }
            else
            {
                if (pedidob == "Garrafa (600 ml) R$ 6,00")
                {
                    ValorTotal += 6.00;
                }
                else
                {
                    if (pedidob == "Garrafa (1,5 L) R$ 8,00")
                    {
                        ValorTotal += 8.00;
                    }
                    else
                    {
                        if (pedidob == "Sem Bebida")
                        {
                            ValorTotal += 0.00;
                        }
                        else
                        {
                            ValorTotal += 10.00;
                        }
                    }

                }
            }
            return ValorTotal;
        }
        public override string ToString()
        {
            return $"Seu pedido é {DescricaoPizza}, {DescricaoBebida}, dando um valor de R${ValorTotal:F2}";
        }
    }


}
