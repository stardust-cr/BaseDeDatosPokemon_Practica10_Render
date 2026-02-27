using System.ComponentModel.DataAnnotations;

namespace Practica_10
{
    public class Consola
    {
        [Key]
        public int ConsolaNumero { get; set; }
        [MaxLength(100),MinLength(5)]
        public string Descripcion { get; set; }

        public int JugadorId { get; set; }

        public Jugador Jugador { get; set; }
    }
}
