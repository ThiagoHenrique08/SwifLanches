using Microsoft.EntityFrameworkCore;
using SwifLanches.Context;
using SwifLanches.Models;
using SwifLanches.Repositories.Interfaces;


namespace SwifLanches.Repositories
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LanchesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
           return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
;        
        }
    }
}
