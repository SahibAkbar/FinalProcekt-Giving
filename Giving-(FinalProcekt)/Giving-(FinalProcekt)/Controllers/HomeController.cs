using Giving__FinalProcekt_.Data;
using Giving__FinalProcekt_.Models;
using Giving__FinalProcekt_.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Giving__FinalProcekt_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {

            VmHome model = new VmHome();
            model.Setting = _context.Settings.FirstOrDefault();
            //model.Subscribe = _context.Subscribes.FirstOrDefault();
            model.HappyFaces = _context.HappyFaces.ToList();
            model.Socials = _context.Socials.ToList();
            model.HomeSliders = _context.HomeSliders.ToList();

            model.Cause = _context.Causes.FirstOrDefault();
            model.Causes = _context.Causes.ToList();
            model.Volunteer = _context.Volunteers.FirstOrDefault();
            model.Volunteers = _context.Volunteers.ToList();
            model.Contact = _context.Contacts.FirstOrDefault();

            return View(model);
        }




        public IActionResult Subscribe(string email)
        {
            VmSubscribe response = new VmSubscribe();

            if (!string.IsNullOrEmpty(email))
            {
                if (_context.Subscribes.Any(s => s.Email == email))
                {
                    response.Status1 = false;
                    return Json(response);
                }
                else
                {
                    response.Status1 = true;
                    Subscribe subscribe = new();
                    subscribe.CreatedDate = DateTime.Now;
                    subscribe.Email = email;

                    _context.Subscribes.Add(subscribe);
                    _context.SaveChanges();

                    return Json(response);

                }
            }
            else
            {
                response.Status2 = true;
                return Json(response);
            }
        }
    }
}
