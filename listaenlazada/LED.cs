using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada{
    internal class LED{
        private NodoD Primero {  get; set; }
        
        public void AgregaIni(int valor) {
            //agregar un dato al inicio
            NodoD nuevo = new NodoD(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            } else {
                NodoD prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero.Ant = nuevo;
                this.Primero = nuevo;
            }
        }

        public void AgregaFin(int valor) {
            //agregar un dato al inicio
            NodoD nuevo = new NodoD(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            } else {
                NodoD ultimo = Primero;
                while (ultimo.Sig != null) {
                    ultimo = ultimo.Sig;
                }
                ultimo.Sig = nuevo;
                nuevo.Ant = ultimo;
            }
        }

        public void EliminaSegundo() {
            
            if (this.Primero != null && this.Primero.Sig!=null) {
                NodoD segundo = this.Primero.Sig;
                NodoD tercero = segundo.Sig;
                this.Primero.Sig = tercero;
                if (tercero!= null) {
                    tercero.Ant = this.Primero;
                }

                segundo.Sig = null;
                segundo.Ant = null;
            }
        }

        public bool BuscaValor(int valorBuscar) {
            NodoD tmp = Primero;
            while (tmp != null) {
                if (tmp.Dato == valorBuscar) {
                    return true;
                }
                tmp = tmp.Sig;
            }
            return false;
        }

        public int Get(int idx) {
            NodoD tmp = Primero;
            int indice = 0;
            while (tmp != null) {
                if (indice == idx) {
                    return tmp.Dato;
                }
                indice++;
                tmp = tmp.Sig;
            }
            return int.MinValue;
        }

        public int Length() {
            NodoD tmp = Primero;
            int contar = 0;
            while (tmp != null) {
                contar++;
                tmp = tmp.Sig;
            }
            return contar;
        }

        public void MerclaAlFinal2(LED listFin) {

            if (listFin.Primero == null) return;

            if (this.Primero == null) {
                this.Primero = listFin.Primero;
            } else {
                NodoD tmp = Primero;
                while (tmp.Sig != null) {
                    tmp = tmp.Sig;
                }
                tmp.Sig = listFin.Primero;
                listFin.Primero.Ant = tmp;
            }
        }

        public void Imprime(){
            NodoD tmp = Primero;
            while (tmp != null){
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }
        }

        public void ImprimeInversa() {
            NodoD tmp = Primero;
            if (tmp == null) return;
            //último vagón
            while(tmp.Sig!=null) {
                tmp = tmp.Sig;
            }

            //recorrido inverso
            while(tmp!=null) {
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Ant;
            }
        }
    }
}
