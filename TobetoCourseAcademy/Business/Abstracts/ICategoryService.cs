using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public List<Category> GetByCategoryId(int id);

        public void Add();
    }
}
