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
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> DashBoard()
        {
            var productCount = await _unitOfWork.Products.CountAsync();
            var userCount = await _unitOfWork.ApplicationUsers.CountAsync();

            ViewBag.ProductCount = productCount;
            ViewBag.UserCount = userCount;

            return View();
        }
    }

