using ExportToExcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExportToExcel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentViewModel model = new StudentViewModel();
            return View(model);
        }

        public FileContentResult ExportToExcel()
        {
            List<Student> lstStudent = StaticDataOfStudent.ListStudent;
            string[] columns = { "ID", "Name","Age"};
            byte[] filecontent = ExcelExportHelper.ExportExcel(lstStudent,"", false, columns);
            return File(filecontent, ExcelExportHelper.ExcelContentType, "MyStudent.xlsx");  
        }
    }
}