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
    public class InstructorManager:IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        List<Instructor> IInstructorService.GetAll()
        {
            return _instructorDal.GetAll();
        }

        public List<Instructor> GetByInstructorId(int id)
        {
            return _instructorDal.GetAll(i => i.InstructorId == id);
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
