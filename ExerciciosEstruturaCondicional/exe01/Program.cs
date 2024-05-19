// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.


namespace exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());    

            if(num < 0 ) {
                Console.WriteLine($" o número {num} é negativo");
            }
            else if( num > 0 ) {
                Console.WriteLine($" o número {num} é positivos");
            }
        }
    }
}
