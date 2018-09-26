using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleSerializableAbstra
{
    class DeserializableClass1
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\UUU.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();


            Student1 s1 = (Student1)formatter.Deserialize(stream);// method to deserialize to stream
            Console.WriteLine("Rollno:" + s1.rollno);
            Console.WriteLine("Name:" + s1.name);

            stream.Close();
            Console.ReadLine();
        }
    }
}
