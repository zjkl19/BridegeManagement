using BridegeManagement.Data;
using BridegeManagement.IRepository;
using BridegeManagement.Models;

namespace BridegeManagement.Repository
{
    public class BridgeRepository : GenericRepository<Bridge>, IBridgeRepository
    {
        public BridgeRepository(ApplicationDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
