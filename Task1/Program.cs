﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        delegate float Operation(float x, float y);
        static void Main(string[] args)
        {

            Operation add = (a, b) => a + b;
            Operation subtract = (a, b) => a - b;
            Operation multiply = (a, b) => a * b;
            Operation divide = (a, b) => b == 0 ? 0 : a / b;


            Console.WriteLine("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter two numbers: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(subtract(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(multiply(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(divide(num1, num2));
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
