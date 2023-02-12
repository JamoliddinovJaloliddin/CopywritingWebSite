using CopywritingWebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Dtos.ArticleDto
{
    public class ArticleTextDto
    {
        public string Text { get; set; } = String.Empty;

        public static implicit operator Article(ArticleTextDto dto)
        {
            return new Article()
            {
                ArticleText = dto.Text,
            };
        }
    }
}
