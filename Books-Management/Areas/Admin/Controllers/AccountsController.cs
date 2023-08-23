using Microsoft.AspNetCore.Mvc;

namespace Books_Management.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
