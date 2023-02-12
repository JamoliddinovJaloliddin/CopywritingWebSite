using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Service.Dtos.TestDto
{
    public class TestCreateDto
    {
        public LanguageStatus Status { get; set; }
        public string Question { get; set; } = String.Empty;
        public string ChooseOne { get; set; } = String.Empty;
        public string ChooseTwo { get; set; } = String.Empty;
        public string ChooseThree { get; set; } = String.Empty;
        public string Answer { get; set; } = String.Empty;

        public static implicit operator Test(TestCreateDto dto)
        {
            return new Test()
            {
                Status = dto.Status,
                Question = dto.Question,
                ChooseOne = dto.ChooseOne,
                ChooseTwo = dto.ChooseTwo,
                ChooseThree = dto.ChooseThree,
                Answer = dto.Answer,
            };
        }
    }
}
