using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_6
{
    public static class ShapeBinSerialazier
    {

        public static void Serialize(List<Shape> shapes, string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, shapes);
                }
            }
            catch
            {
                throw new FileLoadException();
            }
            
        }

        public static List<Shape> Deserialize(string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                { 
                    List<Shape> DeserializedShapes = new List<Shape>();
                    if (fs.Length != 0)
                        DeserializedShapes = (List<Shape>)formatter.Deserialize(fs);
                    return DeserializedShapes;
                }
            }
            catch
            {
                throw new InvalidDataException();
            }
        }
    }
}
