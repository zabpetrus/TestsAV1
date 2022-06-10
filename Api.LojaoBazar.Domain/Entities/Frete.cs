using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Frete
    {
        private string CodigoServico { get; set; }

        private string CepOrigem { get; set; }

        private string CepDestino { get; set; }

        private string Peso { get; set; }

        private decimal Altura { get; set; }

        private bool MaoPropria { get; set; }

        private bool AvisoRecebimento { get; set; }

        private decimal ValorDeclarado { get; set; }

        private decimal Diametro { get; set; }

        private decimal Largura { get; set; }

        private decimal Comprimento { get; set; }

        private int CodigoFormato { get; set; }



        public void setCodigoServico(string v)
        {
            CodigoServico = v;
        }

        public void setCepOrigem(string v)
        {
            CepOrigem = v;
        }

        public void setCepDestino(string v)
        {
            CepDestino = v;
        }

        public void setPeso(string v)
        {
            Peso = v;
        }

        public void setAltura(decimal v)
        {
            Altura = v;
        }

        public void setMaoPropria(bool v)
        {
            MaoPropria = v;
        }

        public void setAvisoRecebimento(bool v)
        {
            AvisoRecebimento = v;
        }

        public void setValorDeclarado(decimal v)
        {
            ValorDeclarado = v;
        }

        public void setDiametro(decimal v)
        {
            Diametro = v;
        }

        public void setLargura(decimal v)
        {
            Largura = v;
        }

        public void setComprimento(decimal v)
        {
            Comprimento = v;
        }

        public void setCodigoFormato(int v)
        {
            CodigoFormato = v;
        }
    }
}
