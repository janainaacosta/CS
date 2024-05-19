// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.


namespace exe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine()); 
            
            if (num % 2  == 0) {
                Console.WriteLine("Este número é PAR.");
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("Este número é ÍMPAR.");
            }
        }
    }
}
