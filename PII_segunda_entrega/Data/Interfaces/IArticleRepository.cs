using Actividad_practica_PII.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_practica_PII.Data.Interfaces
{
    public interface IArticleRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        bool Save(Book article);
        bool Delete(int id);
    }
}
