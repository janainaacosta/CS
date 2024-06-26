﻿// Escreva um programa que repita a leitura de uma senha até que ela seja válida.
// Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
// Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
// Considere que a senha correta é o valor 2002.



namespace exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a senha: ");
            int senha = int.Parse(Console.ReadLine());

           while(senha != 2002) { 
                Console.WriteLine("Senha inválida. Tente novamente.");
                Console.Write("Insira a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido.");
        }
    }
}
