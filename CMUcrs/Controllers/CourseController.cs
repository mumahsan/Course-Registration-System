using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMUcrs.Models;
using CMUcrs.ViewModel;

namespace CMUcrs.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Course
        public ActionResult Index()
        {
            //return View(db.Courses.ToList());
            List<CourseViewModel> courseViewModel = new List<CourseViewModel>();
            CourseModel courseModel = new CourseModel();
            return View(courseModel.GetCourseList());
        }

        // GET: Course/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: AssignCourse
        public ActionResult AssignCourse()
        {
            CourseModel courseModel = new CourseModel();
            StudentModel studentModel = new StudentModel();
            ViewBag.CourseID = new SelectList(courseModel.ListOfCourses(), "Id", "Title");
            ViewBag.StudentID = new SelectList(studentModel.ListOfStudents(), "Id", "FirstName");
            //ViewBag.CourseCode = new SelectList(db.Courses, "CourseCode", "Title");
            return View();
        }
        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssignCourse([Bind(Include = "CourseID, StudentID")] AssignCourse assignCourse)
        {
            int result=2;
            if (ModelState.IsValid)
            {
                EnrollmentModel enrollmentModel = new EnrollmentModel();
                result = enrollmentModel.Save(assignCourse);
                //Student student = db.Students.Find(assignCourse.StudentID);
                //Course course = db.Courses.Find(assignCourse.CourseID);
                //Enrollment enrollment = new Enrollment();
                //enrollment.CourseID = assignCourse.CourseID;
                //enrollment.StudentID = assignCourse.StudentID;

                //db.Enrollments.Add(enrollment);
                //db.SaveChanges();
                
            }
            if (result == 1)
                return RedirectToAction("Index");
            else if(result==2)
            {
                ViewBag.Result = "Your Selection is not Valid !!!.";
                return RedirectToAction("AssignCourse");
            }
            else
            {
                ViewBag.Result = "Course is Full !!!.";
                //return RedirectToAction("AssignCourse");
                CourseModel courseModel = new CourseModel();
                StudentModel studentModel = new StudentModel();
                ViewBag.CourseID = new SelectList(courseModel.ListOfCourses(), "Id", "Title");
                ViewBag.StudentID = new SelectList(studentModel.ListOfStudents(), "Id", "FirstName");
                return View();
            }
            //return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
