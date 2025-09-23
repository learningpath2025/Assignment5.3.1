using System.Numerics;
using static System.Reflection.Metadata.BlobBuilder;

namespace Assignment5._3._1
{
    internal class Program
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {               
                if (flowerbed[i] == 0)
                {
                    
                    bool leftIsEmpty = (i == 0 || flowerbed[i - 1] == 0);                   
                    bool rightIsEmpty = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);
                   
                    if (leftIsEmpty && rightIsEmpty)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
               
                if (n <= 0)
                {
                    return true;
                }
            }
           
            return n <= 0;
        }
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanPlaceFlowers(flowerbed, 1));
        }
    }
}
