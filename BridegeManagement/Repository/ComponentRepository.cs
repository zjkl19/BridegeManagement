using BridegeManagement.Data;
using BridegeManagement.IRepository;
using BridegeManagement.Models;

namespace BridegeManagement.Repository
{
    public class ComponentRepository : GenericRepository<Component>, IComponentRepository
    {
        public ComponentRepository(ApplicationDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
