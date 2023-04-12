using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex08
    {
        public static void Executar()
        {
            int cc = 0; //declarando variavel conta corrente
            Console.WriteLine("Insira o valor de sua conta corrente com 3 digitos"); //atribuindo valor a variavel cc
            cc = int.Parse(Console.ReadLine()); //convertendo cc 'string' em cc 'int'

            int c, d, u; //declarando variaveis centena, dezena, unidade

            c = cc / 100; //divindo cc/100 para transformar o resultado em unidade
            d = cc % 100 / 10; //o resto da divisão divido por 10 para transformar o resultado em dezena
            u = cc % 100 % 10; //o resto da divisão por 100, o resultado do resto divido por 10 para transformar o resultado em unidade

            int numInv = (u * 100) + (d * 10) + c; /*(declarando variavel numero invertido e atribuindo valor
                                                    * u (unidade) * 100 para transformar em centena
                                                    * d (dezena) * 10 para transformar em dezena
                                                    * c (centena) que já havia sido transformado em unidade */
            
            int sdi = cc + numInv; //declarando variavel soma da cc e numero inverso
            int ce, de, un; // declarando variavel ce (centena) + de (dezena) + un (unidade) para descobrir CDU do SDI

            ce = sdi / 100; //divindo sdi/100 para transformar o resultado em unidade
            de = sdi % 100 / 10; //o resto da divisão divido por 10 para transformar o resultado em dezena
            un = sdi % 100 % 10; //o resto da divisão por 100, o resultado do resto divido por 10 para transformar o resultado em unidade

            int mds = (ce * 1) + (de * 2) + (un * 3); //declarando e atribuindo valor a variavel multiplicação das somas (ce,de,un)

            int dv = (mds % 100) % 10; // declarando e atribuindo valor a variavel digito verificador 

            Console.WriteLine("O digito verificador da sua conta corrente é {0}", dv);
        }
    }
}
