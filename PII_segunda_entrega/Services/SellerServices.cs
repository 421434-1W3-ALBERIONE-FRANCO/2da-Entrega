using Actividad_practica_PII.Data;
using Actividad_practica_PII.Data.Interfaces;
using Actividad_practica_PII.Domain;
using Actividad_practica_PIIin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Services
{
    public class SellerServices
    {
        private ISellerRepository _repository;
        public SellerServices()
        {
            _repository = new SellerRepository ();
        }
        public List<Seller> GetAll()
        {
            return _repository.GetAll();
        }
        public bool SaveProduct(Seller seller)
        {
            return _repository.Save(seller);
        }
    }
}
