using Barcode;
using Barcode.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace AspMvcControllers.Controllers
{

    public class BarcodeController : Controller
    {
        private readonly AppDbContext _context;
        public BarcodeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult BarcodeTypes()
        {
            List<BarcodeTypes> BarcodeList = new List<BarcodeTypes>();
            BarcodeList = (from obj in _context.BarcodeType select obj).ToList();
            return View("BarcodeTypes");
        }
    } 
}
