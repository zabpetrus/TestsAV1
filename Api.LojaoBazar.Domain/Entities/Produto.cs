﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Produto
    {
        private int Id { get; set; }

        private string Nome { get; set; }

        private int Quantidade { get; set; }

        private double Preco { get; set; }

        private string Fornecedor { get; set; }

        public void setId(int v)
        {
            Id = v;
        }

        public void setQuantidade(int v)
        {
            Quantidade = v;
        }

        public void setFornecedor(string v)
        {
            Fornecedor = v;
        }

        public void setPreco(double v)
        {
            Preco = v;
        }

        public void setNome(string v)
        {
            Nome = v;
        }
    }
}
