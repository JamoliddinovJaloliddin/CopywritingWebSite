using CopywritingWebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IAuthManagaer
    {
        public string GenerateToken(User user);
    }
}
