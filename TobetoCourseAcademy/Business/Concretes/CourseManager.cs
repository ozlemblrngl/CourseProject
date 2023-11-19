using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.Entity_Framework;
using Entities.Concretes;
using Entities.DTOs;
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
 
       
        public IDataResult<List<Course>> GetByCourseId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == id));
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
        }


        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IResult Add(Course course)
        {
            if (course.Name.Length<2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }

            _courseDal.Add(course);
        return new SuccessResult(Messages.CourseAdded);
        }
    }
}
