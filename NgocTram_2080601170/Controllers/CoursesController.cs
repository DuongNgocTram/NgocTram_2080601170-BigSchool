using NgocTram_2080601170.Models;
using NgocTram_2080601170.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgocTram_2080601170.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();

        }
        // GET: Courses
        public ActionResult Create()
        {
            var Viewmodels = new Courseviewmodels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(Viewmodels);
        }
    }
}