using System;

class Program
{
    static void Main()
    {
        Circle c = new Circle();
        c.radius = 5;
        Console.WriteLine("Circle Area: " + c.getArea());

        Rectangle r = new Rectangle();
        r.length = 4;
        r.width = 3;
        Console.WriteLine("Rectangle Area: " + r.getArea());

        Square s = new Square();
        s.side = 6;
        Console.WriteLine("Square Area: " + s.getArea());
    }

    interface Shape
    {
        double getArea();
    }

    class Circle : Shape
    {
        public double radius;

        public double getArea()
        {
            return 3.14 * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        public double length;
        public double width;

        public double getArea()
        {
            return length * width;
        }
    }


    class Square : Shape
    {
        public double side;

        public double getArea()
        {
            return side * side;
        }
    }
}