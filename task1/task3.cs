using System;

class Program{    
    static void Main(){

        Console.Write("Enter the days: ");
        int days = int.Parse(Console.ReadLine());
        int remaining = days % 7;
        int weeks  = days / 7;
        Console.WriteLine($"{weeks} weeks and {remaining} days");
    }
}
