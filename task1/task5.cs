using System;

class Program{
    static void Main(){

        Console.Write("enter a character: ");   
        char character = Console.ReadKey().KeyChar;

        if(char.IsUpper(character)){
            Console.WriteLine("\nThe character is uppercase.");
        }else if(char.IsLower(character)){
            Console.WriteLine("\nThe character is lowercase.");
        }else{
            Console.WriteLine("\nThe character is neither uppercase nor lowercase.");
        }
    }
}
