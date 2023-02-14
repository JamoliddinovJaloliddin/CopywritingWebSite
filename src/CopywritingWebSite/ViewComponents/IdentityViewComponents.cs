using CopywritingWebSite.Service.Interfaces.Common;
using CopywritingWebSite.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.ViewComponents
{

    public class IdentityViewComponents : ViewComponent
    {
        private readonly IIdentityService _identityService;

        public IdentityViewComponents(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public IViewComponentResult Invoke()
        {
            UserViewModel userViewModel = new UserViewModel()
            {
                Id = _identityService.Id!.Value,
                Email = _identityService.Email,
            };
            return View(userViewModel);
        }
    }
}



