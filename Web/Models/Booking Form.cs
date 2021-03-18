using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class BookingForm
    {
        [Key]
        public long BookingID { get; set; }

        //foreign key

        [ForeignKey("Participant")]
        public int ParticipandID { get; set; }
                
        public string Name { get; set; }
      
        public string Surname { get; set; }
        public virtual Participant Participants { get; set; }

        //foreign key
        [ForeignKey("CourseID")]
        public int CourseID { get; set; }
        public string Subject { get; set; }
       
        public virtual Course Courses { get; set; }
       

       

    }
}
