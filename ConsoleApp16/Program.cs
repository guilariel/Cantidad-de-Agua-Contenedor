using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxArea(height));
            Console.ReadLine();
        }

        public static int MaxArea(int[] height)
        {
            int inicio = 0;
            int final = height.Length - 1;
            int TotalMaximo = 0;

            while (inicio < final)
            {
                int total = Math.Min(height[inicio], height[final]) * (final - inicio);
                Console.WriteLine(total);

                if (total > TotalMaximo)
                {
                    TotalMaximo = total;
                }

                // Mover el puntero que tenga menor altura
                if (height[inicio] < height[final])
                {
                    inicio++;
                }
                else
                {
                    final--;
                }
            }

            return TotalMaximo;
        }
    }
}