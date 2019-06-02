using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Ferramentas
{
    public class Lapis : Ferramenta
    {
        private bool LapisOk { get; set; }

        public Lapis(bool lapisOk)
        {
            this.LapisOk = lapisOk;
        }
        public override bool EstaFuncionando()
        {
            return LapisOk;
        }
    }
}
