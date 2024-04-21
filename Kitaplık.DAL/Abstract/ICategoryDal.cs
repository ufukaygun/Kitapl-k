using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık.DAL.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        ICategoryDal GetById(int Id);
        void Add(Category category);
        void Update(Category category);

        void Delete(Category category);
    }
}
