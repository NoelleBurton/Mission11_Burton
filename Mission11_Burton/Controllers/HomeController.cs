using Microsoft.AspNetCore.Mvc;
using Mission11_Burton.Models;
using Mission11_Burton.Models.ViewModels;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace Mission11_Burton.Controllers
{
    public class HomeController : Controller
    {

        private IWaterRepository _repo;

        public HomeController(IWaterRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var bundle = new ProjectListViewModel
            {
                Projects = _repo.Projects
                .OrderBy(x => x.ProjectName)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Projects.Count()
                }
        };

            return View(bundle);
        }

    }
}
