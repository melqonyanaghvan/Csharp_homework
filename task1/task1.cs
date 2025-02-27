using System;

class Program{
    static void Main(){
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0){
            Console.WriteLine($"Number {number} is positive.");
        }else if (number < 0){
            Console.WriteLine($"Number {number} is negative.");
        }else{
            Console.WriteLine("Number is zero.");
        }
    }
}
