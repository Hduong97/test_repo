using Globo.TicketMng.Application.Responses;

namespace Globo.TicketMng.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryDto? CreateCategoryDto { get; set; }
    }
}