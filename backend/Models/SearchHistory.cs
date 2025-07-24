namespace backend.Models
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public DateTime FechaBusqueda { get; set; }
        public string FactCompleto { get; set; }
        public string TresPalabrasQuery { get; set; }
        public string GifUrl { get; set; }
    }
}
