using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labOOAP12
{
    public class Worker : Info
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }

        public Worker (string name, string surname, Position position)
        {
            Name = name; 
            Surname = surname;
            Position = position;
        }

        public void Info()
        {
           Console.WriteLine($"Worker: {Name} {Surname}");
           Position.Info();
           Console.WriteLine(" ");
        }
    }
}
