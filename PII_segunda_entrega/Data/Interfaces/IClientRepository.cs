using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Data.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        bool Save(Client client);
        bool Delete(int id);
    }
}
