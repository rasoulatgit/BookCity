using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.Repositories;
using BookShop.Models.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _UW;
        public HomeController(IUnitOfWork UW)
        {
            _UW = UW;
        }


        public async Task<IActionResult> Index(string id)
        {
           
            if (id != null)
                ViewBag.ConfirmEmailAlert = "لینک فعال سازی حساب کاربری به ایمیل شما ارسال شد لطفا با کلیک روی این لینک حساب خود را فعال کنید.";


            var books =await _UW.BooksRepository.GetLastTopPublishBook(5);
            ViewBag.Categories = _UW.BooksRepository.GetAllCategories();

            return View(books);
        }
        public async Task<IActionResult> Search(string bookTitle="")
        {
            var books =await _UW.BooksRepository.GetAllPublishBook(bookTitle);

            return View(books);
        }


        public async Task<IActionResult> ShowBooksWithCategory(int? catID)
        {
            if (catID==null)
            {
                return NotFound();
            }
            var cat =await _UW.BaseRepository<Category>().FindByIDAsync(catID);
            if (cat == null)
            {
                return NotFound();
            }
            ViewBag.Category = cat;
            ViewBag.Categories = _UW.BooksRepository.GetAllCategories();
            var books = await _UW.BooksRepository.FindBooksOfCategory(catID.Value);

            return View(books);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var book = await _UW._context.Books.Include(l => l.Language).Include(p => p.Publisher)
                    .FromSql("SELECT * FROM BookInfo WHERE BookID={0}", id).FirstOrDefaultAsync();
                if (book == null)
                {
                    return NotFound();
                }
                else
                {
                    ViewBag.Author = await (from n in _UW._context.Author_Books.Include(n => n.Author) where (n.BookID == id) select n.Author.FirstName + " " + n.Author.LastName).AsNoTracking().ToListAsync();
                    ViewBag.Category = await (from n in _UW._context.Category_Books.Include(n => n.Category) where (n.BookID == id) select n.Category.CategoryName).AsNoTracking().ToListAsync();
                    ViewBag.Translator = await (from n in _UW._context.Translator_Books.Include(n => n.Translator) where (n.BookID == id) select n.Translator.FirstName + " " + n.Translator.LastName).AsNoTracking().ToListAsync();

                    return PartialView(book);
                }
            }
        }


    }
}