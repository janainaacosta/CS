// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
// Para cada ponto escrever o quadrante a que ele pertence.
// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).


namespace exe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y: ");
            int y = int.Parse(Console.ReadLine());


            while (x != 0 && y != 0){
               
                if( x > 0 && y > 0)
                {
                    Console.WriteLine("Coordenadas pertencem ao quadrante 1");
                }
                else if( y > 0 && x < 0) 
                {
                    Console.WriteLine("Coordenadas pertencem ao quadrante 2");
                }
                else if ( x < 0 && y < 0)
                {
                    Console.WriteLine("Coordenadas pertencem ao quadrante 3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Coordenadas pertencem ao quadrante 4");
                }

                Console.WriteLine("Informe o valor de X: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de Y: ");
                y = int.Parse(Console.ReadLine());
            }

           
        }
    }
}
