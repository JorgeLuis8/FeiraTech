using FeiraTech.Infrastructure.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Infrastructure.DataAcess.Repositories
{
    public class UnitOfWork
    {
        private readonly FeiraTechDbContext _context;

        public UnitOfWork(FeiraTechDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
