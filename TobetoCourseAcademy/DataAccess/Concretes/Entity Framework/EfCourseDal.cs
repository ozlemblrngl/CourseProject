using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Entity_Framework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseAcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using(TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from c in context.Courses
                             join ct in context.Categories
                             on c.CategoryId equals ct.Id
                             join i in context.Instructors
                             on c.InstructorId equals i.InstructorId
                             select new CourseDetailDto
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 CategoryId = ct.Id,
                                 CategoryName = ct.Name,
                                 InstructorId = i.InstructorId,
                                 InstructorName = i.Name

                             };

                return result.ToList();
            }
        }

      

       
    }
}
