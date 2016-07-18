using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMUcrs.ViewModel
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
        }
        public int Id { get; set; }
        [Required, Display(Name = "Id")]
        [DataType(DataType.Text)]
        public string StudentCode { get; set; }
        [Required, Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        public virtual ICollection<EnrollmentViewModel> EnrollmentViewModels { get; set; }
    }
}