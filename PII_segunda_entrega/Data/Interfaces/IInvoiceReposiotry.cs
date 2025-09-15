using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Data.Interfaces
{
    public interface IInvoiceReposiotry
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        bool Save(Invoice invoice);
        bool Delete(int id);
    }
}
