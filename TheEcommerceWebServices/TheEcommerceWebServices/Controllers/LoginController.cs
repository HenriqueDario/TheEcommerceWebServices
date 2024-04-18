using Microsoft.AspNetCore.Mvc;

namespace TheEcommerceWebServices.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
