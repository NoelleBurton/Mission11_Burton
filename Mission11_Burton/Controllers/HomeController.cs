using Microsoft.AspNetCore.Mvc;
using Mission11_Burton.Models;
using Mission11_Burton.Models.ViewModels;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace Mission11_Burton.Controllers
{
    public class HomeController : Controller
    {

        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var bundle = new ProjectListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
        };

            return View(bundle);
        }

    }
}
