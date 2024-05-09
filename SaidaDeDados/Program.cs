namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int idade = 19;
            double saldo = 100;
            string nome = "ana";

            Console.WriteLine("{0} tem {1} anos e seu saldo é {2} reais.", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é {saldo} reais.");

            Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é " + saldo + " reais");
        }
    }
}
