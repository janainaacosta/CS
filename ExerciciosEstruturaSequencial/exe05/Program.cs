//Fazer um programa para ler:


//o código de uma peça 1
//o número de peças 1
//o valor unitário de cada peça 1,

//o código de uma peça 2
//o número de peças 2 
//o valor unitário de cada peça 2. 

//Calcule e mostre o valor a ser pago.

namespace exe05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe código, quantidade e valor unitários das peças 01 abaixo:");
            string[] v_peca01 = Console.ReadLine().Split(" ");

            string codigo_peca01 = v_peca01[0];
            int qtde_peca01 = int.Parse(v_peca01[1]);
            double valor_peca01 = double.Parse(v_peca01[2]);

            Console.WriteLine(codigo_peca01);
            Console.WriteLine(qtde_peca01);    
            Console.WriteLine(valor_peca01);   

        }
    }
}
