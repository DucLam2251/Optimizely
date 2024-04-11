using Microsoft.AspNetCore.Mvc;
using New_Project.Models.Pages;
using New_Project.Models.ViewModels;

namespace New_Project.Controllers
{
    public class NewsListPageController : PageControllerBase<NewsListPage>
    {
        public ActionResult Index(NewsListPage currentPage)
        {
            var viewModel = PageViewModel.Create(currentPage);

            return View(viewModel);
        }
    }
}
