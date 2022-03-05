﻿using Giving__FinalProcekt_.Data;
using Giving__FinalProcekt_.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Areas.admin.Controllers
{
    [Area("admin")]
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
            ViewBag.CauseCount = _context.Causes.ToList().Count;
            ViewBag.EventCount = _context.Events.ToList().Count;
            ViewBag.VolunteerCount = _context.Volunteers.ToList().Count;

            //var w = _context.DonatePrices.Include(d => d.Priceee).Where(c => c.CauseId == id).ToList();
            //var a = 0;
            //foreach (var item in w)
            //{
            //    a += item.Priceee.Money;
            //}

            //ViewBag.total = a;


            //return View(model);
            //ViewBag.DonateCount = _context.Donates.
            //                                        Include(dp =>dp.DonatePrices)
            //                                        .ThenInclude()
            //                                        .ToList().Count;
            return View(model);
        }
    }
}
