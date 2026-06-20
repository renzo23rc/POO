namespace POO;

sealed class Mazo
{
    private readonly Stack<Carta> _cartas = [];

    private static readonly string[] Palos = ["Espadas", "Bastos", "Oros", "Copas"];
    private static readonly string[] Numeros = ["1", "2", "3", "4", "5", "6", "7",
                                                  "Sota", "Caballo", "Rey"];

    public Mazo()
    {
        foreach (string palo in Palos)
            foreach (string numero in Numeros)
                _cartas.Push(new Carta(palo, numero));
    }

    public void Barajar()
    {
        Carta[] monton = _cartas.ToArray();
        Random azar = new();

        for (int i = monton.Length - 1; i > 0; i--)
        {
            int j = azar.Next(i + 1);
            (monton[i], monton[j]) = (monton[j], monton[i]);
        }

        _cartas.Clear();
        foreach (Carta c in monton)
            _cartas.Push(c);
    }

    public Carta Robar()
    {
        if (_cartas.Count == 0)
            throw new InvalidOperationException("No quedan cartas en el mazo.");

        return _cartas.Pop();
    }

    public int CartasRestantes() => _cartas.Count;
}
