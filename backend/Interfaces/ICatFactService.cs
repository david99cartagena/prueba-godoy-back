namespace backend.Interfaces
{
    public interface ICatFactService
    {
        Task<string> GetRandomFactAsync();
    }
}
