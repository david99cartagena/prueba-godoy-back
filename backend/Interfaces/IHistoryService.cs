using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend.DTOs;

namespace backend.Interfaces
{
    public interface IHistoryService
    {
        // Task SaveSearchAsync(string fact, string query, string gifUrl);
        // Task<List<SearchHistory>> GetHistoryAsync();
        Task SaveSearchAsync(SearchHistoryDto dto);
        Task<IEnumerable<SearchHistoryDto>> GetAllAsync();
    }
}
