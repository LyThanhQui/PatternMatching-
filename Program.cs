﻿using System;

namespace PatternMatching
{
    //example 1
    //Pattern Matching in C# with “is” expression:
    //Pattern Matching Before C# 7:
    public class Shape
    {
        public const float PI = 3.14f;
    }
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle square = new Rectangle(10, 10);
            DisplayArea(square);
            Circle circle = new Circle(10);
            DisplayArea(circle);
            Rectangle rectangle = new Rectangle(10, 5);
            DisplayArea(rectangle);
            Triangle triangle = new Triangle(10, 5);
            DisplayArea(triangle);
            Console.ReadKey();
        }
        /*public static void DisplayArea(Shape shape)
        {
            if (shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            }
            else if (shape is Rectangle)
            {
                Rectangle r = (Rectangle)shape;
                Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            }
            else if (shape is Triangle)
            {
                Triangle t = (Triangle)shape;
                Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }*/
        //in C# 7
        /*public static void DisplayArea(Shape shape)
        {
            if (shape is Circle c)
            {
                Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            }
            else if (shape is Triangle t)
            {
                Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }*/
        //Pattern Matching using the “switch” statement in C#:
        /*public static void DisplayArea(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
                    break;
               case Triangle t:
                   Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                    
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }*/

        //Case Expressions using When clauses in C#:
        public static void DisplayArea(Shape shape)
        {
            switch (shape)
            {
                case Rectangle r when r.Length == r.Height:
                    Console.WriteLine("Area of Sqaure is : " + r.Length * r.Height);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }

    }
}





