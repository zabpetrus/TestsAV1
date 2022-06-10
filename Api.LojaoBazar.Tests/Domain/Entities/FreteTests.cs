using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class FreteTests
    {
        [Fact]
        public void Test1()
        {
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

            Assert.NotNull(frete);

        }
    }
}
