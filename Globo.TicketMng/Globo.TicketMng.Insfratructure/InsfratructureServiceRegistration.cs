using MediatR;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Application.Contracts.Insfratructure;
using Globo.TicketMng.Application.Model;
using Globo.TicketMng.Insfratructure.Mail;
using Microsoft.Extensions.Configuration;

namespace Globo.TicketMng.Insfratructure
{
    public static class InsfratructureServiceRegistration
    {
        public static IServiceCollection AddInsfratructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(x => configuration.GetSection("EmailSettings"));
            services.AddTransient<IMailService, EmailService>();

            return services;
        }
    }
}
