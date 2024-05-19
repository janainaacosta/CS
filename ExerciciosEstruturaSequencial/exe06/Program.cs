//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:

//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B


namespace exe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=- QUESTÃO A =-=-=-");

            Console.Write("Informe o valor de A: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            float c = float.Parse(Console.ReadLine());



            double areaTringuloRetangulo = (a * b) / 2;

            double areaCirculo = 3.14159 * Math.Pow(c, 2);

            double areaTrapezio = ((a + b) * c )/ 2;

            double areaQuadrado = Math.Pow(b, 2);

            double areaRetangulo = a * c;


            Console.WriteLine($"a) Área do triangulo retângulo (base {a} e altura {c}: {areaTringuloRetangulo:F2}");
            Console.WriteLine($"b) Área do círculo (raio {c}): {areaCirculo:F2}");
            Console.WriteLine($"c) Área do trapézio (bases {a} e {b} e altura {c}: {areaTrapezio:F2}");
            Console.WriteLine($"d) Área do quadrado (lado {c}): {areaQuadrado:F2}");
            Console.WriteLine($"e) Área do retângulo (lados {a} e {b}: {areaRetangulo:F2}");


        }
    }
}
