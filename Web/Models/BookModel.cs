using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Web.Models
{
    public class BookModel
    {

        public List<Participant> Participants { get; set; }
        public List<Course> Courses { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
