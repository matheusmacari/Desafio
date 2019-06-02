using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Ferramentas
{
    public class Regua : Ferramenta
    {
        private double Tamanho { get; set; }

        public Regua(double tamanho)
        {
            this.Tamanho = tamanho;
        }

        public override bool EstaFuncionando()
        {
            return Tamanho > 0;
        }
    }
}
