using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.Entity_Framework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
 
        public void Add(Course course)
        {
            
        }

        public List<Course> GetByCourseId(int id)
        {
            return _courseDal.GetAll(c => c.Id == id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
