using Globo.TicketMng.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Contracts.Insfratructure
{
    public interface IMailService
    {
        Task<bool> SendMail(Email email);
    }
}
