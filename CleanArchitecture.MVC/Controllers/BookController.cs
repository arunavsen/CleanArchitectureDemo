using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.MVC.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetBooks();
            return View(model);
        }
    }
}