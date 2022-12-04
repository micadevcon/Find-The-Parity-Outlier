using System;

namespace Find_The_Parity_Outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 2, 6, 8, -10, 3 };
            Console.WriteLine(Find(integers));
        }
        public static int Find(int[] integers)
        {
            int parityNumber;
            if (parityLine(integers))
                parityNumber = 1;
            else
                parityNumber = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == parityNumber)
                    return integers[i];   
            }
            return -1;

        }
        public static bool parityLine(int[] integers)
        {
            int length = 3;
            int parityNumbers = 0;
            for (int i = 0; i < length; i++)
            {
                if (integers[i]%2==0)
                    parityNumbers++;  
            }
            if (parityNumbers >= length-1)
                return true;
            else
                return false;
        }
    }
}