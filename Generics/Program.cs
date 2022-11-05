using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{     // Streams  --> CS,IT, Elec
     // in each Stream --> no of studs
        public class Stud
        {
            public int Rollno { get; set; }
            public string Name { get; set; }
        }
        public class Stream
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Stud> Students = new List<Stud>();
        }
        public class Program
        {

            static void Main(string[] args)
            {
            List<Stream> streams = new List<Stream>() {
                    new Stream
                    {
                        Id=1,
                        Name="CS",
                        Students =
                        {
                            new Stud{Rollno=1,Name="Rosy"},
                            new Stud{Rollno=2,Name="Daisy"},
                            new Stud{Rollno=3,Name="Nancy"},
                            new Stud{Rollno=4,Name="Lucky"},
                            new Stud{Rollno=5,Name="John"},
                            new Stud{Rollno=6,Name="Andy"},
                        }
                    },
                     new Stream
                    {
                        Id=2,
                        Name="IT",
                        Students =
                        {
                            new Stud{Rollno=10,Name="Ajay"},
                            new Stud{Rollno=11,Name="Amol"},
                            new Stud{Rollno=12,Name="Neha"},
                       
                        }
                    }
            };

                foreach (Stream st in streams)
                {
                    Console.WriteLine($"{st.Id}  {st.Name}");
                    foreach (Stud s in st.Students)
                    {
                        Console.WriteLine($"\t {s.Rollno} {s.Name}");
                    }
                }
            }
        }
    

}
