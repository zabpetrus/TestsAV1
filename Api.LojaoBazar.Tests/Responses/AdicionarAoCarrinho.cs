using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Responses
{
    public class AdicionarAoCarrinho
    {
        [Fact]
        public void Test1()
        {
            Produto produto1 = new Produto();
            produto1.setNome("Notebook Acer Aspire 3 Intel Core");
            produto1.setQuantidade(1);
            produto1.setId(4);
            produto1.setFornecedor("Acer");
            produto1.setPreco(3024.20);


            Produto produto2 = new Produto();
            produto2.setNome("Chocolate kit kat dark 41,5G");
            produto2.setQuantidade(7);
            produto2.setId(4);
            produto2.setFornecedor("Nestle");
            produto2.setPreco(3.69);


            Frete frete = new Frete();
            frete.setCodigoServico("04014");
            frete.setCepOrigem("26985254"); //Não pode ser formatado
            frete.setCepDestino("26985254");
            frete.setPeso("2"); //Em quilogramas (kg)
            frete.setCodigoFormato(1); //1,2,3
            frete.setComprimento(12.6m);
            frete.setAltura(1.2m);
            frete.setLargura(2.3m);
            frete.setDiametro(5.6m);
            frete.setMaoPropria(false);
            frete.setValorDeclarado(2.3m);
            frete.setAvisoRecebimento(false);


            ItensCarrinho item1 = new ItensCarrinho();
            item1.setID(5);
            item1.setNomeProduto("Camisa de Alça");
            item1.setPreco(5.33);
            item1.setProdutoID(6);
            item1.setCarrinhoID(4);     

            Carrinho carrinho = new Carrinho();
            carrinho.setID(5);
            carrinho.setDataCompra( DateTime.Now );
            carrinho.setFrete(4.69);
            carrinho.setValorTotal(5.69);
        }
    }
}
