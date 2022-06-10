using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Pagamento
    {

        private double Valor { get; set; }

        private int clienteID { get; set; }

        private char FormaPagamento { get; set; }



        public void setValor(double v)
        {
            Valor = v;
        }

        public void setClienteID(int _clienteID)
        {
            clienteID = _clienteID;
        }

        public void setFormaPagamento(char v)
        {
            FormaPagamento = v;
        }
    }
}
