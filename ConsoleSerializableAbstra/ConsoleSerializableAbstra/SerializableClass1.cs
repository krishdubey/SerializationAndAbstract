using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleSerializableAbstra
{ 
    [Serializable]
        public class Student1
        {
            public int rollno;
            public string name;
            public Student1(int rollno, string name)
            {
                this.rollno = rollno;
                this.name = name;
            }
        }
        public class SerializationClass2
        {
            static void Main(string[] args)
            {
                FileStream stream = new FileStream("g:\\UUU.txt", FileMode.OpenOrCreate);// writing single byte into file using open or create mode for read and write
                BinaryFormatter formatter = new BinaryFormatter();//BinaryFormatter is used to serialize an object (meaning it converts it to one long stream of 1s and 0s)

            Student1 s = new Student1(1001, "krishna");
                formatter.Serialize(stream, s);

                stream.Close();

                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }
    }

