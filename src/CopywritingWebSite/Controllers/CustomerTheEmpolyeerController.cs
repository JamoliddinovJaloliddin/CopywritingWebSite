using CopywritingWebSite.Service.Dtos.Acccount;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("customerTheEmpolyeer")]
    public class CustomerTheEmpolyeerController : Controller
    {
      
        public ViewResult Login() => View("OrderWindow");


        [HttpGet("completed")]
        public ViewResult Complet()
        {
            return View("CompletedOrderWindow");
        }

        [HttpGet("accepted")]
        public ViewResult Accepted()
        {
            return View("AcceptedOrderWindow");
        }
    }
}
