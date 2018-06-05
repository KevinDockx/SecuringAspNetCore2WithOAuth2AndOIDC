using Microsoft.AspNetCore.Mvc;

public class AuthorizationController : Controller
{
    public IActionResult AccessDenied()
    {
        return View();
    }
}
