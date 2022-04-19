using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int basea;
        int baseb;
        int height;
        int area;

        Console.WriteLine("Please enter the both bases and height.");
        Console.WriteLine("");

        Console.Write("Base A: ");
        basea = Convert.ToInt32(Console.ReadLine());
        Console.Write("Base B: ");
        baseb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height: ");
        height = Convert.ToInt32(Console.ReadLine());
        area = ((basea + baseb) / 2) * height;

        Console.WriteLine("");
        Console.WriteLine("Area: " + area + "cm²");

        Console.WriteLine("\nDone.");
    }
}