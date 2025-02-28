using System;

class Program {
    static void Main() {
        Console.Write("enter the string: ");
        string input = Console.ReadLine();

        Console.Write("enter the char: ");
        char character = char.Parse(Console.ReadLine());

        if (input[0] == character){
            Console.WriteLine($"'{character}' is the first char");
        }else { 
            Console.WriteLine($"'{character}' is not the first char");
        }

        if (input[^1] == character){
            Console.WriteLine($"'{character}' is the last char");
        }else {
            Console.WriteLine($"'{character}' is not the last char");
        }
    }
}
