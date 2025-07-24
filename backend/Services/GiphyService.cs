using backend.Interfaces;

namespace backend.Services
{
    public class GiphyService : IGiphyService
    {
        private readonly HttpClient _http;
        private readonly string apiKey = "voaNIOg1u7ONPbckzWK71C48YqCOkhVP";

        public GiphyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetGifUrlAsync(string query)
        {
            try
            {
                var url = $"https://api.giphy.com/v1/gifs/search?api_key={apiKey}&q={query}&limit=1";
                var response = await _http.GetFromJsonAsync<GiphyResponse>(url);
                return response?.Data?.FirstOrDefault()?.Images?.Original?.Url ?? "Sin resultado";
            }
            catch (Exception ex)
            {
                // Logging opcional
                return $"Error al obtener GIF: {ex.Message}";
            }
        }


        private class GiphyResponse
        {
            public List<GifData> Data { get; set; }

            public class GifData
            {
                public GifImages Images { get; set; }
            }

            public class GifImages
            {
                public GifOriginal Original { get; set; }
            }

            public class GifOriginal
            {
                public string Url { get; set; }
            }
        }
    }
}
