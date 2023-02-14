using CopywritingWebSite.Service.Dtos.Acccount;
using CopywritingWebSite.Service.Exceptions;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.Interfaces.Common;
using CopywritingWebSite.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("account")]
    public class AccountsController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _accessor;
        private readonly IIdentityService _identityService;

        public AccountsController(IAccountService accountService, IEmailService emailService, IUserService userService, IHttpContextAccessor httpContextAccessor, IIdentityService identityService)
        {
            this._accountService = accountService;
            this._emailService = emailService;
            this._userService = userService;
            _accessor = httpContextAccessor;
            _identityService = identityService;
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



                    HttpContext.Response.Cookies.Append("X-Access-Token", token.ToString(), new CookieOptions()
                    {
                        HttpOnly = true,
                        SameSite = SameSiteMode.Strict
                    });

                    var res = GlobalVariableModel.UserRole;


                    if (res.ToString() == "UserTheEmpolyeer")
                    {
                        return View("../CustomerTheEmpolyeer/OrderWindow");
                    }
                    else if (res.ToString() == "UserWorker")
                    {
                        return View("../CustomerWorker/DesktopWindow");
                    }
                    else if (res.ToString() == "Admin")
                    {
                        return View("../Admin/UserTheEmpolyeerListWindow");
                    }
                    else
                    {
                        return Login();
                    }

                }
                catch (ModelErrorException modelError)
                {
                    ModelState.AddModelError(modelError.Property, modelError.Message);
                    return Login();
                }
                catch
                {
                    return Login();
                }
            }
            return RedirectToAction("worker", "admin");
        }

        [HttpGet("register")]
        public ViewResult Register() => View("Register");

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(AccountRegisterDto dto)
        {

            try
            {
                var resault = await _accountService.RegisterAsync(dto);
                return Email();
            }
            catch
            {
                return Register();
            }
        }


        [HttpGet("email")]
        public ViewResult Email() => View("Email");

        [HttpPost("email")]
        public async Task<IActionResult> EmailAsync(string email)
        {
            var res = await _accountService.CheckEmail(email);
            if (res)
            {
                return View("Login");
            }
            else
            {
                await _userService.DeleteAsync(GlobalVariableModel.Email);
                return View("Register");
                return View("Login");
            }
        }
    }
}
