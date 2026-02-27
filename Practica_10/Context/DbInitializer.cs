namespace Practica_10.Context
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated(); //este método nos crea automáticamente
                                              //la BD sin migraciones, pero éstas son preferibles por si nuestro modelo
                                              //se va modificando
                                              // Comprueba si hay algún instituto
            if (context.Pokemon_Movimientos.Any())
            {
                return; // BD ya ha sido inicializada
            }
            //Añado institutos
            var jugadores = new Jugador[]
{
    new Jugador { Nombre = "Ash" },
    new Jugador { Nombre = "Jenny" },
    new Jugador { Nombre = "Misty" },
    new Jugador { Nombre = "Brock" },
    new Jugador { Nombre = "Iris" },
    new Jugador { Nombre = "Serena" },
    new Jugador { Nombre = "Dawn" },
    new Jugador { Nombre = "May" },
    new Jugador { Nombre = "N" },
    new Jugador { Nombre = "Hugh" },
    new Jugador { Nombre = "Cameron" }
};

            foreach (Jugador j in jugadores)
            {
                context.Jugadores.Add(j);
            }
            context.SaveChanges();
            //Añado estudiantes
            var consolas = new Consola[]
            {
                 new Consola {Descripcion = "Pokedex de Ash", JugadorId = 1 },
                 new Consola { Descripcion = "Pokedex de Jenny", JugadorId = 2 },
                 new Consola { Descripcion = "Pokedex de Misty", JugadorId = 3 },
                 new Consola { Descripcion = "Pokedex de Brock", JugadorId = 4 },
                 new Consola { Descripcion = "Pokedex de Iris", JugadorId = 5 },
                 new Consola {  Descripcion = "Pokedex de Serena", JugadorId = 6 },
                 new Consola { Descripcion = "Pokedex de Dawn", JugadorId = 7 },
                 new Consola { Descripcion = "Pokedex de May", JugadorId = 8 },
                 new Consola { Descripcion = "Pokedex de N", JugadorId = 9 },
                 new Consola { Descripcion = "Pokedex de Hugh", JugadorId = 10 },
                 new Consola { Descripcion = "Pokedex de Cameron", JugadorId = 11 }
            };

            foreach (Consola c in consolas)
            {
                context.Consolas.Add(c);
            }
            context.SaveChanges();

            //Añado cursos
            var movimientos = new Movimiento[]
            {
                 new Movimiento { Nombre = "Arañazo" },
    new Movimiento { Nombre = "Ascuas" },
    new Movimiento { Nombre = "Ataque aéreo" },
    new Movimiento { Nombre = "Ataque arena" },
    new Movimiento { Nombre = "Ataque rápido" },
    new Movimiento { Nombre = "Avivar" },
    new Movimiento { Nombre = "Ayuda" },
    new Movimiento { Nombre = "Bola sombra" },
    new Movimiento { Nombre = "Bomba fango" },
    new Movimiento { Nombre = "Bomba lodo" },
    new Movimiento { Nombre = "Bomba sónica" },
    new Movimiento { Nombre = "Bote" },
    new Movimiento { Nombre = "Brillo mágico" },
    new Movimiento { Nombre = "Bucle arena" },
    new Movimiento { Nombre = "Canto helado" },
    new Movimiento { Nombre = "Carga dragón" },
    new Movimiento { Nombre = "Chispa" },
    new Movimiento { Nombre = "Chispazo" },
    new Movimiento { Nombre = "Cola férrea" },
    new Movimiento { Nombre = "Colmillo hielo" },
    new Movimiento { Nombre = "Colmillo ígneo" },
    new Movimiento { Nombre = "Confusión" },
    new Movimiento { Nombre = "Copión" },
    new Movimiento { Nombre = "Corte" },
    new Movimiento { Nombre = "Daño secreto" },
    new Movimiento { Nombre = "Demolición" },
    new Movimiento { Nombre = "Derribo" },
    new Movimiento { Nombre = "Desarrollo" },
    new Movimiento { Nombre = "Destructor" },
    new Movimiento { Nombre = "Disparo demora" },
    new Movimiento { Nombre = "Disparo espejo" },
    new Movimiento { Nombre = "Doble bofetón" },
    new Movimiento { Nombre = "Doble equipo" },
    new Movimiento { Nombre = "Doble golpe" },
    new Movimiento { Nombre = "Dragoaliento" },
    new Movimiento { Nombre = "Drenadoras" },
    new Movimiento { Nombre = "Electro bola" },
    new Movimiento { Nombre = "Empujón" },
    new Movimiento { Nombre = "Encanto" },
    new Movimiento { Nombre = "Enfado" },
    new Movimiento { Nombre = "Escaldar" },
    new Movimiento { Nombre = "Esfera aural" },
    new Movimiento { Nombre = "Excavar" },
    new Movimiento { Nombre = "Finta" },
    new Movimiento { Nombre = "Furia dragón" },
    new Movimiento { Nombre = "Garra metal" },
    new Movimiento { Nombre = "Gigaimpacto" },
    new Movimiento { Nombre = "Golpe aéreo" },
    new Movimiento { Nombre = "Hidrobomba" },
    new Movimiento { Nombre = "Hoja aguda" },
    new Movimiento { Nombre = "Hoja mágica" },
    new Movimiento { Nombre = "Impactrueno" },
    new Movimiento { Nombre = "Lanzallamas" },
    new Movimiento { Nombre = "Látigo cepa" },
    new Movimiento { Nombre = "Llave giro" },
    new Movimiento { Nombre = "Malicioso" },
    new Movimiento { Nombre = "Megapuño" },
    new Movimiento { Nombre = "Meteoros" },
    new Movimiento { Nombre = "Mordisco" },
    new Movimiento { Nombre = "Ojitos tiernos" },
    new Movimiento { Nombre = "Onda certera" },
    new Movimiento { Nombre = "Onda trueno" },
    new Movimiento { Nombre = "Palmeo" },
    new Movimiento { Nombre = "Patada ígnea" },
    new Movimiento { Nombre = "Picotazo" },
    new Movimiento { Nombre = "Picotazo venenoso" },
    new Movimiento { Nombre = "Pin misil" },
    new Movimiento { Nombre = "Placaje" },
    new Movimiento { Nombre = "Plumerazo" },
    new Movimiento { Nombre = "Poder oculto" },
    new Movimiento { Nombre = "Psicocarga" },
    new Movimiento { Nombre = "Psicorrayo" },
    new Movimiento { Nombre = "Psíquico" },
    new Movimiento { Nombre = "Pulso dragón" },
    new Movimiento { Nombre = "Pulso umbrío" },
    new Movimiento { Nombre = "Puño hielo" },
    new Movimiento { Nombre = "Puño mareo" },
    new Movimiento { Nombre = "Puño trueno" },
    new Movimiento { Nombre = "Puya nociva" },
    new Movimiento { Nombre = "Rapidez" },
    new Movimiento { Nombre = "Rayo" },
    new Movimiento { Nombre = "Rayo burbuja" },
    new Movimiento { Nombre = "Rayo confuso" },
    new Movimiento { Nombre = "Rayo hielo" },
    new Movimiento { Nombre = "Rayo solar" },
    new Movimiento { Nombre = "Refuerzo" },
    new Movimiento { Nombre = "Roca afilada" },
    new Movimiento { Nombre = "Shuriken de agua" },
    new Movimiento { Nombre = "Sofoco" },
    new Movimiento { Nombre = "Superdiente" },
    new Movimiento { Nombre = "Tajo aéreo" },
    new Movimiento { Nombre = "Taladradora" },
    new Movimiento { Nombre = "Tormenta de arena" },
    new Movimiento { Nombre = "Tóxico" },
    new Movimiento { Nombre = "Triataque" },
    new Movimiento { Nombre = "Tumba rocas" },
    new Movimiento { Nombre = "Velo sagrado" },
    new Movimiento { Nombre = "Ventisca" },
    new Movimiento { Nombre = "Viento feérico" },
    new Movimiento { Nombre = "Viento hielo" },
    new Movimiento { Nombre = "Voltiocambio" }
            };
            foreach (Movimiento m in movimientos)
            {
                context.Movimientos.Add(m);
            }
            context.SaveChanges();

            //Añado direcciones
            var pokemones = new Pokemon[]
            {
                new Pokemon { Nombre = "Pikachu", Nivel = 15, JugadorId = 1 },
                new Pokemon { Nombre = "Greninja", Nivel = 36, JugadorId = 1 },
                new Pokemon { Nombre = "Espurr", Nivel = 20, JugadorId = 2 },
                new Pokemon { Nombre = "Emolga", Nivel = 40, JugadorId = 2 },
                new Pokemon { Nombre = "Arcanine", Nivel = 89, JugadorId = 2 },
                new Pokemon { Nombre = "Psyduck", Nivel = 34, JugadorId = 3 },
                new Pokemon { Nombre = "Staryu", Nivel = 20, JugadorId = 3 },
                new Pokemon { Nombre = "Onix", Nivel = 33, JugadorId = 4 },
                new Pokemon { Nombre = "Croagunk", Nivel = 34, JugadorId = 4 },
                new Pokemon { Nombre = "Axew", Nivel = 14, JugadorId = 5 },
                new Pokemon { Nombre = "Dragonite", Nivel = 70, JugadorId = 5 },
                new Pokemon { Nombre = "Emolga", Nivel = 45, JugadorId = 5 },
                new Pokemon { Nombre = "Fennekin", Nivel = 12, JugadorId = 6 },
                new Pokemon { Nombre = "Sylveon", Nivel = 45, JugadorId = 6 },
                new Pokemon { Nombre = "Pancham", Nivel = 20, JugadorId = 6 },
                new Pokemon { Nombre = "Piplup", Nivel = 22, JugadorId = 7 },
                new Pokemon { Nombre = "Buneary", Nivel = 21, JugadorId = 7 },
                new Pokemon { Nombre = "Blaziken", Nivel = 65, JugadorId = 8 },
                new Pokemon { Nombre = "Glaceon", Nivel = 35, JugadorId = 8 },
                new Pokemon { Nombre = "Skitty", Nivel = 10, JugadorId = 8 },
                new Pokemon { Nombre = "Zorua", Nivel = 30, JugadorId = 9 },
                new Pokemon { Nombre = "Hydreigon", Nivel = 60, JugadorId = 9 },
                new Pokemon { Nombre = "Tynamo", Nivel = 34, JugadorId = 10 },
                new Pokemon { Nombre = "Vibrava", Nivel = 78, JugadorId = 10 },
                new Pokemon { Nombre = "Riolu", Nivel = 40, JugadorId = 11 },
                new Pokemon { Nombre = "Hydreigon", Nivel = 65, JugadorId = 11 }
};

            foreach (Pokemon p in pokemones)
            {
                context.Pokemones.Add(p);
            }
            context.SaveChanges();

            //Añado EstudianteCursos


            var pokemon_Movimientos = new Pokemon_Movimiento[]
{
    new Pokemon_Movimiento { NumPokemon = 1, NumMovimiento = 17 },
    new Pokemon_Movimiento { NumPokemon = 1, NumMovimiento = 19 },
    new Pokemon_Movimiento { NumPokemon = 1, NumMovimiento = 52 },
    new Pokemon_Movimiento { NumPokemon = 1, NumMovimiento = 81 },

    new Pokemon_Movimiento { NumPokemon = 2, NumMovimiento = 41 },
    new Pokemon_Movimiento { NumPokemon = 2, NumMovimiento = 56 },
    new Pokemon_Movimiento { NumPokemon = 2, NumMovimiento = 88 },
    new Pokemon_Movimiento { NumPokemon = 2, NumMovimiento = 95 },

    new Pokemon_Movimiento { NumPokemon = 3, NumMovimiento = 58 },
    new Pokemon_Movimiento { NumPokemon = 3, NumMovimiento = 71 },
    new Pokemon_Movimiento { NumPokemon = 3, NumMovimiento = 72 },
    new Pokemon_Movimiento { NumPokemon = 3, NumMovimiento = 73 },

    new Pokemon_Movimiento { NumPokemon = 4, NumMovimiento = 17 },
    new Pokemon_Movimiento { NumPokemon = 4, NumMovimiento = 48 },
    new Pokemon_Movimiento { NumPokemon = 4, NumMovimiento = 80 },
    new Pokemon_Movimiento { NumPokemon = 4, NumMovimiento = 81 },

    new Pokemon_Movimiento { NumPokemon = 5, NumMovimiento = 21 },
    new Pokemon_Movimiento { NumPokemon = 5, NumMovimiento = 27 },
    new Pokemon_Movimiento { NumPokemon = 5, NumMovimiento = 53 },
    new Pokemon_Movimiento { NumPokemon = 5, NumMovimiento = 59 },

    new Pokemon_Movimiento { NumPokemon = 6, NumMovimiento = 41 },
    new Pokemon_Movimiento { NumPokemon = 6, NumMovimiento = 49 },
    new Pokemon_Movimiento { NumPokemon = 6, NumMovimiento = 73 },
    new Pokemon_Movimiento { NumPokemon = 6, NumMovimiento = 82 },

    new Pokemon_Movimiento { NumPokemon = 7, NumMovimiento = 41 },
    new Pokemon_Movimiento { NumPokemon = 7, NumMovimiento = 49 },
    new Pokemon_Movimiento { NumPokemon = 7, NumMovimiento = 72 },
    new Pokemon_Movimiento { NumPokemon = 7, NumMovimiento = 82 },

    new Pokemon_Movimiento { NumPokemon = 8, NumMovimiento = 26 },
    new Pokemon_Movimiento { NumPokemon = 8, NumMovimiento = 43 },
    new Pokemon_Movimiento { NumPokemon = 8, NumMovimiento = 87 },
    new Pokemon_Movimiento { NumPokemon = 8, NumMovimiento = 96 },

    new Pokemon_Movimiento { NumPokemon = 9, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 9, NumMovimiento = 77 },
    new Pokemon_Movimiento { NumPokemon = 9, NumMovimiento = 79 },
    new Pokemon_Movimiento { NumPokemon = 9, NumMovimiento = 94 },

    new Pokemon_Movimiento { NumPokemon = 10, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 10, NumMovimiento = 35 },
    new Pokemon_Movimiento { NumPokemon = 10, NumMovimiento = 45 },
    new Pokemon_Movimiento { NumPokemon = 10, NumMovimiento = 74 },

    new Pokemon_Movimiento { NumPokemon = 11, NumMovimiento = 35 },
    new Pokemon_Movimiento { NumPokemon = 11, NumMovimiento = 45 },
    new Pokemon_Movimiento { NumPokemon = 11, NumMovimiento = 47 },
    new Pokemon_Movimiento { NumPokemon = 11, NumMovimiento = 48 },

    new Pokemon_Movimiento { NumPokemon = 12, NumMovimiento = 17 },
    new Pokemon_Movimiento { NumPokemon = 12, NumMovimiento = 48 },
    new Pokemon_Movimiento { NumPokemon = 12, NumMovimiento = 80 },
    new Pokemon_Movimiento { NumPokemon = 12, NumMovimiento = 81 },

    new Pokemon_Movimiento { NumPokemon = 13, NumMovimiento = 21 },
    new Pokemon_Movimiento { NumPokemon = 13, NumMovimiento = 53 },
    new Pokemon_Movimiento { NumPokemon = 13, NumMovimiento = 64 },
    new Pokemon_Movimiento { NumPokemon = 13, NumMovimiento = 90 },

    new Pokemon_Movimiento { NumPokemon = 14, NumMovimiento = 13 },
    new Pokemon_Movimiento { NumPokemon = 14, NumMovimiento = 39 },
    new Pokemon_Movimiento { NumPokemon = 14, NumMovimiento = 70 },
    new Pokemon_Movimiento { NumPokemon = 14, NumMovimiento = 99 },

    new Pokemon_Movimiento { NumPokemon = 15, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 15, NumMovimiento = 34 },
    new Pokemon_Movimiento { NumPokemon = 15, NumMovimiento = 57 },
    new Pokemon_Movimiento { NumPokemon = 15, NumMovimiento = 77 },

    new Pokemon_Movimiento { NumPokemon = 16, NumMovimiento = 41 },
    new Pokemon_Movimiento { NumPokemon = 16, NumMovimiento = 49 },
    new Pokemon_Movimiento { NumPokemon = 16, NumMovimiento = 70 },
    new Pokemon_Movimiento { NumPokemon = 16, NumMovimiento = 82 },

    new Pokemon_Movimiento { NumPokemon = 17, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 17, NumMovimiento = 32 },
    new Pokemon_Movimiento { NumPokemon = 17, NumMovimiento = 63 },
    new Pokemon_Movimiento { NumPokemon = 17, NumMovimiento = 68 },

    new Pokemon_Movimiento { NumPokemon = 18, NumMovimiento = 47 },
    new Pokemon_Movimiento { NumPokemon = 18, NumMovimiento = 53 },
    new Pokemon_Movimiento { NumPokemon = 18, NumMovimiento = 64 },
    new Pokemon_Movimiento { NumPokemon = 18, NumMovimiento = 77 },

    new Pokemon_Movimiento { NumPokemon = 19, NumMovimiento = 15 },
    new Pokemon_Movimiento { NumPokemon = 19, NumMovimiento = 68 },
    new Pokemon_Movimiento { NumPokemon = 19, NumMovimiento = 84 },
    new Pokemon_Movimiento { NumPokemon = 19, NumMovimiento = 100 },

    new Pokemon_Movimiento { NumPokemon = 20, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 20, NumMovimiento = 32 },
    new Pokemon_Movimiento { NumPokemon = 20, NumMovimiento = 39 },
    new Pokemon_Movimiento { NumPokemon = 20, NumMovimiento = 68 },

    new Pokemon_Movimiento { NumPokemon = 21, NumMovimiento = 22 },
    new Pokemon_Movimiento { NumPokemon = 21, NumMovimiento = 23 },
    new Pokemon_Movimiento { NumPokemon = 21, NumMovimiento = 70 },
    new Pokemon_Movimiento { NumPokemon = 21, NumMovimiento = 71 },

    new Pokemon_Movimiento { NumPokemon = 22, NumMovimiento = 35 },
    new Pokemon_Movimiento { NumPokemon = 22, NumMovimiento = 45 },
    new Pokemon_Movimiento { NumPokemon = 22, NumMovimiento = 75 },
    new Pokemon_Movimiento { NumPokemon = 22, NumMovimiento = 95 },

    new Pokemon_Movimiento { NumPokemon = 23, NumMovimiento = 17 },
    new Pokemon_Movimiento { NumPokemon = 23, NumMovimiento = 52 },
    new Pokemon_Movimiento { NumPokemon = 23, NumMovimiento = 80 },
    new Pokemon_Movimiento { NumPokemon = 23, NumMovimiento = 81 },

    new Pokemon_Movimiento { NumPokemon = 24, NumMovimiento = 34 },
    new Pokemon_Movimiento { NumPokemon = 24, NumMovimiento = 44 },
    new Pokemon_Movimiento { NumPokemon = 24, NumMovimiento = 45 },
    new Pokemon_Movimiento { NumPokemon = 24, NumMovimiento = 48 },

    new Pokemon_Movimiento { NumPokemon = 25, NumMovimiento = 24 },
    new Pokemon_Movimiento { NumPokemon = 25, NumMovimiento = 34 },
    new Pokemon_Movimiento { NumPokemon = 25, NumMovimiento = 57 },
    new Pokemon_Movimiento { NumPokemon = 25, NumMovimiento = 77 },

    new Pokemon_Movimiento { NumPokemon = 26, NumMovimiento = 35 },
    new Pokemon_Movimiento { NumPokemon = 26, NumMovimiento = 45 },
    new Pokemon_Movimiento { NumPokemon = 26, NumMovimiento = 75 },
    new Pokemon_Movimiento { NumPokemon = 26, NumMovimiento = 95 }
};


            foreach (Pokemon_Movimiento pm in pokemon_Movimientos)
            {
                context.Pokemon_Movimientos.AddRange(pm);
                
            }
            context.SaveChanges();
        }
    }
    }

