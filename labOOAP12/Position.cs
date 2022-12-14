using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labOOAP12
{
    public class Position : Info
    {
        public string PositionName { get; set; }
        public int Salary { get; set; }

        public Position(string positionName, int salary)
        {
            PositionName = positionName;
            Salary = salary;
        }

        public void Info()
        {
            Console.WriteLine($"Position: {PositionName}, salary: {Salary}");
        }
    }
}
