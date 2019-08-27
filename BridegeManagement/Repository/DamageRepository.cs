using BridegeManagement.Data;
using BridegeManagement.IRepository;
using BridegeManagement.Models;

namespace BridegeManagement.Repository
{
    public class DamageRepository : GenericRepository<Damage>, IDamageRepository
    {
        public DamageRepository(ApplicationDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
