using CMUcrs.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CMUcrs.Web.Models;

namespace CMUcrs.Models
{
    public class EnrollmentModel : BaseModel
    {
        public int Save(AssignCourse assignCourse)
        {
            Course course = UnitOfWork.GetEntityRepository<Course>().GetById(assignCourse.CourseID);

            if (course.Enrollments.Count < course.MaxCapacity)
            {
                Enrollment enrollment = new Enrollment();
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<AssignCourse, Enrollment>();
                });

                enrollment = Mapper.Map<AssignCourse, Enrollment>(assignCourse);
                UnitOfWork.GetEntityRepository<Enrollment>().InsertOrUpdate(enrollment);
                UnitOfWork.Commit();
                return 1;
            }
            else
                return 0;

        }

        public Student DeleteStudent(int id)
        {
            Enrollment enrollment = UnitOfWork.GetEntityRepository<Enrollment>().GetById(id);
            Student student = UnitOfWork.GetEntityRepository<Student>().GetById(enrollment.StudentId);
            UnitOfWork.GetEntityRepository<Enrollment>().Delete(enrollment);
            UnitOfWork.Commit();
            return student;
        }
    }
}