using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SimplesDelegate();

    class ExemploDeDelegate
    {
        public static void minhaFuncao()
        {
            Console.WriteLine("Eu fui chamada por um delegate ...");
        }
   
    }
}
