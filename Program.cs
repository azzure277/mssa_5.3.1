namespace mssa_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            int n1 = 1;
            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            int n2 = 2;

            Console.WriteLine(CanPlaceFlowers(flowerbed1, n1)); // Output: True
            Console.WriteLine(CanPlaceFlowers(flowerbed2, n2)); // Output: False
        }

        static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool emptyPrev = (i == 0) || (flowerbed[i - 1] == 0);
                    bool emptyNext = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (emptyPrev && emptyNext)
                    {
                        flowerbed[i] = 1;
                        count++;
                        if (count >= n)
                            return true;
                    }
                }
            }
            return count >= n;
        }
    }
}
