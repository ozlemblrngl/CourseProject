
using Business.Concretes;
using Entities.Concretes;
using System.ComponentModel;


Category category = new Category
{
    Id = 1,
    Name = "Programlama"
};

Instructor instructor1 = new Instructor
{
    Id = 1,
    Name = "Engin Demiroğ"
};

Instructor instructor2 = new Instructor
{
    Id = 2,
    Name = "Halit Enes Kalaycı"
};


Course course1 = new Course
{
    Id = 1,
    Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
    Category = category,
    Instructor = instructor1,
    Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Cs7lHNsJSCi1mkPzo8fT",
    Price = 0

};

Course course2 = new Course
{
    Id = 2,
    Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)",
    Category = category,
    Instructor = instructor2,
    Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr",
    Price = 0

};

Course course3 = new Course
{
    Id = 3,
    Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
    Category = category,
    Instructor = instructor1,
    Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh",
    Price = 0

};

Course course4 = new Course
{
    Id = 4,
    Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
    Category = category,
    Instructor = instructor1,
    Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh",
    Price = 0

};


Course course5 = new Course
{
    Id = 5,
    Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
    Category = category,
    Instructor = instructor1,
    Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh",
    Price = 0

};


Course course6 = new Course
{
    Id = 6,
    Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
    Category = category,
    Instructor = instructor1,
    Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
    ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh",
    Price = 0

};



CourseManager courseManager = new CourseManager();
courseManager.Add(course1);

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category);
Console.WriteLine(category.Name);




InstructorManager instructorManager = new InstructorManager();
instructorManager.Add(instructor1);

Console.WriteLine(course2.Instructor.Name);





