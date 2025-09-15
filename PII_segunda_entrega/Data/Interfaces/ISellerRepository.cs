using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Data.Interfaces
{
    public interface ISellerRepository
    {
        List<Seller> GetAll();
        Seller GetById(int id);
        bool Save(Seller seller);
        bool Delete(int id);
    }
}
