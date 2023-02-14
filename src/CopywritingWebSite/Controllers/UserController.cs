using CopywritingWebSite.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    public class UserController : Controller
    {

        [Route("user")]

        public async Task<IActionResult> OrderUser()
        {
            var resault = GlobalVariableModel.UserRole;
            if (resault.ToString() == "UserTheEmpolyeer")
            {
                return View("../CustomerTheEmpolyeer/OrderWindow");
            }
            else if (resault.ToString() == "UserWorker")
            {
                return View("../CustomerWorker/DesktopWindow");
            }
            return View();
        }

        public async Task<IActionResult> ArticlesUser()
        {
            var resault = GlobalVariableModel.UserRole;
            if (resault.ToString() == "UserTheEmpolyeer")
            {
                return View("../CustomerTheEmpolyeer/CompletedOrderWindow");
            }
            else if (resault.ToString() == "UserWorker")
            {
                return View("../CustomerWorker/CustomerWorkerTableAdd");
            }
            return View();
        }

        public async Task<IActionResult> MessagesUser()
        {
            var resault = GlobalVariableModel.UserRole;
            if (resault.ToString() == "UserTheEmpolyeer")
            {
                return View("../CustomerTheEmpolyeer/MessagesWindow");
            }
            else if (resault.ToString() == "UserWorker")
            {
                return View("../CustomerWorker/MessagesWindow");
            }
            return View();
        }

        public async Task<IActionResult> AnnouncementsUser()
        {
            var resault = GlobalVariableModel.UserRole;
            if (resault.ToString() == "UserTheEmpolyeer")
            {
                return View("../CustomerTheEmpolyeer/AcceptedOrderWindow");
            }
            else if (resault.ToString() == "UserWorker")
            {
                return View("../CustomerWorker/CustomerWorkerTable");
            }
            return View();
        }
    }
}
