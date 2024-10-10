using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern
{
    class Computer
    {
        public CPU CPU { get; set; }
        public RAM RAM { get; set; }
        public Motherboard Motherboard { get; set; }
        public Storage Storage { get; set; }
        public GPU GPU { get; set; }

        public string Build()
        {
            StringBuilder sb = new StringBuilder();

            if (CPU != null)
            {
                sb.Append("CPU: " + 
                CPU.Model + ", " +
                CPU.Total_number_of_cores + " cores, " +
                CPU.Maximum_number_of_threads + " threads, " + 
                CPU.Cache_size + " Mb" + "\n");
            }

            if (Motherboard != null)
            {
                sb.Append("Motherboard: " +
                Motherboard.Model + ", form factor " +
                Motherboard.Form_factor + "\n");
            }

            if (RAM != null)
            {
                sb.Append("RAM: " +
                RAM.Model + ", " +
                RAM.RAM_capacity + " Gb" + "\n");
            }

            if (Storage != null)
            {
                sb.Append("Storage: " +
                Storage.Model + ", " +
                Storage.Storage_capacity + " Gb" + "\n");
            }

            if (GPU != null)
            {
                sb.Append("GPU: " +
                GPU.Model + ", " +
                GPU.VRAM + " Gb" + "\n");
            }

            return sb.ToString();
        }
    }
}
