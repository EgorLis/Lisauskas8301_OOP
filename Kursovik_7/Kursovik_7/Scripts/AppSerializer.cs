using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursovik_7
{
    class AppSerializer
    {
        public static void SerializeAud(List<Auditorium> auditories, string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, auditories);
                }
            }
            catch(FileLoadException)
            {
                throw;
            }

        }

        public static List<Auditorium> DeserializeAud(string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    List<Auditorium> DeserializedShapes = new List<Auditorium>();
                    if (fs.Length != 0)
                        DeserializedShapes = (List<Auditorium>)formatter.Deserialize(fs);
                    return DeserializedShapes;
                }
            }
            catch (FileLoadException)
            {
                throw;
            }
        }

        public static void SerializeTeach(List<Teacher> teachers, string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, teachers);
                }
            }
            catch (FileLoadException)
            {
                throw;
            }

        }

        public static List<Teacher> DeserializeTeach(string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    List<Teacher> DeserializedShapes = new List<Teacher>();
                    if (fs.Length != 0)
                        DeserializedShapes = (List<Teacher>)formatter.Deserialize(fs);
                    return DeserializedShapes;
                }
            }
            catch(FileLoadException)
            {
                throw;
            }
        }
    }
}
