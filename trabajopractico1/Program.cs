using System;

enum TipoPlaneta
{
    GASEOSO,
    TERRESTRE,
    ENANO
}

class Planeta
{
    // Atributos
    public string Nombre { get; set; }
    public int CantidadSatelites { get; set; }
    public double Masa { get; set; }
    public double Volumen { get; set; }
    public int Diametro { get; set; }
    public int DistanciaMediaSol { get; set; }
    public TipoPlaneta Tipo { get; set; }
    public bool ObservableASimpleVista { get; set; }

    // Constructor
    public Planeta(string nombre, int cantidadSatelites, double masa, double volumen,
                   int diametro, int distanciaMediaSol, TipoPlaneta tipo,
                   bool observableASimpleVista)
    {
        Nombre = nombre;
        CantidadSatelites = cantidadSatelites;
        Masa = masa;
        Volumen = volumen;
        Diametro = diametro;
        DistanciaMediaSol = distanciaMediaSol;
        Tipo = tipo;
        ObservableASimpleVista = observableASimpleVista;
    }

    // Método para imprimir los valores de los atributos
    public void ImprimirDatos()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Cantidad de satélites: " + CantidadSatelites);
        Console.WriteLine("Masa: " + Masa + " kg");
        Console.WriteLine("Volumen: " + Volumen + " km³");
        Console.WriteLine("Diámetro: " + Diametro + " km");
        Console.WriteLine("Distancia media al Sol: " + DistanciaMediaSol + " millones de km");
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Observable a simple vista: " + ObservableASimpleVista);
    }

    // Método para calcular la densidad
    public double CalcularDensidad()
    {
        return Masa / Volumen;
    }

    // Método para determinar si el planeta es exterior al cinturón de asteroides
    public bool EsExterior()
    {
        double distanciaEnUA = DistanciaMediaSol / 149597870.0; // Convertir a UA
        return distanciaEnUA > 3.4 || distanciaEnUA < 2.1;
    }
}

class Program
{
    static void Main()
    {
        Planeta tierra = new Planeta("Tierra", 1, 5.972e24, 108321e6, 12742, 149_600,
                                     TipoPlaneta.TERRESTRE, true);

        tierra.ImprimirDatos();
        Console.WriteLine("Densidad: " + tierra.CalcularDensidad() + " kg/km³");
        Console.WriteLine("¿Es exterior al cinturón de asteroides? " + tierra.EsExterior());
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
