using System.ComponentModel.DataAnnotations;

namespace Practica_10
{
    public class Movimiento
    {
        [Key]
        public int NumeroMovimiento { get; set; }
        [Required]
        public string Nombre { get; set; }

        public List<Pokemon> Pokemones { get; set; }

        //propiedad navegacional (N:M)
        public List<Pokemon_Movimiento> Pokemon_Movimientos { get; set; }

        
    }
}
