using System.ComponentModel.DataAnnotations;

namespace Practica_10
{
    public class Pokemon
    {
        [Key]
        public int NumeroPokemon { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }

        public int JugadorId {  get; set; }

        //propiedad navegacional
        public Jugador Jugador { get; set; }

        //propiedad navegacional(N:M)
        //public List<Pokemon_Movimiento> Pokemon_Movimientos { get; set; }
        
        public List<Movimiento> Movimientos { get; set; }
       
        //propiedad navegacional (List) a la entidad intermedia
        public List<Pokemon_Movimiento> Pokemon_Movimientos {  get; set; }
    }
}
