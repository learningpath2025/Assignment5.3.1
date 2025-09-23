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
                
                if (flowerbed[i] == 0) // Check if the current plot is empty
                {
                    
                    bool leftIsEmpty = (i == 0 || flowerbed[i - 1] == 0); // Check left neighbor (or if it's the first plot)
                    
                    bool rightIsEmpty = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0); // Check right neighbor (or if it's the last plot)

                    
                    if (leftIsEmpty && rightIsEmpty) // If both neighbors are empty (or out of bounds)
                    {
                        flowerbed[i] = 1; // Plant the flower
                        n--; // Decrement the count of flowers to plant
                    }
                }

                
                if (n <= 0) // If we have planted enough flowers, return true
                {
                    return true;
                }
            }

            
            return n <= 0; // If the loop finishes and we still need to plant more flowers, return false
        }
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanPlaceFlowers(flowerbed, 1));
        }
    }
}
