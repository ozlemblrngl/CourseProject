using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        public IDataResult<List<Course>> GetAll();
        public IDataResult<List<Course>> GetByCourseId(int id);
        public IDataResult<List<CourseDetailDto>> GetCourseDetails();
        public IResult Add(Course course);
        
    }
}
