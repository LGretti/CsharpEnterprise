using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {

    //esse <T> representa uma classe genérica, é T de tipo
    //Ele pode ser qq outra letra
    public class MeuArray<T> {
        private static int capacidade = 10;
        private int contador = 0;
        public T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento) {
            if (contador + 1 < 11) {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index] {
            get { return array[index];  }
            set { array[index] = value; }
        }
    }
}
