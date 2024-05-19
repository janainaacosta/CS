// Fazer um programa para ler quatro valores inteiros A, B, C e D.
// A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:
// DIFERENCA = (A * B - C * D).

namespace exe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor para C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor para D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine($"A área do círculo de raio {2} é {diferenca}");
        }
    }
}
