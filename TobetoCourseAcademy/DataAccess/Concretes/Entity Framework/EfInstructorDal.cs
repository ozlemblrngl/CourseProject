using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Entity_Framework
{
    public class EfInstructorDal : IInstructorDal
    {
        
     
        public void Add(Instructor entity)
        {
            throw new NotImplementedException();
        }

      

        public void Delete(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
