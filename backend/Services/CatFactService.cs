using backend.Interfaces;

namespace backend.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _http;

        public CatFactService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetRandomFactAsync()
        {
            try
            {
                var response = await _http.GetFromJsonAsync<CatFactResponse>("https://catfact.ninja/fact");
                return response?.Fact ?? "No se encontró el fact.";
            }
            catch (Exception ex)
            {
                return $"Error al obtener el fact: {ex.Message}";
            }
        }

        private class CatFactResponse
        {
            public string Fact { get; set; }
        }
    }
}
