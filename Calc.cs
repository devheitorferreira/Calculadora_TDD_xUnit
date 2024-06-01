using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComHistorico
{
    public class Calc
    {

        //criação dos metodos da calculadora
        private List<string> listaOperacaoes;

        public Calc()
        {
            listaOperacaoes = new List<string>();
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaOperacaoes.Insert(0, "Resultado: " + res);

            return res;
        }
        public int sub(int val1, int val2)
        {
            int res = val1 - val2;
            listaOperacaoes.Insert(0, "Resultado: " + res);

            return res;
        }
        public int multi(int val1, int val2)
        {
            int res = val1 * val2;
            listaOperacaoes.Insert(0, "Resultado: " + res);

            return res;
        }
        public int div(int val1, int val2)
        {
            int res = val1 / val2;
            listaOperacaoes.Insert(0, "Resultado: " + res);

            return res;
        }

        public List<string> historico() 
        {
            //List<string> ret = new List<string>();
            listaOperacaoes.RemoveRange(3, listaOperacaoes.Count - 3);
            return listaOperacaoes;
        }
    }
}