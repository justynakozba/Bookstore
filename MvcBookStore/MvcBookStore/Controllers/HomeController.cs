using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBookStore.Models;

namespace MvcBookStore.Controllers
{
    public class HomeController : Controller
    {
            BookStoreEntities storeDB = new BookStoreEntities();
            //
            // GET: /Home/
            public ActionResult Index(int? id)
            {
             var books = GetTopSellingBooks(5);
             return View(books);
        }

        public List<Book> GetTopSellingBooks(int count)
        {
            // Group the order details by book and return
            // the books with the highest count
            return storeDB.Books
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}