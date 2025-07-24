using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class CatGifController : ControllerBase
    {
        private readonly ICatFactService _factService;
        private readonly IGiphyService _gifService;
        private readonly IHistoryService _historyService;

        public CatGifController(
            ICatFactService factService,
            IGiphyService gifService,
            IHistoryService historyService)
        {
            _factService = factService;
            _gifService = gifService;
            _historyService = historyService;
        }

        [HttpGet("fact")]
        public async Task<IActionResult> GetFact()
        {
            try
            {
                var fact = await _factService.GetRandomFactAsync();
                return Ok(new { fact });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener el hecho: {ex.Message}");
            }
        }

        [HttpGet("gif")]
        public async Task<IActionResult> GetGif()
        {
            try
            {
                var fact = await _factService.GetRandomFactAsync();
                var query = string.Join(" ", fact.Split(' ').Take(3));
                var gifUrl = await _gifService.GetGifUrlAsync(query);

                var dto = new SearchHistoryDto
                {
                    FactCompleto = fact,
                    GifUrl = gifUrl,
                    TresPalabrasQuery = query,
                    FechaBusqueda = DateTime.UtcNow
                };

                await _historyService.SaveSearchAsync(dto);

                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Ocurrió un error al obtener el gif", details = ex.Message });
            }
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetHistory()
        {
            try
            {
                var result = await _historyService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener historial: {ex.Message}");
            }
        }
    }
}
