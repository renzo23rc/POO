namespace POO;

sealed class Semaforo
{
    private static readonly EstadoSemaforo[] Secuencia = [
        new("Rojo", 30),
        new("Rojo + Amarillo", 2),
        new("Verde", 20),
        new("Amarillo", 2)
    ];

    private int _estadoActual;
    private int _segundosTranscurridos;
    private bool _intermitente;

    private int _estadoPrevio;
    private int _segundosPrevios;

    public Semaforo(string colorInicial)
    {
        for (int i = 0; i < Secuencia.Length; i++)
        {
            if (Secuencia[i].Nombre == colorInicial)
            {
                _estadoActual = i;
                return;
            }
        }
        throw new ArgumentException(
            $"Color '{colorInicial}' no válido. Usar: Rojo, Rojo + Amarillo, Verde o Amarillo.");
    }

    public void Avanzar(int segundos)
    {
        if (_intermitente)
        {
            _segundosTranscurridos += segundos;
            return;
        }

        int restantes = segundos;
        while (restantes > 0)
        {
            int disponibles = Secuencia[_estadoActual].DuracionSegundos - _segundosTranscurridos;

            if (restantes < disponibles)
            {
                _segundosTranscurridos += restantes;
                restantes = 0;
            }
            else
            {
                restantes -= disponibles;
                _estadoActual = (_estadoActual + 1) % Secuencia.Length;
                _segundosTranscurridos = 0;
            }
        }
    }

    public string MostrarColor()
    {
        if (_intermitente)
            return _segundosTranscurridos % 2 == 0 ? "Amarillo" : "Apagado";

        return Secuencia[_estadoActual].Nombre;
    }

    public void PonerEnIntermitente()
    {
        if (_intermitente) return;

        _intermitente = true;
        _estadoPrevio = _estadoActual;
        _segundosPrevios = _segundosTranscurridos;
        _segundosTranscurridos = 0;
    }

    public void SacarDeIntermitente()
    {
        if (!_intermitente) return;

        _intermitente = false;
        _estadoActual = _estadoPrevio;
        _segundosTranscurridos = _segundosPrevios;
    }
}
