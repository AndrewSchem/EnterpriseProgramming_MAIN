using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebApp.Controllers
{
	public class AdminController : Controller
	{
		UserManager<IdentityUser> _userManager;
		public AdminController(UserManager<IdentityUser> userManager)
		{
			_userManager = userManager;
		}


		public IActionResult Allocate() {
			return View();
		}

		public IActionResult Allocate(string email, string role)
		{
			var user = new IdentityUser { UserName = email, Email = email };
			_userManager.AddToRoleAsync(user,role);
			return View();
		}
	}
}
