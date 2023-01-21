using AutoMapper;
using Globo.TicketMng.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class GetCategoryListWithEventsHandler : IRequestHandler<GetCategoryListWithEventsQuery, List<CategoryEventListVM>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryListWithEventsHandler(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryEventListVM>> Handle(GetCategoryListWithEventsQuery request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetCategoriesWithEvent(request.IncludeHistory);
            return _mapper.Map<List<CategoryEventListVM>>(result);
        }
    }
}
