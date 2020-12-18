using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_6
{
    public interface Shape
    {
        double calcArea();
        double calcPerimeter();

    }

    [Serializable]
    public class Rectangle : Shape
    {
        public double lenght { get; }

        public double width { get; }

        public Rectangle(double len, double wd)
        {
            if (len <= 0 || wd <= 0)
                throw new ArgumentOutOfRangeException("Length or width less or equal 0");
            this.lenght = len;
            this.width = wd;
        }
        public double calcArea()
        {
            return lenght * width;
        }

        public double calcPerimeter()
        {
            return 2 * lenght + 2 * width;
        }

        public override string ToString()
        {
            return "Rectangle (" + lenght.ToString() + " ; " + width.ToString() + ")";
        }

    }

    [Serializable]
    public class Square : Shape
    {
        public double lenght { get; }

        public Square(double len)
        {
            if (len <= 0)
                throw new ArgumentOutOfRangeException("Length less or equal 0");
            this.lenght = len;

        }
        public double calcArea()
        {
            return lenght * lenght;
        }
        public double calcPerimeter()
        {
            return 4 * lenght;
        }

        public override string ToString()
        {
            return "Square (" + this.lenght.ToString() +")";
        }
    }

    [Serializable]
    public class Treeangle : Shape
    {
        public double side_1 { get; }

        public double side_2 { get; }

        public double side_3 { get; }
        public Treeangle(double side1, double side2, double side3)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side_3 > side_1
                 && side1 > 0 && side2 > 0 && side3 > 0)
            {
                side_1 = side1;
                side_2 = side2;
                side_3 = side3;
            }
            else
                throw new ArgumentOutOfRangeException("This treeanlge cannot be created, 2 sides must be larger than third side");
        }

        public double calcArea()
        {
            double p = (side_1 + side_2 + side_3) / 2;
            return Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
        }

        public double calcPerimeter()
        {
            return side_1 + side_2 + side_3;
        }

        public override string ToString()
        {
            return "Treeangle (" + side_1.ToString() + " ; " + side_2.ToString() + " ; " + side_3.ToString() + ")";
        }
    }

    [Serializable]
    public class Circle : Shape
    {
        public double radius { get; }

        public Circle(double rad)
        {
            if (rad <= 0)
                throw new ArgumentOutOfRangeException("Radius less or equal 0");
            this.radius = rad;
        }
        public double calcArea()
        {
            return Math.PI * radius * radius;
        }

        public double calcPerimeter()
        {
            return Math.PI * radius * 2;
        }

        public override string ToString()
        {
            return "Circle (" + radius.ToString() + ")";
        }
    }
}
