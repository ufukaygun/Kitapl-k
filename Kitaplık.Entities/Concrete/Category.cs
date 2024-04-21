using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık.Entities.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
