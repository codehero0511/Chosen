using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chosen.Models;
using Newtonsoft.Json;

namespace chosen.Controllers
{
    public class QuestionReportController : Controller
    {
        private readonly FinalProjectContext _context;

        public QuestionReportController(FinalProjectContext context)
        {
            _context = context;
        }

        [HttpPost]
        // GET: 
        public IActionResult  Index(int questionReportId, string questionDescription)
        {
           
            return View();
        }

        
    }
}
