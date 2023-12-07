using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Controllers;

[Authorize(Roles = "admin")]
public class RoleController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public IActionResult AllUsers()
    {
        var usersWithRoles = new List<UserWithRolesViewModel>();

        foreach (var user in _userManager.Users)
        {
            var roles = _userManager.GetRolesAsync(user).Result;
            usersWithRoles.Add(new UserWithRolesViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserEmail = user.Email,
                Roles = roles.ToList()
            });
        }

        return View(usersWithRoles);
    }
}

public class UserWithRolesViewModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public List<string> Roles { get; set; }
}
