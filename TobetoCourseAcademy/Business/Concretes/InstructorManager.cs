using Business.Abstracts;
using DataAccess.Concretes;
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
        public void Add(Instructor instructor)
        {
            
        }

        public List<Instructor> GetByInstructorId(int id)
        {
            return null;
        }

        List<Instructor> IInstructorService.GetAll()
        {
            return null;
        }
    }
}
