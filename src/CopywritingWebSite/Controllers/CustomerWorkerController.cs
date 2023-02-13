using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("customerWorker")]
    public class CustomerWorkerController : Controller
    {
        public ViewResult Login() => View("DesktopWindow");

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            return View("CustomerWorkerTable");
        }
    }
}
