namespace POO;

static class Carrera
{
    public static void Simular(IVehiculo a, IVehiculo b, int segundos)
    {
        a.Reiniciar();
        b.Reiniciar();

        a.Mover(segundos);
        b.Mover(segundos);

        double pa = a.Posicion();
        double pb = b.Posicion();

        Console.WriteLine($"  {a.GetType().Name}: {pa} metros");
        Console.WriteLine($"  {b.GetType().Name}: {pb} metros");

        if (pa > pb)
            Console.WriteLine($"  -> Ganó {a.GetType().Name}!");
        else if (pb > pa)
            Console.WriteLine($"  -> Ganó {b.GetType().Name}!");
        else
            Console.WriteLine("  -> Empate!");
    }
}
