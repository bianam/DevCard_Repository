using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Header");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<p>Amirreza Vajdy . Im From Iran</p>", "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    //return new EmptyResult();
        //    return null;
        //}

        //public FileResult Index()
        //{
        //    var filebite = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string filename = "Goshachay.txt";
        //    return File(filebite,MediaTypeNames.Text.Plain , filename);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new Project(2, "Amirreza" , "Im form Iran and I like Code." , "~/assets/images/me.jpeg" , "vava"));
        //}

        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('hello hello')");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact" , "Home");
        //}

        public IActionResult Index()
        {
            return new NotFoundResult();
        }
    }

    //public class JavaScriptResult : ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "text/javascipt";
    //    }
    //}
}
