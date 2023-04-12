using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex02
    {
        public static void Executar()
        {
            double c1, c2, hi; //declarando as variáveis
            Console.WriteLine("Insira os cateto1 do triângulo: "); //atribuindo valor a variavel cateto 2
            c1 = double.Parse(Console.ReadLine()); //convertendo c1 'string' em c1 'double'

            Console.WriteLine("Insira o cateto2 do triângulo: "); //atribuindo valor a variavel cateto 2
            c2 = double.Parse(Console.ReadLine()); //convertendo c1 'string' em c1 'double'

            hi = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c1, 2)); //calculando a hipotenusa
            Console.WriteLine("A diagonal do retângulo é {0}\n", hi); //resultado
        }
    }
}
