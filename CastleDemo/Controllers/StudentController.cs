using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Castle.Components.DictionaryAdapter;
using CastleDemo.Models;
using ILogic;
using ILogics;
using Repository.Models;

namespace CastleDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentLogic _studentLogic;

        public StudentController(IStudentLogic studentLogic )
        {
            _studentLogic = studentLogic;
        }

        
        public ActionResult Index()
        {
            var studentViewModelInterface = new StudentViewModel
            {
                Name = _studentLogic.GetName(1)
            };
            //List<Student> students = new EditableList<Student>();
          

            return View(studentViewModelInterface);
        }
    }
}