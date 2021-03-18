using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        //foreign key

        [ForeignKey("ParticipantID")]
        public int ParticipantID { get; set; }
                
        public string Name { get; set; }
      
        public string Surname { get; set; }
        public virtual Participant Participants { get; set; }

        //foreign key
        public int CourseID { get; set; }
        public string Subject { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Courses { get; set; }
       

       

    }
}
