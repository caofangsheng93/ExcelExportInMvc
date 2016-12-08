using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportToExcel.Models
{
    public class StudentViewModel
    {
        public List<Student> ListStudent
        {
            get 
            {
                return StaticDataOfStudent.ListStudent;
            }
        }
    }
}