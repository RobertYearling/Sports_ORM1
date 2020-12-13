using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // ***** Number 1
            ViewBag.WomensLeagues = _context.Leagues
                .Where( w => w.Name.Contains("Women"))
                .ToList();

            // ***** Number 2
            ViewBag.HockeyTeams = _context.Leagues
                .Where( w => w.Sport.Contains("Hockey"))
                .ToList();

            // ***** Number 3
            ViewBag.NotTheFootball = _context.Leagues
                .Where( w => w.Sport!="Football")
                .ToList();

            // ***** Number 4
            ViewBag.Conferences = _context.Leagues
                .Where(c => c.Name.Contains("Conference"))
                .ToList();

            // ***** Number 5
            ViewBag.AtlanticTeams = _context.Leagues
                .Where(a => a.Name.Contains("Atlantic"));

            // ***** Number 6
            ViewBag.DallasTeams = _context.Teams
                .Where( t => t.Location == "Dallas")
                .ToList();

            // ***** Number 7
            ViewBag.Raptors = _context.Teams
                .Where(r => r.TeamName == "Raptors");

            // ***** Number 8
            ViewBag.CityTeams = _context.Teams
                .Where(c => c.Location.Contains("City"));

            // ***** Number 9
            ViewBag.StartsT = _context.Teams
                .Where(t => t.TeamName.StartsWith("T"))
                .ToList();

            // ***** Number 10
            ViewBag.AlphaLoc = _context.Teams
                .OrderBy(l => l.Location)
                .ToList();

            // ***** Number 11
            ViewBag.ReverseTeams = _context.Teams
                .OrderByDescending( t => t.TeamName )
                .ToList();

            // ***** Number 12
            ViewBag.Cooper = _context.Players
                .Where(p => p.LastName == "Cooper")
                .ToList();

            // ***** Number 13
            ViewBag.Joshua = _context.Players
                .Where(p => p.FirstName == "Joshua")
                .ToList();

            // ***** Number 14
            ViewBag.CooperNoJosh = _context.Players
            .Where(p => p.LastName == "Cooper")
            .Where(p => p.FirstName != "Joshua")
            .ToList();

            // ***** Number 15
            ViewBag.AlexWyatt = _context.Players
                .Where(p => p.FirstName == "Alexander" || p.FirstName == "Wyatt")
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}