using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        public List<Course> GetAll();
        public List<Course> GetByCourseId(int id);
    }
}
