namespace backend.Interfaces
{
    public interface IGiphyService
    {
        Task<string> GetGifUrlAsync(string query);
        // Task<string> GetGifUrlAsync(string[] keywords);
    }
}
