using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex06
    {
        public static void Executar() 
        {
            int a, b,aux; //declarando variaveis
            Console.WriteLine("Insira o valor de a"); //atribuindo valor a variavel a
            a = int.Parse(Console.ReadLine()); //convertendo a 'string' em a 'int'

            Console.WriteLine("Insira o valor de b"); //atribuindo valor a variavel b
            b = int.Parse(Console.ReadLine()); //convertendo b 'string' em b 'int'

            aux = a; //auxiliar recebe o valor de a
            a = b; //a recebe o valor de b
            b = aux; //b recebe o valor de auxiliar

            Console.WriteLine("O valor de a é {0} e o de b é {1}\n", a, b);
            
        }
    }
}
