using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Variaveis
    {
        static void Main(string[] args)

        {
            int numero = 1;
            string cor = "laranja";
            float moeda = 1.0f;
            bool resposta = false;

            Console.WriteLine(numero);
            Console.WriteLine(cor);
            Console.WriteLine(moeda);
            Console.WriteLine(resposta);

            numero = 2;
            cor = "verde";
            moeda = 2.0f;
            resposta = false;

            Console.WriteLine(numero);
            Console.WriteLine(cor);
            Console.WriteLine(moeda);
            Console.WriteLine(resposta);

            dynamic fruta = "pera";

            Console.WriteLine(fruta);

            fruta = 23;

            Console.WriteLine(fruta);

            Console.ReadLine();
        }
    }
}
