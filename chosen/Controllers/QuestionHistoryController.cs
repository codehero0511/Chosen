using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chosen.Models;

namespace chosen.Controllers
{
    public class QuestionHistoryController : Controller
    {
        private readonly FinalProjectContext _context;

        public QuestionHistoryController(FinalProjectContext context)
        {
            _context = context;
        }


        [HttpPost]
        // GET: 
        public IActionResult Index(int questionReportId, string message, int whoanswer, string datetimesec)
        {
            // 根據questionReportId找到對應的QuestionReport對象
            var questionReport = _context.QuestionHistories.FirstOrDefault(q => q.QuestionReportId == questionReportId);

            if (questionReport == null)
            {
                return NotFound(); // 如果找不到相應的QuestionReport，返回404錯誤
            }

            // 更新QuestionDescription属性
            questionReport.Message = message;
        
            _context.SaveChanges(); // 保存更改

            return Ok(); //返回成功響應
           
        }

        public IActionResult SubmitQuestion(string questionTitle, string message, string questionType, string DateTime)
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult StoreQuestionID(string questionID)
        {
            // 刪除舊的 QuestionID
            TempData.Remove("QuestionID");

            // 儲存新的 QuestionID
            TempData["QuestionID"] = questionID;

            return Json(new { success = true });
        }

    }
}
