using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System.Data.SqlClient;


namespace Web.Controllers
{
    public class BookingController : Controller

    {

        private readonly ILogger<BookingController> _logger;
        private readonly ApplicationDbContext _context;


        public BookingController(ILogger<BookingController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var model = (from booking in _context.Bookings
                         join p in _context.Participants on booking.ParticipantID equals p.ParticipantID
                         join c in _context.Courses on booking.CourseID equals c.CourseID
                        select new Booking { BookingID = booking.BookingID, Name = p.Name, Subject = c.Subject }
                        ).ToList();

            return View(model);
        }

        

    }
}
