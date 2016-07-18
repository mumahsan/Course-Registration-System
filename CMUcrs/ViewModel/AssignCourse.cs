using CMUcrs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMUcrs.ViewModel
{
    public class AssignCourse
    {
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        
    }
}