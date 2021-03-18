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
    public class Participant
    {
        [Key]
        public int  ParticipantID { get; set; }


        [Required(ErrorMessage ="Please insert your first name. The name must be of 3 characters minimum"),MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert your surname. The name must be of 3 characters minimum"), MinLength(3)]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Please insert your email")]
        [EmailAddress(ErrorMessage = "Please insert your email")]
        public string Email { get; set; }

        public DateTime TimeRegistered { get; set; }

    }
}
