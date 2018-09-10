using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using DataManagementTool.Data;
using DataManagementTool.Models;
using DataManagementTool.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace DataManagementTool.Controllers
{
    public class ClientController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        IConfiguration _iconfiguration;
        private IHostingEnvironment _env;


        public ClientController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
             IHostingEnvironment hostingEnvironment, IConfiguration iconfiguration
           )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = hostingEnvironment;
            _iconfiguration = iconfiguration;

        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get details of client
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetClientDetails()
        {
            List<ClientViewModel> objlist = new List<ClientViewModel>();
            var clients = _userManager.Users.Where(d => d.IsDeleted == false).ToList();
            foreach (var item in clients)
            {
                ClientViewModel objClientList = new ClientViewModel();
                objClientList.Email = item.Email;
                objClientList.PhoneNumber = item.PhoneNumber;
                objClientList.Name = item.Name;
                objClientList.AddressStreet = item.AddressStreet;
                objClientList.AddressStreet2 = item.AddressStreet2;
                objClientList.Company = item.Company;
                objClientList.Id = item.Id;
                objClientList.AdditionalDetails = item.AdditionalDetails;
                objlist.Add(objClientList);
            }
            return PartialView("~/Views/Shared/_ManageClientList.cshtml", objlist);
           
        }

        /// <summary>
        /// Create method for adding client
        /// </summary>
        /// <param name="uservm"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> CreateClientView(ClientViewModel uservm)
        {
            ModelState.Remove("Id");
            ApplicationMessage message = new ApplicationMessage();
            if (ModelState.IsValid)
            {
                try
                {
                    var password = Helpers.PasswordGenerate(6, 2) + "Aa0";
                    var user = new ApplicationUser
                    {
                        UserName = uservm.Email,
                        Email = uservm.Email,
                        Name = uservm.Name,
                        PhoneNumber = uservm.PhoneNumber,
                        AdditionalDetails = uservm.AdditionalDetails,
                        Address = uservm.AddressStreet,
                        AddressStreet2 = uservm.AddressStreet2,
                        PostalAddress = uservm.PostalAddress,
                        PostalCode = uservm.PostalCode,
                        AddedDate = DateTime.UtcNow,
                        Company=uservm.Company,
                        IsTempPassword = true,
                        IsDeleted = false

                    };
                    var users = _userManager.Users.Where(d => d.Email == uservm.Email).FirstOrDefault();
                    if (users == null)
                    {
                        var result = await _userManager.CreateAsync(user, password);
                        if (result.Succeeded)
                        {
                            var userAdded = await _userManager.FindByIdAsync(user.Id);
                            result = await _userManager.AddToRoleAsync(userAdded, Utilities.Constants.Client);
                            uservm.Role = Utilities.Constants.Client;
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
                            SendMail(email, name, subject, UserRole, Password, SiteUrl);
                            message.Message = "Client added successfully.";
                            message.Color = "#4CAF50";
                            return Json(new
                            {
                                Data = new { message = message.Message, message.Color, Success = true }

                            });
                        }
                    }
                    else
                    {
                        message.Message = "Email already exists";
                        message.Color = "#FF0000";
                        return Json(new
                        {
                            Data = new { message = message.Message, message.Color, Success = false }
                        });
                    }
                }

                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                    return View();
                }

            }
            return Json(new
            {
                Data = new { message = message.Message, message.Color, Success = true }

            });
        }

        public IActionResult CreateClientView()
        {
            return View("CreateClient");
        }

        /// <summary>
        /// Delete client by passing the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> DeleteClient(string id)
        {
            ApplicationMessage message = new ApplicationMessage();
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    var user = await _userManager.FindByIdAsync(id);
                    user.IsDeleted = true;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        message.Message = "Client deleted successfully";
                        message.Color = "#4CAF50";
                        return Json(new
                        {
                            Data = new { message = message.Message, message.Color }
                        });
                    }
                    else
                    {
                        message.Message = result.Errors.ToString();
                        message.Color = "#FF0000";
                        return Json(new
                        {
                            Data = new { message = message.Message, message.Color }
                        });
                    }
                }
                return Json(new
                {
                    Data = new { message = message.Message, message.Color }

                });
            }
            catch (Exception ex)
            {
                message.Message = ex.Message.ToString();
                message.Color = "#FF0000";
                return Json(new
                {
                    Data = new { message = message.Message, message.Color }

                });
            }
        }


        /// <summary>
        /// Method for sending email to client
        /// </summary>
        /// <param name="email"></param>
        /// <param name="userName"></param>
        /// <param name="subject"></param>
        /// <param name="userRole"></param>
        /// <param name="password"></param>
        /// <param name="siteUrl"></param>
        public void SendMail(string email, string name, string subject, string userRole, string password, string siteUrl)
        {
            var webRoot = _env.WebRootPath;
            try
            {
                using (StreamReader sourceReader = System.IO.File.OpenText(System.IO.Path.Combine(webRoot, "HTMLTemplates/User_Template.html")))
                {
                    var emailText = sourceReader.ReadToEnd();
                    emailText = emailText.Replace("$$UserName$$", name);
                    emailText = emailText.Replace("$$Email$$", email);
                    emailText = emailText.Replace("$$Password$$", password);
                    emailText = emailText.Replace("$$UserRole$$", userRole);
                    emailText = emailText.Replace("$$Url$$", siteUrl);
                    System.Net.Mail.MailMessage mailMsg = new System.Net.Mail.MailMessage();
                    mailMsg.Subject = subject;
                    mailMsg.IsBodyHtml = true;
                    mailMsg.Body = emailText;
                    //mailMsg.From = new MailAddress("Administrator", "Admin@idsil.com");
                    mailMsg.From = new MailAddress("Admin@idsil.com", "Administrator");
                    mailMsg.To.Add(email);
                    var smtpServer= _iconfiguration["SMTPServer"];
                    SmtpClient smtp = new SmtpClient(smtpServer);
                    smtp.Send(mailMsg);
                    smtp.Dispose();
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        public async Task<IActionResult> EditClient(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            ClientViewModel obj = new ClientViewModel();
            if (user != null)
            {

                obj.Id = user.Id;
                obj.Email = user.Email;
                obj.Name = user.Name;
                obj.PhoneNumber = user.PhoneNumber;
                obj.PostalAddress = user.PostalAddress;
                obj.PostalCode = user.PostalCode;
                obj.AdditionalDetails = user.AdditionalDetails;
                obj.AddressStreet = user.AddressStreet;
                obj.AddressStreet2 = user.AddressStreet2;
                obj.Company = user.Company;
            }
            return View("EditClient", obj);
        }

        /// <summary>
        /// Edit client by passing the strongly typed model
        /// </summary>
        /// <param name="uservm"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditClient(ClientViewModel uservm)
        {
            ApplicationMessage message = new ApplicationMessage();
            var user = await _userManager.FindByIdAsync(uservm.Id);
            if (user != null)
            {
                user.Id = uservm.Id;
                user.Email = uservm.Email;
                user.Name = uservm.Name;
                user.PhoneNumber = uservm.PhoneNumber;
                user.PostalAddress = uservm.PostalAddress;
                user.PostalCode = uservm.PostalCode;
                user.AdditionalDetails = uservm.AdditionalDetails;
                user.AddressStreet = uservm.AddressStreet;
                user.AddressStreet2 = uservm.AddressStreet2;
                user.Company = uservm.Company;
                user.IsDeleted = false;
                user.IsTempPassword = true;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    message.Message = "Client update successfully";
                    message.Color = "#4CAF50";
                    return Json(new
                    {
                        Data = new { message = message.Message, message.Color, Success = true }

                    });
                }
                else
                {
                    message.Message = result.Errors.ToString();
                    message.Color = "#FF0000";
                    return Json(new
                    {
                        Data = new { message = message.Message, message.Color, Success = false }

                    });
                }
            }
            return Json(new
            {
                Data = new { message = message.Message, message.Color, Success = true }

            });

        }

    }
}