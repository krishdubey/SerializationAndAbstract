using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleSerializableAbstra
{       [Serializable]
      public class EmployeeClass1
        {
            int Eno;
            double Salary;
            string Ename, Job, Dname, Location;

            public EmployeeClass1(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
            {
                this.Eno = Eno;
                this.Ename = Ename;
                this.Job = Job;
                this.Salary = Salary;
                this.Dname = Dname;
                this.Location = Location;
            }

            public object this[int index]
            {
                get
                {
                    if (index == 0)
                        return Eno;
                    else if (index == 1)
                        return Ename;
                    else if (index == 2)
                        return Job;
                    else if (index == 3)
                        return Salary;
                    else if (index == 4)
                        return Dname;
                    else if (index == 5)
                        return Location;
                    return null;
                }
                set
                {
                    if (index == 0)
                        Eno = (int)value;
                    else if (index == 1)
                        Ename = (string)value;
                    else if (index == 2)
                        Job = (string)value;
                    else if (index == 3)
                        Salary = (double)value;
                    else if (index == 4)
                        Dname = (string)value;
                    else if (index == 5)
                        Location = (string)value;
                }
            }
        }

        public class SerializationClass3
        {
            static void Main(string[] args)
            {
                FileStream stream = new FileStream("g:\\bbb.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                EmployeeClass1 e = new EmployeeClass1(1001, "krishna", "SoftwareDeveloper", 250000.00, "Software", "Banglore");
                formatter.Serialize(stream, e);

                stream.Close();

                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }
    }

