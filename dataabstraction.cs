﻿using System;
namespace Abstraction
{
    abstract class Shape
    {
        public abstract int area();
    }
    class Square : Shape
    {
        private int side;

        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.Write("Area of square:");
            return (side * side);

        }
    }
    class Gaurab
    {
        static void Main(string[] args)
        {
            Shape sh = new Square(4);
            double result = sh.area();
            Console.Write("{0}", result);
            Console.ReadLine();
        }
    }
}