using System;

class Program {
    static void Main() {
        int[][] jaggedMatrix = new int[3][];
        jaggedMatrix[0] = new int[] { 85, 90, 88 };
        jaggedMatrix[1] = new int[] { 78, 82 };
        jaggedMatrix[2] = new int[] { 91, 92, 89, 80 };


        Console.WriteLine($"{jaggedMatrix[0][0]} {jaggedMatrix[0][1]} {jaggedMatrix[0][2]}");
        Console.WriteLine($"{jaggedMatrix[1][0]} {jaggedMatrix[1][1]}");
        Console.WriteLine($"{jaggedMatrix[2][0]} {jaggedMatrix[2][1]} {jaggedMatrix[2][2]} {jaggedMatrix[2][3]}");
    }
}
