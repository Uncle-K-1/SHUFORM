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
    public class ParticipantForm
    {
        [Key]
        public long  ParticipantID { get; set; }
       
        public string Name { get; set; }

       
        public string Surname { get; set; }

             
        public string Email { get; set; }

        public DateTime TimeRegistered { get; set; }

    }
}
