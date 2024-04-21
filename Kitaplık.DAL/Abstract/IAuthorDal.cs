using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık.DAL.Abstract
{
    public interface IAuthorDal
    {
        List<Author> GetAll();
        IAuthorDal GetById(int Id);
        void Add(Author author);
        void Update(Author author);

        void Delete(Author author);
    }
}
