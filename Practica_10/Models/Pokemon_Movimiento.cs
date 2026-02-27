namespace Practica_10
{
    public class Pokemon_Movimiento
    {
        //representa la relacion intermedia entre Pokemon y Movimiento
        public int NumPokemon { get; set; }
        public int NumMovimiento { get; set; }

        //propiedades navegacionales
        public Pokemon Pokemon { get; set; }
        public Movimiento Movimiento { get; set; }
    }
}
