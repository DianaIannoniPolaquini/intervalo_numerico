using System;

namespace INTERVALO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            string entrada;

            Console.WriteLine("Entre com o valor: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int x);

            int cont1 = 0;
            int cont2 = 0;

            for (i = 0; i < x; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}ºvalor: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out n);


                if (n >= 10 && n <= 20)
                {
                    cont1++;
                }
                else
                {
                    cont2++;
                }
                
            }
            Console.WriteLine($"Dentro {cont1}.");
            Console.WriteLine($"Fora {cont2}.");
        }
    }
}
