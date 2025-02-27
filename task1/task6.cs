using System;

class Program
{
    static void Main()
    {
       Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in meters: ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        if (bmi < 18.5){
            Console.WriteLine($"BMI is {bmi} - Underweight");
        }else if (bmi >= 18.5 && bmi <= 24.9) {
            Console.WriteLine($"BMI is {bmi} - Normal weight");
        }else if (bmi >= 25 && bmi <= 29.9){
            Console.WriteLine($"BMI is {bmi} - Overweight");            
        }else{
            Console.WriteLine($"BMI: {bmi} - Obese");
        }
        
    }
}
