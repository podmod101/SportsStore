using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentManagement.Models;

namespace TournamentManagement.Controllers
{
    [Route("api/students")]
    public class StudentValuesController : Controller
    {
        private DataContext context;

        public StudentValuesController(DataContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return context.Student.Find(id);
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents(bool related = false)
        {
            IQueryable<Student> query = context.Student;
            if (related)
            {
                query = query.Include(s => s.StudentDetails);
                List<Student> data = query.ToList();
                //data.ForEach(s =>
                //{
                //    if (s.StudentDetails != null)
                //    {
                //        s.StudentDetails = null;
                //    }
                //});
                return data;
            }
            else
            {
                return query;
            }
        }
    }
}