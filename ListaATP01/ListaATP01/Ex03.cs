using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP01
{
    public static class Ex03
    {
        public static void Executar()
        {
            double kw, sm, consumo, vt, vd; //declarando as variáveis killowatts, salario minimo, consumo, valor total, valor com desconto
            Console.WriteLine("Digite o sálario mínimo: "); //atribuindo valor a variavel salario minimo (sm)
            sm = double.Parse(Console.ReadLine()); //convertendo sm 'string' em sm 'double'

            Console.WriteLine("Digite o consumo de kilowatt: "); //atribuindo valor a variavel kilowatt (kw)
            consumo = double.Parse(Console.ReadLine()); //convertendo consumo 'string' em consumo 'double'

            kw = sm / 700; //kw = 1/7 do salário mínimo

            vt = kw * consumo; //calculando o valor total
            Console.WriteLine("O valor total a ser pago é: " + vt); //resultado do valor total

            vd = vt*0.9; //calculando o valor com desconto
            Console.WriteLine("O valor com desconto da fatura é: {0}\n", vd); //resultado do valor com desconto



        }

    }
}
