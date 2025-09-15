using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Domain
{
    public class Invoice
    {
        public int Cod { get; set; }
        public DateTime date { get; set; }

        public Client Client { get; set; }

        public Seller Seller { get; set; }

        public List<DetailInvoice> DetailInvoices { get; set; }
    }
}
