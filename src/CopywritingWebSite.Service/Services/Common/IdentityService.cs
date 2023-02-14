using CopywritingWebSite.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;

namespace CopywritingWebSite.Service.Services.Common
{
    public class IdentityService : IIdentityService
    {
        private readonly IHttpContextAccessor _accessor;
        public IdentityService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public long? Id
        {
            get
            {
                var resault = _accessor.HttpContext!.User.FindFirst("Id");
                return resault is not null ? long.Parse(resault.Value) : null;
            }
        }

        public string Email
        {
            get
            {
                var resault = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");
                return resault is null ? string.Empty : resault.Value;
            }
        }
    }
}



