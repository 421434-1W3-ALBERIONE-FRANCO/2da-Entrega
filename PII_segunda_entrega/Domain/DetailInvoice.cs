using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Domain
{
    public class DetailInvoice
    {
        public Book Article { get; set; }
        public int UnitPrice { get; set; }
        public int Count { get; set; }

    }
}
