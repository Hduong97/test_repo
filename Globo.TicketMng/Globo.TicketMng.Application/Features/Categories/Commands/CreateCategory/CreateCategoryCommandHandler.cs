using AutoMapper;
using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = new CreateCategoryCommandResponse();
            var validate = new CreateCategoryCommandValidator();
            var validateResult = await validate.ValidateAsync(request);
            if (validateResult.Errors.Count > 0)
            {
                result.Success = false;
                foreach (var item in validateResult.Errors)
                {
                    result.ValidationErrors.Add(item.ErrorMessage);
                }
            } 
            if(result.Success)
            {
                var category = new Category { Name = request.Name };
                await _categoryRepository.AddAsync(category);
                result.CreateCategoryDto = _mapper.Map<CreateCategoryDto>(category);
            }
            return result;
        }
    }
}
