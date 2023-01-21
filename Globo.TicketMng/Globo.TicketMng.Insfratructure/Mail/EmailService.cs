using Globo.TicketMng.Application.Contracts.Insfratructure;
using Globo.TicketMng.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Insfratructure.Mail
{
    public class EmailService : IMailService
    {
        public Task<bool> SendMail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
