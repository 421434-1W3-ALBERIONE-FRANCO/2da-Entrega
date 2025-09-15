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
    public class BookRepository : IArticleRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        //public List<Client> GetAll()
        //{
        //    List<Client> lst = new List<Client>();

        //    var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_CLIENTES");
        //    if (dt == null)
        //    {
        //        // Puedes registrar el error o lanzar una excepción más descriptiva si lo prefieres
        //        return lst;
        //    }

        //    foreach (var (row, c) in from DataRow row in dt.Rows
        //                             let c = new Client()
        //                             select (row, c))
        //    {
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

        public List<Book> GetAll()
        {
            List<Book> lst = new List<Book>();

            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_ARTICULOS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Book p = new Book();
                    p.Cod = (int)row["cod_articulo"];
                    p.Description = (string)row["descripcion"];
                    p.MinStock = row["stock_minimo"] == DBNull.Value ? 0 : Convert.ToInt32(row["stock_minimo"]); ;
                    p.Stock = Convert.ToInt32(row["stock"]);
                    p.UnitPrice = Convert.ToDouble(row["pre_unitario"]);
                    p.Observation = row["observaciones"] == DBNull.Value ? "" : (string)row["observaciones"];
                    lst.Add(p);
                }
                return lst;
            }
            else
            {
                return lst;
            }
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Book article)
        {
            throw new NotImplementedException();
        }

    }
}
