using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Infrastructure.DataAcess.Repositories
{
    public class UserRepository
    {
        private readonly FeiraTechDbContext _context;

        public UserRepository(FeiraTechDbContext context)
        {
            _context = context;
        }

        public async Task Add(FeiraTech.Domain.Entity.User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<bool> EmailIsExists(string email)
        {
            return await _context.Users.AnyAsync(user => user.Email.Equals(email) && user.Active);

        }
    }
}
