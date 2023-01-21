using Globo.TicketMng.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Identity
{
    public class TicketMngIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public TicketMngIdentityDbContext(DbContextOptions<TicketMngIdentityDbContext> options) : base(options)
        {

        }
    }
}
