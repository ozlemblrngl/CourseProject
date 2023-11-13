
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.Entity_Framework;
using Entities.Concretes;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.Name);
        }


    }
}


