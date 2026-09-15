using AspNetAjaxForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetAjaxForm.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Submit([FromForm] UserFormModel model)
    {
        if (!ModelState.IsValid)
            return Json(new { success = false,
                errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });

        return Json(new { success = true, message = $"Спасибо, {model.Name}!" });
    }
}
