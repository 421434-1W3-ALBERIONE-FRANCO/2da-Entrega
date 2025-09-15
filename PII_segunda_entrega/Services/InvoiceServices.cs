using Actividad_practica_PII.Data;
using Actividad_practica_PII.Data.Interfaces;
using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Services
{
    public class InvoiceServices
    {
        private IInvoiceReposiotry _repository;
        public InvoiceServices()
        {
            _repository = new InvoiceRepository();
        }
        public List<Invoice> GetAll()
        {
            return _repository.GetAll();
        }
        public bool Save(Invoice invoice)
        {
            return _repository.Save(invoice);
        }
    }
}
