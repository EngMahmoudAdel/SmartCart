using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


[Authorize(Roles = "Admin")]
[Area("Admin")]

public class AdminController : Controller
{
    public IActionResult Dashboard()
    {
        return View();
    }


}