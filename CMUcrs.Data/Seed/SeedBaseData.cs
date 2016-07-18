using CMUcrs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace CMUcrs.Data.Seed
{
    class SeedBaseData : ISeed
    {
        public void Seed(DatabaseContext context)
        {
            var students = new List<Student>
            {
                new Student{StudentCode="100000", FirstName="Trista", LastName="Dollard"},
                new Student{StudentCode="100001", FirstName="Lilliana", LastName="Santigo"},
                new Student{StudentCode="100002", FirstName="Shelly", LastName="Steve"},
                new Student{StudentCode="100003", FirstName="Kasie", LastName="Mcsorley"},
                new Student{StudentCode="100004", FirstName="Tenisha", LastName="Kelton"},
                new Student{StudentCode="100005", FirstName="Rickie", LastName="Tesch"},
                new Student{StudentCode="100006", FirstName="Bennett", LastName="Lao"},
                new Student{StudentCode="100007", FirstName="Mercedez", LastName="Douse"},
                new Student{StudentCode="100008", FirstName="Anisa", LastName="Laney"},
                new Student{StudentCode="100009", FirstName="Oleta", LastName="Bosley"},
                new Student{StudentCode="100010", FirstName="Takisha", LastName="Poston"},
                new Student{StudentCode="100011", FirstName="Theressa", LastName="Alejos"},
                new Student{StudentCode="100012", FirstName="Yasmine", LastName="Storm"},
                new Student{StudentCode="100013", FirstName="Consuela", LastName="Loya"},
                new Student{StudentCode="100014", FirstName="Kassie", LastName="Lasorsa"},
                new Student{StudentCode="100015", FirstName="Filomena", LastName="Montero"},
                new Student{StudentCode="100016", FirstName="Leana", LastName="Crippen"},
                new Student{StudentCode="100017", FirstName="Oliver", LastName="Word"},
                new Student{StudentCode="100018", FirstName="Monika", LastName="Suzuki"},
                new Student{StudentCode="100019", FirstName="Roosevelt", LastName="Huddle"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseCode="ANT171",Title="Human Origins: Introduction to Physical Anthropology",Credits="3", Decription="Introduction to human and primate evolution, and the origin of human hereditary variations. (University Program Group II-A: Descriptive Sciences)", MaxCapacity=5},
                new Course{CourseCode="ANT202",Title="Anthropology of Gender", Credits="3", Decription="Examination of gender across cultures and through time through the lens of anthropology",MaxCapacity=4},
                new Course{CourseCode="ANT344",Title="Michigan Archaeology",Credits="3",Decription="Michigan archaeology from the first peopling of the area to historic times.  Changing adaptive patterns examined in the context of the Great Lakes region and North America generally. Recommended:  ANT 174 or 175.", MaxCapacity=8},
                new Course{CourseCode="ART533",Title="Advanced Painting Studio",Credits="4",Decription="An individualized studio experience for the advanced student of painting leading to artistic achievement and professional development. Prerequisite:  ART 430.", MaxCapacity=7},
                new Course{CourseCode="ASL402",Title="American Sign Language Level VI",Credits="4",Decription="Advanced conversational American Sign Language.  Continued development of advanced-level receptive and expressive skills.  Continued consideration of Deaf Culture and ASL linguistics. Prerequisites:  ASL 100, ASL 401.", MaxCapacity=5},
                new Course{CourseCode="ATR441",Title="Pre-Internship and Professional Development",Credits="3",Decription="Preparation for the AT internship experience; Application process for AT certification and state credentials; Final preparation for the prospective entry-level AT professional. Prerequisites: ATR 390, 430. Co-requisite: ATR 478.", MaxCapacity=8},
                new Course{CourseCode="BIO110",Title="Concepts of Biology",Credits="4",Decription="Fundamental concepts of biology including the chemical basis of life, cell structure and function, molecular and transmission genetics, evolution and ecology. May be applied towards fulfilling the requirements of any Biology major or minor. Students may only earn credit in one of the following: BIO 101, BIO 105, or BIO 110. Satisfies University Program Group II laboratory requirement. Recommended: High school chemistry or CHM 120 and 127 or 131 or 161. (University Program Group II-A: Descriptive Sciences)", MaxCapacity=4}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            //var enrollments = new List<Enrollment>
            //{
                //new Enrollment{StudentCode="1",CourseCode="1050"},
                //new Enrollment{StudentCode="1",CourseCode="4022"},
                //new Enrollment{StudentCode="1",CourseCode="4041"},
                //new Enrollment{StudentCode="2",CourseCode="1045"},
                //new Enrollment{StudentCode="2",CourseCode="3141"},
                //new Enrollment{StudentCode="2",CourseCode="2021"},
                //new Enrollment{StudentCode="3",CourseCode="1050"},
                //new Enrollment{StudentCode="4",CourseCode="1050",},
                //new Enrollment{StudentCode="4",CourseCode="4022"},
                //new Enrollment{StudentCode="5",CourseCode="4041"},
                //new Enrollment{StudentCode="6",CourseCode="1045"},
                //new Enrollment{StudentCode="7",CourseCode="3141"},
            //};
            //enrollments.ForEach(s => context.Enrollments.Add(s));
            //context.SaveChanges();
        }
    }
}
