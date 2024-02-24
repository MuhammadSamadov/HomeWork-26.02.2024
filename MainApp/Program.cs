

using Domain.Models;
using Infrastructure.Services;

var st1=new Student();
st1.Id=1;
st1.FirstName="Muhammad";
st1.LastName="Samadov";
st1.BirthDate=new DateTime(2006,02,04);
st1.Address="101MKR";
var st2=new Student();
st2.Id=2;
st2.FirstName="Suannatullo";
st2.LastName="Chillaev";
st2.BirthDate=new DateTime(2004,09,24);
st2.Address="Profsoyuz";
var st3=new Student();
st3.Id=3;
st3.FirstName="Ibrohimov";
st3.LastName="Shamsullo";
st3.BirthDate=new DateTime(1983,07,13);
st3.Address="Yujniy";

var tech1 = new Teacher();
tech1.Id=1;
tech1.FirstName="Dovud";
tech1.LastName="Ishratov";
tech1.Position="English";
tech1.ExperienceAmount=5000;
var tech2 = new Teacher();
tech2.Id=2;
tech2.FirstName="Hamiddulo";
tech2.LastName="Barotov";
tech2.Position="Math";
tech2.ExperienceAmount=1000;
var tech3 = new Teacher();
tech3.Id=3;
tech3.FirstName="Mavlavi";
tech3.LastName="Kiromov";
tech3.Position="History";
tech3.ExperienceAmount=2700;

var course1 = new Course();
course1.Id=1;
course1.Title="C++";
course1.Description="Sports Programming";
course1.Fee=1000;
course1.HasDiscount=true;
var course2 = new Course();
course2.Id=2;
course2.Title="C#";
course2.Description="C# is the best course";
course2.Fee=1500;
course2.HasDiscount=false;
var course3 = new Course();
course3.Id=3;
course3.Title="JS";
course3.Description="Course of JavaScript";
course3.Fee=500;
course3.HasDiscount=false;

var post1 = new Post();
post1.Id=1;
post1.Title="MatchDay";
post1.Description="Champions League";
post1.VoleAmount=500;
post1.CreateId=new DateTime(2018,12,12);
var post2 = new Post();
post2.Id=2;
post2.Title="UFC";
post2.Description="Welterweight title fight";
post2.VoleAmount=1000;
post2.CreateId=new DateTime(2024,02,25);
var post3 = new Post();
post3.Id=3;
post3.Title="Travel";
post3.Description="Nature";
post3.VoleAmount=2000;
post3.CreateId=new DateTime(1985,08,31);
  

var stService = new StudentService();
stService.GetStudents();
stService.AddStudent(st1);
stService.AddStudent(st2);
stService.AddStudent(st3);
stService.UpdateStudent(st2);
stService.Delete(2);
System.Console.WriteLine("Students :");
System.Console.WriteLine("|||||||||||||||");
foreach (var item in stService.GetStudents())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.BirthDate);
    System.Console.WriteLine(item.Address);
    System.Console.WriteLine("----------------");
}

var trService = new TeacherService();
trService.GetTeachers();
trService.AddTeacher(tech1);
trService.AddTeacher(tech2);
trService.AddTeacher(tech3);
trService.UpdateTeacher(tech1);
trService.Delete(1);
System.Console.WriteLine("Teachers : ");
System.Console.WriteLine("|||||||||||||||");
foreach (var item in trService.GetTeachers())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Position);
    System.Console.WriteLine(item.ExperienceAmount);
    System.Console.WriteLine("----------------");
}

var crService =  new CourseService();
crService.GetCourses();
crService.AddCourse(course1);
crService.AddCourse(course2);
crService.AddCourse(course3);
crService.UpdateCourse(course2);
crService.Delete(1);
System.Console.WriteLine("Courses : ");
System.Console.WriteLine("|||||||||||||||");
foreach (var item in crService.GetCourses())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Fee);
    System.Console.WriteLine(item.HasDiscount);
    System.Console.WriteLine("----------------");
}

var psService= new PostService();
psService.GetPost();
psService.AddPost(post1);
psService.AddPost(post2);
psService.AddPost(post3);
psService.UpdatePost(post3);
psService.Delete(2); 
System.Console.WriteLine("Posts : ");
System.Console.WriteLine("|||||||||||||||");
foreach (var item in psService.GetPost())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.VoleAmount);
    System.Console.WriteLine(item.CreateId);
    System.Console.WriteLine("----------------");
}