using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex01
    {
        public static void Executar()
        {
            double ba, h, pe, ar, di; // declarando as variáveis base, altura, perimetro, area, diagonal
            Console.WriteLine("Digite a base do retângulo: "); //atribuindo valor a variavel ba
            ba = double.Parse(Console.ReadLine()); //convertendo ba 'string' em ba 'double'

            Console.WriteLine("Digite a altura do retângulo: ");//atribuindo valor a variavel h
            h = double.Parse(Console.ReadLine()); //convertendo h 'string' em h 'double'

            pe = (ba*2) + (h*2); // calculando o perímetro
            Console.WriteLine("O perímetro do retângulo é " + pe); //resultado do perimetro

            ar = ba * h; //calculando a área
            Console.WriteLine("A área de um retângulo é " + ar); //resultado da area

            di = Math.Sqrt(Math.Pow(ba, 2) + Math.Pow(h, 2)); // calculando a diagonal
            Console.WriteLine("A diagonal do retângulo é {0} \n", di);  //resultado da diagonal
        }
    }
}
