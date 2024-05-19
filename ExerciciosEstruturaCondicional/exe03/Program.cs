// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
// Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
// ordem crescente ou decrescente

namespace exe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Informe um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0) {

                Console.WriteLine("São multiplos");
            
            }else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
