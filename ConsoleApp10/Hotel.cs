using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Hotel : IHotel
    {
        public string Nome { get; set; }
        public int QntQuartos { get; set; }
        public int QntQuartosOcu { get; set; }
    }
}
