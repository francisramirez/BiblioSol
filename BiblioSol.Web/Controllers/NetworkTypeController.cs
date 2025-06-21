using BiblioSol.Web.Models.Insurance.NetworkType;
using BiblioSol.Web.Services.insurance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioSol.Web.Controllers
{
    public class NetworkTypeController : Controller
    {
        private readonly INetworkTypeHttpService networkTypeHttpService;

        public NetworkTypeController(INetworkTypeHttpService networkTypeHttpService)
        {
            this.networkTypeHttpService = networkTypeHttpService;
        }
        // GET: NetworkTypeController
        public async Task<IActionResult> Index()
        {
            var result = await networkTypeHttpService.GetAllNetworkTypesAsync();

            if (!result.issuccess)
            {
                // Handle the error, e.g., log it or show an error message
                ViewBag.ErrorMessage = result.message;
                return View("Error"); // Assuming you have an Error view to display errors
            }

          

            return View(result.data);
        }

        // GET: NetworkTypeController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var result = await networkTypeHttpService.GetNetworkTypeByIdAsync(id);

            if (!result.issuccess)
            {
                // Handle the error, e.g., log it or show an error message
                ViewBag.ErrorMessage = result.message;
                return View("Error"); // Assuming you have an Error view to display errors
            }

            return View(result.data);
        }

        // GET: NetworkTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NetworkTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NetworkTypeController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var result = await networkTypeHttpService.GetNetworkTypeByIdAsync(id);

            if (!result.issuccess)
            {
                // Handle the error, e.g., log it or show an error message
                ViewBag.ErrorMessage = result.message;
                return View("Error"); // Assuming you have an Error view to display errors
            }

            return View(result.data);
        }

        // POST: NetworkTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NetworkTypeUpdateDto networkTypeUpdateDto)
        {
            try
            {
                var result = await networkTypeHttpService.UpdateNetworkTypeAsync(networkTypeUpdateDto);

                if (result.issuccess)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    // Handle the error, e.g., log it or show an error message
                    ViewBag.ErrorMessage = result.message;
                    return View("Error"); // Assuming you have an Error view to display errors
                }


            }
            catch
            {
                return View();
            }
        }
    }
}
