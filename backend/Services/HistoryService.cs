using backend.DTOs;
using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _repo;

        public HistoryService(IHistoryRepository repo)
        {
            _repo = repo;
        }

        public async Task SaveSearchAsync(SearchHistoryDto dto)
        {
            try
            {
                var item = new SearchHistory
                {
                    FactCompleto = dto.FactCompleto,
                    TresPalabrasQuery = dto.TresPalabrasQuery,
                    GifUrl = dto.GifUrl,
                    FechaBusqueda = dto.FechaBusqueda
                };

                await _repo.AddAsync(item);
            }
            catch (Exception ex)
            {
                // Logging o manejo personalizado
                throw new Exception("Error al guardar historial", ex);
            }
        }

        public async Task<IEnumerable<SearchHistoryDto>> GetAllAsync()
        {
            var items = await _repo.GetAllAsync();
            return items.Select(h => new SearchHistoryDto
            {
                FactCompleto = h.FactCompleto,
                GifUrl = h.GifUrl,
                FechaBusqueda = h.FechaBusqueda,
                TresPalabrasQuery = h.TresPalabrasQuery
            });
        }
    }
}
