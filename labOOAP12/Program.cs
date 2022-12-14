using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labOOAP12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position position1 = new Position("Начальник відділу", 20000);
            Position position2 = new Position("Головний інженер", 15000);
            Position position3 = new Position("Інженер-програміст", 30000);
            Position position4 = new Position("Системний адміністратор", 25000);

            WorkerController worker1 = new WorkerController(new Worker("Vitaliy", "Sereda", position1));
            WorkerController worker2 = new WorkerController(new Worker("Yuriy", "Kornelyuk", position2));
            WorkerController worker3 = new WorkerController(new Worker("Oleg", "Tuchovuch", position3));
            WorkerController worker4 = new WorkerController(new Worker("Pavlo", "Mavdruk", position4));

            worker1.Info();
            worker2.Info();
            worker3.Info();
            worker4.Info();
        }
    }
}
