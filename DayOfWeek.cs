// See https://aka.ms/new-console-template for more information



using System;



public enum dayOfWeek:byte{
    Sunday,      // 0
    Monday,      // 1
    Tuesday,     // 2
    Wednesday,   // 3
    Thursday,    // 4
    Friday,      // 5
    Saturday    // 6 
}


class App{
    static void Main(){
        dayOfWeek today = dayOfWeek.Monday;
        dayOfWeek intday = (dayOfWeek)5;
        Console.WriteLine(intday);
    }
}
