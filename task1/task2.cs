using System;

class Program{
    static void Main(){
        Console.Write("enter the year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
            Console.WriteLine($"Year {year} is a leap year");
        }else{
            Console.WriteLine($"Year {year} is not a leap year");
        }
    }
}
