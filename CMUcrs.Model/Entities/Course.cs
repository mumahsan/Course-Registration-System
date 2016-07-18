using CMUcrs.Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CMUcrs.Models
{
    public class Course : IIdentifier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String CourseCode { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }
        public string Decription { get; set; }
        public int MaxCapacity { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}