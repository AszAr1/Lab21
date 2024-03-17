﻿namespace Lab21;

class Program {
    static double a;
    static double b;
    
    public static void Main(string[] args) {
        EnterA();
        EnterB();
    } 

    public static void EnterA() {
        Console.WriteLine("Enter a: ");
        string str_a = Console.ReadLine()!;
        while (!double.TryParse(str_a, out a)) {
            Console.WriteLine("Try again");
            str_a = Console.ReadLine()!;
        }
    }
    public static void EnterB() {
        Console.WriteLine("Enter b: ");
        string str_b = Console.ReadLine()!;
        while (!double.TryParse(str_b, out b)) {
            Console.WriteLine("Try again");
            str_b = Console.ReadLine()!;
        }
    }
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;

}