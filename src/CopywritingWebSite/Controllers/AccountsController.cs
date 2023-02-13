using CopywritingWebSite.Service.Dtos.Acccount;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("account")]
    public class AccountsController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpGet("login")]
        public ViewResult Login() => View("Login");

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(AccountLoginDto accountLoginDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await _accountService.LoginAsync(accountLoginDto);

                    return RedirectToAction();

                    //HttpContext.Response.Cookies.Append("X-Access-Token", token.ToString(), new CookieOptions()
                    //{
                    //    HttpOnly = true,
                    //    SameSite = SameSiteMode.Strict
                    //});
                    //var id = HttpContextHelper.UserId;
                    //var res = HttpContextHelper.UserRole;
                    //if (res == "Admin")
                    //{
                    //    return RedirectToAction("Approved", "Admin", new { area = "" });
                    //}
                    //else if (res == "User")
                    //{
                    //    return RedirectToAction("Active", "users", new { area = "" });
                    //}
                    //else
                    //{
                    //    return View();
                    //}

                }
                //catch (ModelErrorException modelError)
                //{
                //    ModelState.AddModelError(modelError.Property, modelError.Message);
                //    return Login();
                //}
                catch
                {
                    return Login();
                }
            }
            else return Login();
        }

        [HttpGet("register")]
        public ViewResult Register() => View("Register");

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(AccountRegisterDto dto)
        {
            try
            {
                var resault = await _accountService.RegisterAsync(dto);

                return Login();
            }
            catch
            { 
                return Register();
            }
        }
    }
}
