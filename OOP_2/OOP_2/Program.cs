using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle_1 = new Rectangle(4, 5);
            Rectangle rectangle_2 = new Rectangle(1, 10);
            Circle circle_1 = new Circle(3);
            Circle circle_2 = new Circle(10);
            Square square_1 = new Square(6);
            Square square_2 = new Square(1);
            Treeangle treeangle_1 = new Treeangle(2, 2, 2);
            Treeangle treeangle_2 = new Treeangle(4, 6.5, 4);
            shapes.Add(rectangle_1);
            shapes.Add(rectangle_2);
            shapes.Add(circle_1);
            shapes.Add(circle_2);
            shapes.Add(square_1);
            shapes.Add(square_2);
            shapes.Add(treeangle_1);
            shapes.Add(treeangle_2);
            
            double sum_area = 0;
            Shape smallest_area = shapes[0];
            Shape smallest_perimetr = shapes[0];
            Shape biggest_area = shapes[0];
            Shape biggest_perimetr = shapes[0];
            for(int i=0; i<shapes.Count;++i)
            {
                sum_area += shapes[i].calcArea();
                if (shapes[i].calcArea() > biggest_area.calcArea())
                    biggest_area = shapes[i];
                if (shapes[i].calcArea() < smallest_area.calcArea())
                    smallest_area = shapes[i];
                if (shapes[i].calcPerimeter() > biggest_perimetr.calcPerimeter())
                    biggest_perimetr = shapes[i];
                if (shapes[i].calcPerimeter() < smallest_perimetr.calcPerimeter())
                    smallest_perimetr = shapes[i];
            }

            Console.WriteLine("sum of areas = {0}\n", sum_area);
            Console.WriteLine("{0} has smallest area and area = {1}\n", smallest_area.GetType(), smallest_area.calcArea() );
            Console.WriteLine("{0} has biggesr area and area = {1}\n", biggest_area.GetType(),biggest_area.calcArea());
            Console.WriteLine("{0} has smallest perimetr and perimetr = {1}\n", smallest_perimetr.GetType(),smallest_perimetr.calcPerimeter());
            Console.WriteLine("{0} has biggets perimetr and perimetr = {1}\n", biggest_perimetr.GetType(),biggest_perimetr.calcPerimeter());
        }
    }
}
