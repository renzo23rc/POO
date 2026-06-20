namespace POO;

abstract class JugadorBase : IJugador
{
    private readonly int _resistenciaMaxima;
    private int _fatiga;

    protected JugadorBase(int resistenciaMaxima) => _resistenciaMaxima = resistenciaMaxima;

    public bool Correr(int minutos)
    {
        if (EstaCansado()) return false;

        int corrido = Math.Min(minutos, _resistenciaMaxima - _fatiga);
        _fatiga += corrido;
        return corrido == minutos;
    }

    public bool EstaCansado() => _fatiga >= _resistenciaMaxima;

    public void Descansar(int minutos)
    {
        _fatiga = Math.Max(0, _fatiga - minutos);
    }
}
