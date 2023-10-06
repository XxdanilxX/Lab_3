using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Firma
    {
        public List<Personal> Employees { get; set; }

        public Firma()
        {
            Employees = new List<Personal>();
        }
    }
}
