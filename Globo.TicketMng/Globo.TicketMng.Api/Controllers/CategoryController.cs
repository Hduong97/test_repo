using Globo.TicketMng.Application.Exceptions;
using Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryList;
using Globo.TicketMng.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Globo.TicketMng.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("all")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            var dtos = await _mediator.Send(new GetCategoryListQuery());
            throw new NotFoundException("aac", "acac");
            return Ok(dtos);
        }
    }
}
