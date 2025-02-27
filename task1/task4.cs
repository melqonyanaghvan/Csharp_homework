using System;

class Program{    
    static void Main(){

        int[] triangle = new int[3];

        Console.Write("enter triangle sides: ");
        
        triangle[0] = int.Parse(Console.ReadLine());
        triangle[1] = int.Parse(Console.ReadLine());
        triangle[2] = int.Parse(Console.ReadLine());

        if(triangle[0] == triangle[1] && triangle[1] == triangle[2]){
            Console.WriteLine("triangle is Equilateral");
        }else if(triangle[0] == triangle[1] || triangle[0] == triangle[2] || triangle[1] == triangle[2]){
            Console.WriteLine("triangle is Isosceles");
        }else{
            Console.WriteLine("triangle is Scalene");
        }
    }
}
