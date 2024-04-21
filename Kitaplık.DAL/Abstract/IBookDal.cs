using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık.DAL.Abstract
{
    public interface IBookDal
    {
        List<Book> GetAll();
        IBookDal GetById(int Id);
        void Add(Book book);
        void Update(Book book);

        void Delete(Book book);
    }
}
