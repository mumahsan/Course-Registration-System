using CMUcrs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMUcrs.web.DAL
{
    public class SeedBaseData: System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var students = new List<Student>
            {
            new Student{StudentID="1",FirstName="Carson",LastName="Alexander"},
            new Student{StudentID="2",FirstName="Meredith",LastName="Alonso"},
            new Student{StudentID="3",FirstName="Arturo",LastName="Anand"},
            new Student{StudentID="4",FirstName="Gytis",LastName="Barzdukas"},
            new Student{StudentID="5",FirstName="Yan",LastName="Li"},
            new Student{StudentID="6",FirstName="Peggy",LastName="Justice"},
            new Student{StudentID="7",FirstName="Laura",LastName="Norman"},
            new Student{StudentID="8",FirstName="Nino",LastName="Olivetto"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID="1050",Title="Chemistry",Credits="3",},
            new Course{CourseID="4022",Title="Microeconomics",Credits="3",},
            new Course{CourseID="4041",Title="Macroeconomics",Credits="3",},
            new Course{CourseID="1045",Title="Calculus",Credits="4",},
            new Course{CourseID="3141",Title="Trigonometry",Credits="4",},
            new Course{CourseID="2021",Title="Composition",Credits="3",},
            new Course{CourseID="2042",Title="Literature",Credits="4",}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID="1",CourseID="1050"},
            new Enrollment{StudentID="1",CourseID="4022"},
            new Enrollment{StudentID="1",CourseID="4041"},
            new Enrollment{StudentID="2",CourseID="1045"},
            new Enrollment{StudentID="2",CourseID="3141"},
            new Enrollment{StudentID="2",CourseID="2021"},
            new Enrollment{StudentID="3",CourseID="1050"},
            new Enrollment{StudentID="4",CourseID="1050",},
            new Enrollment{StudentID="4",CourseID="4022"},
            new Enrollment{StudentID="5",CourseID="4041"},
            new Enrollment{StudentID="6",CourseID="1045"},
            new Enrollment{StudentID="7",CourseID="3141"},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}