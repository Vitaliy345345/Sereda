using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labOOAP12
{
    internal class WorkerController : Info
    {
        public Worker Worker { get; set; }

        public WorkerController (Worker worker) {  Worker = worker; }

        public void Info()
        {
            Worker.Info();
        }
    }
}
