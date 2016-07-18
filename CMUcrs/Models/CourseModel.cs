using AutoMapper;
using CMUcrs.ViewModel;
using CMUcrs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMUcrs.Models
{
    public class CourseModel : BaseModel
    {
        internal object GetCourseList()
        {
            List<CourseViewModel> studentViewModel = new List<CourseViewModel>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Course, CourseViewModel>();
            });
            List<Course> courses = UnitOfWork.GetEntityRepository<Course>().GetAll().ToList();
            return Mapper.Map<List<Course>, List<CourseViewModel>>(courses);
        }

        public List<Course> ListOfCourses()
        {
            List<Course> courses = UnitOfWork.GetEntityRepository<Course>().GetAll().ToList();
            return courses;
        }
    }
}