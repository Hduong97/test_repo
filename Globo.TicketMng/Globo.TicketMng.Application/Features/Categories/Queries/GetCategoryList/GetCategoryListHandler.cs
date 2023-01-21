using AutoMapper;
using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoryListHandler : IRequestHandler<GetCategoryListQuery, List<CategoryListVM>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryListHandler(
            IAsyncRepository<Category> categoryRepository,
            IMapper mapper
            )
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryListVM>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryListVM>>(result);
        } 
    }
}
