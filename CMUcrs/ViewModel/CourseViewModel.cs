using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMUcrs.ViewModel
{
    public class CourseViewModel
    {
        public CourseViewModel()
        { 
        }
        public int Id { get; set; }
        [Required, Display(Name = "Id")]
        [DataType(DataType.Text)]
        public String CourseCode { get; set; }
        [Required, Display(Name = "Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [Required, Display(Name = "Credits")]
        [DataType(DataType.Text)]
        public string Credits { get; set; }
        [Required, Display(Name = "Decription")]
        [DataType(DataType.Text)]
        public string Decription { get; set; }
        [Required, Display(Name = "MaxCapacity")]
        [DataType(DataType.Text)]
        public int MaxCapacity { get; set; }
    }
}