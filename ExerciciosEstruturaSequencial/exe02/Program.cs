// EXERCICIO 02
// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro asas decimais

//formula da área: area = π.raio2
//considere o valor de π = 3.14159



namespace EXE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"A área do círculo com raio 2 é igual a {area:F4}");
        }
    }
}
