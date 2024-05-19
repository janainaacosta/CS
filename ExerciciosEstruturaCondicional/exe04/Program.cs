// Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

using System.Runtime.Intrinsics.X86;

namespace exe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o código do lanche: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            double pedido = 0;

            if (codigo == 1) 
            { 
                pedido = 4.0 * quantidade;
            
            }else if (codigo == 2)
            {
                pedido = 4.5 * quantidade;
            }
            else if (codigo == 3)
            {
                pedido = 5.0 * quantidade;
            }
            else if (codigo == 4)
            {
                pedido = 2.0 * quantidade;

            }
            else if (codigo == 5)
            {
                pedido = 1.5 * quantidade;
            }


            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O total do seu pedido é R${pedido}");      
        }
    }
}
