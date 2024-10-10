using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace builder_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollector concrete_collector = new ConcreteCollector();
            Collector collector = new ConcreteComputerBuilder();
            Computer comp = concrete_collector.PC(collector);
            Console.WriteLine(comp.Build());

            Console.Read();
        }
    }
}
