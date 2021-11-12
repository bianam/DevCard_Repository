using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"تاکسی" , "درخواست انلاین تاکسی برای سفرهای درون شهری" ,"project-1.jpg" , "Snapp") ,
                new Project(2,"زودفود" , "درخواست انلاین غذا برای سراسر کشور" , "project-2.jpg" , "ZoodFood") ,
                new Project(3,"مدارس" , "سیستم یکپارچه مدارس" ,"project-3.jpg" , "Monop") ,
                new Project(4,"فضاپیما" , "برنامه مدیریت فضاپیماهای ناسا" ,"project-4.jpg" , "NASA") ,

            };
            return View("_Projects" , projects);
        }
    }
}
