

using System;


Console.WriteLine("i select my number ");
Random PCnum = new Random();
int myNum = PCnum.Next(50);
bool running = true;
uint RemainingOpportunity = 5;
while (running)
{
    Console.WriteLine("whats your guess??");
    var input = Console.ReadLine();
    int j = int.Parse(input);
    if (j > myNum &&  RemainingOpportunity != 0)
    {

        Console.WriteLine($"your guess is large RemainingOpportunity: {RemainingOpportunity}");
        RemainingOpportunity--;
    }
    else if( j < myNum && RemainingOpportunity !=0)
    {
        Console.WriteLine($"my number is large RemainingOpportunity: {RemainingOpportunity}");
        RemainingOpportunity--;
    }
    else if(j == myNum)
    {
        Console.WriteLine($"you win myNum is {myNum} your guess{j} ");
        running = false;
    }
    else if(RemainingOpportunity ==0)
    {
        Console.WriteLine("your opportuntity is end! you lose");
        running = false;
    }
}
