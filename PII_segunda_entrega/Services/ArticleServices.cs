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
    public class ArticleServices
    {
        private IArticleRepository _Repository;

        public ArticleServices()
        {
            _Repository = new BookRepository();
        }

        public List<Book> GetAll()
        {
            List<Book> list = _Repository.GetAll();

            return list;
        }
    }
}
