using GestionArticle.Models;
using GestionArticle.Services;
using GestionArticle.Tools;
using Microsoft.AspNetCore.Mvc;

namespace GestionArticle.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ArticleForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

 
            ArticleServic.AddArticle(form.ToData());
            return RedirectToAction("Index");
  
        }
        [HttpPost]
        public IActionResult Edit(ArticleForm f)
        {
            if (!ModelState.IsValid)
            {
                return View(f);
            }

            ArticleServic.EditArticle(f.ToData());
            
            return RedirectToAction("Index");
        }

    }
}
