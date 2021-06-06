using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public BookController(IBookRepository bookRepository)
        {
            repository = bookRepository;
        }

        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(repository.Books);
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Book book)
        {
            repository.CreateBook(book);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            repository.UpdateBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
        public IActionResult Detail(int id)
        {
            return View(repository.Detail(id));
        }
    }
}
