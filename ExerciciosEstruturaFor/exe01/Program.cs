// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

namespace exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor de 1 a 1000: ");
            int numero = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= numero;  i++) { 

                if (numero < 1 || numero > 1000) {
                    Console.WriteLine("Número inválido.");
                    Console.Write("Informe um valor de 1 a 1000: ");
                    numero = int.Parse(Console.ReadLine());
                }
            
                if (i % 2 != 0) {
                    Console.WriteLine($"valor #{i}");
                }
            }
        }
    }
}
