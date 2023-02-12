using CopywritingWebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Dtos.CopywritingDto
{
    public class CopywritingCreateDto
    {
        public string Status { get; set; } = String.Empty;


        public static implicit operator CopywritingStatus(CopywritingCreateDto dto)
        {
            return new CopywritingStatus()
            {
                Status = dto.Status,
            };
        }
    }
}
