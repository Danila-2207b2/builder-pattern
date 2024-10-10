using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace builder_pattern
{
    class ConcreteCollector
    {
        public Computer PC (Collector collector)
        {
            collector.CreateComputer();
            collector.SetCPU();
            collector.SetMotherboard();
            collector.SetRAM();
            collector.SetStorage();
            collector.SetGPU();
            return collector.Computer;
        }
    }
}
