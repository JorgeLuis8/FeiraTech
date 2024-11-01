using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Domain.Repositorie.User
{
    public interface IUserReadOnlyRepository
    {
        public Task<bool> EmailIsExists(string email);


    }
}
