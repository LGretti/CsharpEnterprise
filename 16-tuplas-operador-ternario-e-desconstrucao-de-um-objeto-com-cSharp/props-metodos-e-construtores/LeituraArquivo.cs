using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props_metodos_e_construtores {
    public class LeituraArquivo {

        //o retorno vai ser uma tupla com 3 dados, 1 bool, uma string vetor com as linhas
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) LerArquivo(string path) {
            try {

                string[] linhas = File.ReadAllLines(path);

                return(true, linhas, linhas.Count());

            } catch (Exception e) {
                return(false, new string[0], 0);
            }

        }
    }
}
