using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada
{
    internal class Locomotora
    {
        public Vagon Primero {  get; set; }

        public void Imprime()
        {
            Vagon tmp = Primero;
            while (tmp != null)
            {
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }
        }
    }
}
