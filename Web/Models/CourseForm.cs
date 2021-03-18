using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Web.Models
{
    public class CourseForm
    {
        [Key]
        public int CourseID { get; set; }

        public string Subject { get; set; }

        public string Department { get; set; }

        public string Session { get; set; }

        public string Start { get; set; }

        public string Finish { get; set; }

        public string Venue { get; set; }
    }
}
