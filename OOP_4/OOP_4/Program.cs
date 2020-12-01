using System;
using System.Collections.Generic;

namespace OOP_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Shape[] circles = new Shape[10];
            for(int i=0;i<10; i++)
            {
                circles[i] = new Circle(i * 10 +1);
            }
            List<Shape> squares = new List<Shape>();
            squares.Add(new Square(10));
            squares.Add(new Square(12.2));
            Queue<Shape> treeangles = new Queue<Shape>();
            treeangles.Enqueue(new Treeangle(2, 3, 4));
            ShapeAccumulator accumulator = new ShapeAccumulator();
            accumulator.add(treeangles.Dequeue());
            accumulator.addAll(circles);
            accumulator.addAll(squares);
            Console.WriteLine("Shape with max area is {0}, area = {1}\n", accumulator.getMaxAreaShape().GetType(), accumulator.getMaxAreaShape().calcArea());
            Console.WriteLine("Shape with min area is {0}, area = {1}\n", accumulator.getMinAreaShape().GetType(), accumulator.getMinAreaShape().calcArea());
            Console.WriteLine("Shape with max perimetr is {0}, perimetr = {1}\n", accumulator.getMaxPerimeterShape().GetType(), accumulator.getMaxPerimeterShape().calcPerimeter());
            Console.WriteLine("Shape with min perimetr is {0}, perimetr = {1}\n", accumulator.getMinPerimeterShape().GetType(), accumulator.getMinPerimeterShape().calcPerimeter());
            Console.WriteLine("Total area = {0}", accumulator.getTotalArea());
            Console.WriteLine("Total perimter = {0}", accumulator.getTotalPerimeter());
        }
    }
}
