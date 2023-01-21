using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TicketMngDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Category>> GetCategoriesWithEvent(bool includeHistory)
        {
            throw new NotImplementedException();
        }
    }
}
