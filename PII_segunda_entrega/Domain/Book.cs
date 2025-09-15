using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Domain
{
    public class Book
    {
        public int  Cod { get; set; }
        public string  Description { get; set; }
        public int  MinStock { get; set; }
        public int  Stock { get; set; }
        public double  UnitPrice { get; set; }
        public string  Observation { get; set; }

        public override string ToString()
        {
            return $"Id: {Cod} | Description: {Description} | Price: {UnitPrice} | Stock: {Stock}";
        }
    }
}
