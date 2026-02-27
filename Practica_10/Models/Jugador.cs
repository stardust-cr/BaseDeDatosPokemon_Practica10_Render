using System.ComponentModel.DataAnnotations;

namespace Practica_10
{
    public class Jugador
    {
        [Key]
        public int NumeroJugador { get; set; }
        [Required]
        public string Nombre { get; set; }

        //propiedad navegacional (1:N)
        public List<Pokemon> Pokemones { get; set; }

        //propiedad navegacional (1:1)
        public Consola Consola { get; set; }
    }
}
