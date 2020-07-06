using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize] // To cwhether user is allowed or not.
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Authenticate()
        {
            // User will be redirected to this action method. Now we'll create some fake Claims/ClaimsIdentity/ClaimsPrincipal/Authorization

            var grandmaClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Bob"),
                new Claim(ClaimTypes.Email, "bob@fmail.com"),
                new Claim("Grandma.Say", "Very noce boi")
            };

            var grandmaClaimIdentity = new ClaimsIdentity(grandmaClaims, "Grandma Identity");

            var claimPrincipal = new ClaimsPrincipal(new[] { grandmaClaimIdentity });

            HttpContext.SignInAsync(claimPrincipal);

            return RedirectToAction("Index");
        }
    }
}
