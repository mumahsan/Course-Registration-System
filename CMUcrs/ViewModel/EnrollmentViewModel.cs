
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMUcrs.ViewModel
{
    public class EnrollmentViewModel
    {
        public EnrollmentViewModel()
        { }
        public int Id { get; set; }
        public virtual CourseViewModel CourseViewModel { get; set; }
        public virtual StudentViewModel StudentViewModel { get; set; }

    }
}