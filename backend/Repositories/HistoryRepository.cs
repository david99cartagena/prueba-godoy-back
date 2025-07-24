using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly AppDbContext _context;

        public HistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SearchHistory history)
        {
            _context.SearchHistories.Add(history);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SearchHistory>> GetAllAsync()
        {
            return await _context.SearchHistories
                .OrderByDescending(h => h.FechaBusqueda)
                .ToListAsync();
        }
    }
}
