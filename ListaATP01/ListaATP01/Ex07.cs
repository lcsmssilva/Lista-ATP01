using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex07
    {
        public static void Executar()
        {
            int d = 0;
            int m = 0;
            int a = 0;
            int dsa = 0;

            Console.WriteLine("Insira os dias sem acidentes: ");
            dsa = int.Parse(Console.ReadLine());

            if (dsa >= 365) //se dias sem acidente for maior do que 365
            {
             a = dsa/365; //ano = dias sem acidente divido por 365
             dsa = dsa - (a*365); //transforma a variável dsa em m
            } 
            
            if (dsa >= 30) //se dias sem acidente for maior que 30
            {
             m = dsa / 30; //mês = dias sem acidente divido por 30
             dsa = dsa - (m*30); //transforma a variavel dsa em d
            }
            
            if (dsa < 30) //se dias sem acidente for maior que 0
            {
            d = dsa % 30; //dias = dias sem acidente + resto da divisão por 30
            }

            Console.WriteLine("Estamos a {0} ano, {1} meses e {2} dias sem acidente\n", a, m, d);
        }
    }
}
