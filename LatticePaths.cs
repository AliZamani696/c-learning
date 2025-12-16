


using System;
using System.Numerics;


namespace Program
{
   class MyApp
    {
        public static void Main()
        {
            int grid1 = 20;
            int grid2 = 20;
            int TotalSteps = grid1 + grid2;
            BigInteger result = 1;
            for(int j=1;j <= grid1;j++){
                result *= (TotalSteps - j +1);
                result /= j;
            }
            Console.WriteLine(result);    
        }
    }
}
