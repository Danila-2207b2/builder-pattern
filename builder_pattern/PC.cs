using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern
{
    class CPU
    {
        public string Model { get; set; }
        public int Total_number_of_cores { get; set; }
        public int Maximum_number_of_threads { get; set; }
        public int Cache_size { get; set; }
    }

    class Motherboard
    {
        public string Model { get; set; }
        public string Form_factor { get; set; }
    }

    class RAM
    {
        public string Model { get; set; }
        public int RAM_capacity { get; set; }
    }

    class Storage
    {
        public string Model { get; set; }
        public int Storage_capacity { get; set; }
    }

    class GPU
    {
        public string Model { get; set; }
        public int VRAM {  get; set; }
    }
}
