using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    class ShapeAccumulator
    {
        private List<Shape> shapes;
        public ShapeAccumulator()
        {
            shapes = new List<Shape>();
        }
        public void add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void addAll(IEnumerable<Shape> items)
        {
            IEnumerator<Shape> iterator = items.GetEnumerator();
            while(iterator.MoveNext())
            {
                shapes.Add(iterator.Current);
            }
        }
        public Shape getMaxAreaShape() 
        {
            Shape ShapeWithMaxArea = null;
            for (int i = 0; i < shapes.Count; i++)
                if (ShapeWithMaxArea == null || ShapeWithMaxArea.calcArea() < shapes[i].calcArea())
                    ShapeWithMaxArea = shapes[i];
            return ShapeWithMaxArea;
        }
        public Shape getMinAreaShape() 
        {
            Shape ShapeWithMinArea = null;
            for (int i = 0; i < shapes.Count; i++)
                if (ShapeWithMinArea == null || ShapeWithMinArea.calcArea() > shapes[i].calcArea())
                    ShapeWithMinArea = shapes[i];
            return ShapeWithMinArea;
        }
        public Shape getMaxPerimeterShape() 
        {
            Shape ShapeWithMaxPerimeter = null;
            for (int i = 0; i < shapes.Count; i++)
                if (ShapeWithMaxPerimeter == null || ShapeWithMaxPerimeter.calcPerimeter() < shapes[i].calcPerimeter())
                    ShapeWithMaxPerimeter = shapes[i];
            return ShapeWithMaxPerimeter;
        }
        public Shape getMinPerimeterShape() 
        {
            Shape ShapeWithMinPerimeter = null;
            for (int i = 0; i < shapes.Count; i++)
                if (ShapeWithMinPerimeter == null || ShapeWithMinPerimeter.calcPerimeter() > shapes[i].calcPerimeter())
                    ShapeWithMinPerimeter = shapes[i];
            return ShapeWithMinPerimeter;
        }
        public double getTotalArea()
        {
            double totalArea = 0;
            for (int i = 0; i < shapes.Count; i++)
                totalArea += shapes[i].calcArea();
            return totalArea;
        }
        public double getTotalPerimeter() 
        {
            double totalPerimeter = 0;
            for (int i = 0; i < shapes.Count; i++)
                totalPerimeter += shapes[i].calcPerimeter();
            return totalPerimeter;
        }

    }
}
