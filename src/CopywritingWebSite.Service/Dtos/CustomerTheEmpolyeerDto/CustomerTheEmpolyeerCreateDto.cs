using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto
{
    public class CustomerTheEmpolyeerCreateDto
    {
        public string CardNumber { get; set; } = String.Empty;
        public string CardMmYy { get; set; } = String.Empty;

        public static implicit operator CustomerTheEmpolyeer(CustomerTheEmpolyeerCreateDto dto)
        {
            return new CustomerTheEmpolyeer()
            {
                CardMmYy = dto.CardMmYy,
                CardNumber = dto.CardNumber,
            };
        }
    }
}
