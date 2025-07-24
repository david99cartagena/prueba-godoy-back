using System;

namespace backend.Models
{
    /// <summary>
    /// Representa un historial de búsqueda con información del fact y el gif.
    /// </summary>
    public class SearchHistory
    {
        /// <summary>
        /// Identificador único de la búsqueda.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha y hora en la que se realizó la búsqueda.
        /// </summary>
        public DateTime FechaBusqueda { get; set; }

        /// <summary>
        /// Contenido completo del fact devuelto.
        /// </summary>
        public string FactCompleto { get; set; }

        /// <summary>
        /// Tres palabras aleatorias que se usaron como búsqueda para el gif.
        /// </summary>
        public string TresPalabrasQuery { get; set; }

        /// <summary>
        /// URL del gif asociado a la búsqueda.
        /// </summary>
        public string GifUrl { get; set; }
    }
}