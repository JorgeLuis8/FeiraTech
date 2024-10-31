using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Communication.Requests
{
    public class RequestRegisterUserJson
    {
        string Name { get; set; } = string.Empty;
        string Email { get; set; } = string.Empty;
        string Password { get; set; } = string.Empty;
        string CPF { get; set; } = string.Empty;
        string Phone { get; set; } = string.Empty;

    }
}
