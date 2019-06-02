using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Insumos
{
    public class Parafusos : Insumo
    {
        public Parafusos(double diametro, int quantidade) : base(diametro, quantidade)
        {
        }

        public override bool VerificarCompatibilidade(double diametroDesejado, int quantidadeDesejada)
        {
            return VerificarDiametro(diametroDesejado) && VerificarQuantidade(quantidadeDesejada);
        }
    }
}
