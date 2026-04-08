using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada{
    internal class NodoD{
        public NodoD Sig { get; set; }
        public NodoD Ant { get; set; }
        
        public int Dato { get; set; }

        public NodoD(int dato){
            Sig = null;
            Ant = null;
            Dato = dato;
        }
    }
}
