using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {


        public ViewResult Get() => View("MessagesWindow");

        [HttpGet("worker")]
        public async Task<IActionResult> Worker()
        {
            return View("UserWorkerListWindow");
        }

        [HttpGet("theEmpolyeer")]
        public async Task<IActionResult> TheEmpolyer()
        {
            return View("UserTheEmpolyeerListWindow");
        }

    }
}
