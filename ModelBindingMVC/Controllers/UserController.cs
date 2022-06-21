using Microsoft.AspNetCore.Mvc;
using ModelBindingMVC.Models;

namespace ModelBindingMVC.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new WebUser() { FirstName = "Rabi", LastName = "Shrestha" });
        }
        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content($"User {webUser.FirstName} updated!");
            else
            {
                return View(webUser);
                //return Content("Model could not be validated!");
            }
        }

        [HttpGet]
        public IActionResult Family()
        {
            return View(new FamilyModel { id = 1, full_name = "Rabi Shrestha", age = 10, gender = "Male", relation = Relation.Father });
        }
        [HttpPost]
        public IActionResult Family(FamilyModel u)
        {
            if (ModelState.IsValid)
                return Content($"User {u.ToString()} updated!");
            else
            {
                return View(u);
            }
        }

        [HttpGet]
        public IActionResult Math()
        {
            return View(new MathModel { num1 = 0, num2= 0 });
        }
        [HttpPost]
        public IActionResult Math(MathModel u)
        {   
                return View(u);
            
        }

    }
}
