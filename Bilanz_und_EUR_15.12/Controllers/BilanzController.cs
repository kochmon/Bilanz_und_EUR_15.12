using Bilanz_und_EUR_15._12.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bilanz_und_EUR_15._12.Controllers
{
    public class BilanzController : Controller
    {
        private readonly FinanzDbContext _context;

        public BilanzController(FinanzDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Bilanz> bilanzen = _context.Bilanzen.ToList(); // Code, um Bilanzdaten aus der Datenbank oder einer anderen Quelle abzurufen
            return View(bilanzen);
        }

        // Weitere Aktionen für die Bilanzverwaltung hinzufügen
    }
}