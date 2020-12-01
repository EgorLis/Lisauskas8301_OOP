﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_5
{
    
    public interface Shape
    {
        public double calcArea();
        public double calcPerimeter();

    }

    [Serializable]
    public class Rectangle : Shape
    {
        private double lenght;

        private double width;

        public Rectangle(double len, double wd)
        {
            if (len <= 0 || wd <= 0)
                throw new ArgumentOutOfRangeException();
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

    }

    [Serializable]
    public class Square : Shape
    {
        private double lenght;
        
        public Square(double len)
        {
            if (len <= 0)
                throw new ArgumentOutOfRangeException();
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
    }

    [Serializable]
    public class Treeangle : Shape
    {
        private double side_1;

        private double side_2;

        private double side_3;
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
                throw new ArgumentOutOfRangeException();
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
    }

    [Serializable]
    public class Circle : Shape
    {
        private double radius;

        public Circle(double rad)
        {
            if (rad <= 0)
                throw new ArgumentOutOfRangeException();
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

    }

}
