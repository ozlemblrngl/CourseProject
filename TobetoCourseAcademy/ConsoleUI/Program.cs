
using Business.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.Entity_Framework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        CourseManager courseManager = new CourseManager(new EfCourseDal());
        var result= courseManager.GetAll();

        if(result.IsSuccess)
        {
            foreach(var course in result.Data) 
            {
                Console.WriteLine(course.Name);
            }

            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }

        //CourseDetailDtoTest();

        // CategoryTest();

        // CourseTest();

    }

    //private static void CourseDetailDtoTest()
    //{
    //    CourseManager courseManager = new CourseManager(new EfCourseDal());
    //    var result = courseManager.GetCourseDetails();

    //    foreach (var course in result)
    //    {
    //        Console.WriteLine("Kurs adı: " + course.Name + "/ Kategori adı: " + course.CategoryName + "/ Eğitmen adı: " + course.InstructorName);
    //    }
    //}

    //private static void CategoryTest()
    //{
    //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    //    foreach (var category in categoryManager.GetAll())
    //    {
    //        Console.WriteLine(category.Name);
    //    }
    //}

    //private static void CourseTest()
    //{
    //    CourseManager courseManager = new CourseManager(new EfCourseDal());
    //    foreach (var course in courseManager.GetAll())
    //    {
    //        Console.WriteLine(course.Name);
    //    }
    //}
}


