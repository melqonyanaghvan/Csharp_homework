using System;

class Program {
    static void Main() {
        int[,] matrix = { { 1,2,3 }, { 4,5,6 }, { 7,8,9 } };

        Console.WriteLine($"{matrix[0, 0]} {matrix[0, 1]} {matrix[0, 2]}");
        Console.WriteLine($"{matrix[1, 0]} {matrix[1, 1]} {matrix[1, 2]}");
        Console.WriteLine($"{matrix[2, 0]} {matrix[2, 1]} {matrix[2, 2]}");
    }
}
