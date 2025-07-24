using backend.Models;

namespace backend.Interfaces
{
    public interface IHistoryRepository
    {
        Task AddAsync(SearchHistory history);
        Task<List<SearchHistory>> GetAllAsync();
    }
}
