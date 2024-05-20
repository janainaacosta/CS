// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
// Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:

// 1.Álcool
// 2.Gasolina
// 3.Diesel
// 4.Fim

//Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código
//(até que seja válido). O programa será encerrado quando o código informado for o número 4.
//Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível


namespace exe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Informe o código: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo < 1 || codigo > 4) {
                    Console.WriteLine("Código inválido!");

                    Console.Write("Informe o código: ");
                }

                if (codigo == 1)
                {
                    alcool += 1;
                }
                else if (codigo == 2) { 
                    gasolina += 1;
                }
                else if (codigo == 3)
                {
                    diesel += 1;    
                }

                Console.Write("Informe o código: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigada!");
            Console.WriteLine($"Vendas de álcool: {alcool}");
            Console.WriteLine($"Vendas de gasolina: {gasolina}");
            Console.WriteLine($"Vendas de diesel: {diesel}");

        }
    }
}
