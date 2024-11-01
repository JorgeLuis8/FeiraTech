using FeiraTech.Domain.Repositorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Infrastructure.DataAcess
{
    public class UnitOfWork : IUnitOfWork
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
