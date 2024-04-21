using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık.DAL.Abstract
{
    public interface IPublisherDal
    {
        List<Publisher> GetAll();
        IPublisherDal GetById(int Id);
        void Add(Publisher publisher);
        void Update(Publisher publisher);

        void Delete(Publisher publisher);


    }
}
