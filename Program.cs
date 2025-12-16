

using System;




namespace App
{
    public class MainApp
    {
        static public bool RevversInt(int num)
        {
            int NewNum = num;
            int res = 0;
            while(NewNum>0)
            {
                res = res *10 + NewNum %10;
                NewNum /= 10;
            }
            if(res == num)
                return true;
            else
                return false;
        }
        static public void Main()
        {
            int num =-121;
            Console.WriteLine(RevversInt(num));

        }
    }
}
