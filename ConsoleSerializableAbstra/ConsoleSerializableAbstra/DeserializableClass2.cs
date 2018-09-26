using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleSerializableAbstra
{
    class DeserializableClass2
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\bbb.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();


            EmployeeClass1 s1 = (EmployeeClass1)formatter.Deserialize(stream);
            Console.WriteLine("Eno:" + s1[0]);
            Console.WriteLine("Ename:" + s1[1]);
            Console.WriteLine("Job:" + s1[2]);
            Console.WriteLine("Salary:" + s1[3]);
            Console.WriteLine("Dname:" + s1[4]);
            Console.WriteLine("Location:" + s1[5]);

            s1[2] = "Sr.Manager";
            s1[3] = 2500000.00;

            Console.WriteLine("\nModified Employee");

            Console.WriteLine("Eno:" + s1[0]);
            Console.WriteLine("Ename:" + s1[1]);
            Console.WriteLine("Job:" + s1[2]);
            Console.WriteLine("Salary:" + s1[3]);
            Console.WriteLine("Dname:" + s1[4]);
            Console.WriteLine("Location:" + s1[5]);

            stream.Close();
            Console.ReadLine();
        }
    }
}
