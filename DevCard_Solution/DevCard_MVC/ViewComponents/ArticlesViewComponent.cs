using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>()
            {
                new Article(1,"اموزش asp.net core mvc","کاملترین پکیج اموزش asp.net core mvc","blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش گیت و گیت هاب","کاملترین پکیج اموزش گیت و گیت هاب","blog-post-thumb-card-2.jpg"),
                new Article(3,"اموزش زبان انگلیسی","کاملترین اموزش سطح وب","blog-post-thumb-card-3.jpg"),
                new Article(4,"اموزش زبان عربی به زبان ساده","کاملترین اموزش زبان عربی سطح وب ","blog-post-thumb-card-4.jpg"),



            };
            return View("_Articles" , Articles);
        }
    }
}
