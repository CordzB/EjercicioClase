using EjercicioClase;

class Program
{
    static void Main(string[] args)
    {
        
        SuperPoder superFuerza = new SuperPoder { Nombre = "Super Fuerza", Descripcion = "Capacidad de levantar objetos muy pesados", Nivel = 9 };
        SuperPoder MultiMillonario = new SuperPoder { Nombre = "MultiMillonario", Descripcion = "Tiene Mucho dinero y Mucha Tecnologia", Nivel = 10 };
        SuperPoder velocidad = new SuperPoder { Nombre = "Velocidad", Descripcion = "Capacidad de moverse extremadamente rápido", Nivel = 8 };

    
        SuperHeroe superman = new SuperHeroe
        {
            Nombre = "Superman",
            IdentidadSecreta = "Clark Kent",
            Ciudad = "Metrópolis",
            PuedeVolar = true,
            SuperPoder = superFuerza
        };

        SuperHeroe batman = new SuperHeroe
        {
            Nombre = "Batman",
            IdentidadSecreta = "Bruce Wayne",
            Ciudad = "Gotham",
            PuedeVolar = false,
            SuperPoder = MultiMillonario
        };

        SuperHeroe flash = new SuperHeroe
        {
            Nombre = "Flash",
            IdentidadSecreta = "Barry Allen",
            Ciudad = "Central City",
            PuedeVolar = false,
            SuperPoder = velocidad
        };

        
        superman.MostrarInformacion();
        batman.MostrarInformacion();
        flash.MostrarInformacion();
    }
}
