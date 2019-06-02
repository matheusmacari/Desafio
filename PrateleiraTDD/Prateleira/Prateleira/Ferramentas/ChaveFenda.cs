using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Ferramentas
{
    public class ChaveFenda : Ferramenta
    {
        private bool ChaveOk { get; set; }

        public ChaveFenda(bool chaveOk)
        {
            this.ChaveOk = chaveOk;
        }

        public override bool EstaFuncionando()
        {
            return ChaveOk;
        }
    }
}
