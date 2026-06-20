namespace POO;

sealed class Mano
{
    private readonly List<Carta> _cartas = [];

    public void Recibir(Carta carta) => _cartas.Add(carta);

    public void Mostrar()
    {
        if (_cartas.Count == 0)
        {
            Console.WriteLine("  (Mano vacía)");
            return;
        }

        foreach (Carta c in _cartas)
            Console.WriteLine($"  - {c}");
    }

    public int Cantidad() => _cartas.Count;
}
