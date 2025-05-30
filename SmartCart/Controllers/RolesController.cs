using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCart.Models;

namespace SmartCart.Controllers
{
    //[Authorize(Roles = clsRoles.roleAdmin)]
    public class RolesController : Controller
    {
        public RolesController(UserManager<ApplicationUser> user, RoleManager<IdentityRole> roles)
        {
            _user = user;
            _roles = roles;
        }

        private readonly UserManager<ApplicationUser> _user;
        private readonly RoleManager<IdentityRole> _roles;

        public async Task<IActionResult> Index()
        {
            var _users = await _user.Users.ToListAsync();
            return View(_users);
        }

        [HttpGet]
        public async Task<IActionResult> addRoles(string userId)
        {
            var user = await _user.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _user.GetRolesAsync(user);
            var allRoles = _roles.Roles.ToList(); // أو أي مكان بتجيب منه الرولز

            var model = new AddRolesViewModel
            {
                UserId = userId,
                UserName = user.UserName,
                Roles = allRoles.Select(role => new roleViewModel
                {
                    roleId = role.Id,
                    roleName = role.Name,
                    useRole = userRoles.Contains(role.Name)
                }).ToList()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addRoles(AddRolesViewModel model)
        {
            // البحث عن المستخدم
            var user = await _user.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            var userRoles = await _user.GetRolesAsync(user);

            foreach (var role in model.Roles)
            {
                if (userRoles.Any(x => x == role.roleName.Trim()) && !role.useRole)
                {
                    await _user.RemoveFromRoleAsync(user, role.roleName.Trim());
                }

                if (!userRoles.Any(x => x == role.roleName.Trim()) && role.useRole)
                {
                    await _user.AddToRoleAsync(user, role.roleName.Trim());
                }
            }

            return RedirectToAction(nameof(Index));
        }
    

      
    }
}
