using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; } = true;
        public string? Message { get; set; }
        public List<string>? ValidationErrors { get; set; }
    }
}
