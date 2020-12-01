using System;
using System.Collections.Generic;

namespace OOP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(10));
            shapes.Add(new Square(11));
            shapes.Add(new Rectangle(10, 10));
            //ShapeBinSerialazier.Serialize(shapes, "shapes.bin");
            shapes = ShapeBinSerialazier.Deserialize("shap.bin");
        }
    }
}
