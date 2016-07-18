using AutoMapper;
using CMUcrs.ViewModel;
using CMUcrs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace CMUcrs.Models
{
    public class StudentModel : BaseModel
    {
        public List<StudentViewModel> GetStudentList()
        {
            List<StudentViewModel> studentViewModel = new List<StudentViewModel>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Student, StudentViewModel>();
            });
            List<Student> students = UnitOfWork.GetEntityRepository<Student>().GetAll().ToList();
            return Mapper.Map<List<Student>, List<StudentViewModel>>(students);
        }

        public IEnumerable ListOfStudents()
        {
            List<Student> students = UnitOfWork.GetEntityRepository<Student>().GetAll().ToList();
            return students;
        }

        public Student GetStudent(int id)
        {
            Student student = UnitOfWork.GetEntityRepository<Student>().GetById(id);
            return student;
        }

        public StudentViewModel GetStudentViewModel(int id)
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            Student student = UnitOfWork.GetEntityRepository<Student>().GetById(id);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Student, StudentViewModel>();
            });
            studentViewModel = Mapper.Map<Student, StudentViewModel>(student);

            

            return studentViewModel;
        }
    }
}