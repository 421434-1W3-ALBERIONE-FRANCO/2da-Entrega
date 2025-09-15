using Actividad_practica_PII.Data.Interfaces;
using Actividad_practica_PII.Data.Utiliti;
using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Data
{
    public class ClientRepostory : IClientRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        public List<Client> GetAll()
        {
            List<Client> lst = new List<Client>();

            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_CLIENTES");
            if (dt == null || dt.Rows.Count == 0)
                return lst;

            foreach (DataRow row in dt.Rows)
            {
                Client c = new Client();
                c.Cod = (int)row["cod_cliente"];
                c.Name = (string)row["nom_cliente"];
                c.LastName = (string)row["ape_cliente"];
                c.street = (string)row["calle"];
                c.Number = Convert.ToInt32(row["altura"]);
                c.Neighborhood = (int)row["cod_barrio"];
                c.Tellphone = row["nro_tel"] == DBNull.Value ? 0 : Convert.ToInt32(row["nro_tel"]);
              
                lst.Add(c);
            }

            return lst;
        }

        //public List<Client> GetAll()
        //{
        //    List<Client> lst = new List<Client>();

        //    var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_CLIENTES");

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Client c = new Client();

        //        c.Cod = (int)row["cod_cliente"];
        //        c.Name = (string)row["nom_cliente"];
        //        c.LastName = (string)row["ape_cliente"];
        //        c.street = (string)row["calle"];
        //        c.Number = Convert.ToInt32(row["altura"]);
        //        c.Neighborhood = (int)row["cod_barrio"];
        //        c.Tellphone = row["nro_tel"] == DBNull.Value ? 0 : Convert.ToInt32(row["nro_tel"]);
        //        c.Email = row["e-mail"] == DBNull.Value ? "" : (string)row["e-mail"];

        //        lst.Add(c);
        //    }
        //    return lst;
        //}

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
