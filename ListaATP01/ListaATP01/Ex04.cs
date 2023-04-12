using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex04
    {
        public static void Executar()
        {
            double x1,y1,x2,y2,di;//declarando as variáveis

            Console.WriteLine("Digite o eixo x1");
            x1 = double.Parse(Console.ReadLine());//convertendo x1 'string' em x1 'double'

            Console.WriteLine("Digite o eixo y1");
            y1 = double.Parse(Console.ReadLine());//convertendo y1 'string' em y1 'double'

            Console.WriteLine("Digite o eixo x2");
            x2 = double.Parse(Console.ReadLine());//convertendo x2 'string' em x2 'double'

            Console.WriteLine("Digite o eixo y2");
            y2 = double.Parse(Console.ReadLine());//convertendo y2 'string' em y2 'double'

            di = Math.Sqrt(Math.Pow((x2 - x1), 2) * Math.Pow((y2 - y1), 2));//calculando a distância
            Console.WriteLine("A distância entre os dois pontos é de {0}\n", di); //resultado da distância
        }
    }
}
