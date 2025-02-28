using System;

class Program {
    static void Main() {
        Console.Write("enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("enter k bite: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("chose the operation, set(1) or clear(other number): ");
        int operation = int.Parse(Console.ReadLine());

        int result;

        if (operation == 1) {
            result = number | (1 << k);
        }else{
            result = number & ~(1 << k); 
        }
        Console.WriteLine($"result: {result}");
    }
}
