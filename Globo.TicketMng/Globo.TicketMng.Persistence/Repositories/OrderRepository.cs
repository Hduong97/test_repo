using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(TicketMngDbContext dbContext) : base(dbContext)
        {
        }
    }
}
