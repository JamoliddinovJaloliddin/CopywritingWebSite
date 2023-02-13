using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Get() => View("C");
    }
}
