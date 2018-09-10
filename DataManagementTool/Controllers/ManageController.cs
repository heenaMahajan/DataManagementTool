using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataManagementTool.Utilities;
using Microsoft.AspNetCore.Identity;
using DataManagementTool.Data;
using System.Security.Claims;
using DataManagementTool.Models;
using DataManagementTool.Service;

namespace DataManagementTool.Controllers
{
    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ContactService _contactService;

        public ManageController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ContactService contactService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CreateClient(UserViewModel uservm)
        {
            if (ModelState.IsValid)
            {
                
                var password = Helpers.PasswordGenerate(6, 2) + "Aa0";
                var user = new ApplicationUser
                {
                    UserName = uservm.Email,
                    Email = uservm.Email,
                    Name = uservm.Name,
                    PhoneNumber = uservm.PhoneNumber,
                    AddedDate = DateTime.UtcNow,
                    IsTempPassword = true,
                    IsDeleted = true
                };
                var users = _userManager.Users.Where(d => d.Email == uservm.Email).FirstOrDefault();
                if (users == null)
                {
                    var result = await _userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        var userAdded = await _userManager.FindByIdAsync(user.Id);
                        result = await _userManager.AddToRoleAsync(userAdded, uservm.Role);
                        await _userManager.UpdateAsync(user);
                        await _userManager.AddClaimAsync(userAdded, new Claim("email", user.Email));
                        await _userManager.AddClaimAsync(userAdded, new Claim("given_name", user.Name));
                        string subject = "Data Management Tool";
                        string email = user.Email;
                        string name = user.Name;
                        string UserRole = uservm.Role;
                        string Password = password.ToString();
                        var SiteUrl = string.Concat(
                        Request.Scheme,
                        "://",
                        Request.Host.ToUriComponent(),
                        Request.PathBase.ToUriComponent(),
                          "/");
                        //SendMail(email, name, subject, UserRole, Password, SiteUrl);

                    }
                    return Json(new { success = true, message = "Saved Successfully." });
                }
                else
                {
                    return Json(new
                    {
                        Data = new { ErrorMessage = "Email already exists", Success = false },
                        ContentEncoding = System.Text.Encoding.UTF8
                    });
                }
            }
            return View();
        }
    }
}