
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.Entity_Framework;
using Entities.Concretes;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
         CategoryTest();

        // CourseTest();

    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.Name);
        }
    }

    private static void CourseTest()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.Name);
        }
    }
}


