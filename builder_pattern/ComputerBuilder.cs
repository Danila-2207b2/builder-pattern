using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace builder_pattern
{
    abstract class ComputerBuilder
    {
        public Computer Computer { get; private set; }
        public void CreateComputer()
        {
            Computer = new Computer();
        }
        public abstract void SetCPU();
        public abstract void SetMotherboard();

        public abstract void SetRAM();
        public abstract void SetStorage();
        public abstract void SetGPU();
    }
}
