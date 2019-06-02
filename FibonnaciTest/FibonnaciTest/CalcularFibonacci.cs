using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciTest
{
    class CalcularFibonacci
    {
        static void Main(string[] args)
        {
            SequenciaFibonacci sequencia = new SequenciaFibonacci(new List<int> { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76 });
            sequencia.GerarSequencia();
        }
    }
}
