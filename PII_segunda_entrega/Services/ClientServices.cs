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
    public class ClientServices
    {
        private IClientRepository _repository;
        public ClientServices()
        {
            _repository = new ClientRepostory();
        }
        public List<Client> GetAll()
        {
            return _repository.GetAll();
        }
        public bool SaveProduct(Client client)
        {
            return _repository.Save(client);
        }
    }
}
