using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {
    public static class IntExtensions {
        //this int quer dizer o proprio valor que estou chamando
        //no caso o numero na program que é uma var int tem esse método
        //de extensao

        //se for this string ali, vai ser então apenas para strings
        public static bool EhPar(this int numero) {
            return numero % 2 == 0;
        }
    }
}
