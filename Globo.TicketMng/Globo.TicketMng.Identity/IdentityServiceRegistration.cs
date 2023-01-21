using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Globo.TicketMng.Identity
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<TicketMngIdentityDbContext>(option =>
            option.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));
            return service;
        }
    }
}
