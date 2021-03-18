using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using AutoMapper;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult AddParticipant()
        {
            //List<Course> courses = _context.Courses.ToList();
            
            return View();
        }
        




        [HttpPost]
        public IActionResult AddParticipant(ParticipantForm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Participant pt = new Participant
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                TimeRegistered = DateTime.Now,
            };
            _context.Participants.Add(pt);


            _context.SaveChanges();

            return RedirectToAction(nameof(Courses), new { id = pt.ParticipantID });
        }



        public IActionResult Courses(int id)
        {
            Participant participant = _context.Participants.Where(p => p.ParticipantID==id).FirstOrDefault();
            if (participant != null)
            {
                ViewData["PID"] = id;
                ViewData["PName"] = participant.Name;
                ViewData["PSName"] = participant.Surname;
            }
                        List <Course> courses = _context.Courses.ToList();

            return View(courses);
        }

        public IActionResult BookCourse(int id,int courseid)
        {
            Participant participant = _context.Participants.Where(p => p.ParticipantID == id).FirstOrDefault();
            ViewData["PID"] = id;
            ViewData["PName"] = participant.Name;
            ViewData["PSName"] = participant.Surname;

            Booking booking = new Booking();

            booking.ParticipantID = id;
            booking.CourseID = courseid;

            
            ViewData["CID"] = booking.CourseID;
            ViewData["CSubject"] = booking.Subject;

            _context.Bookings.Add(booking);
            _context.SaveChanges();
        
            return View(booking);
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
