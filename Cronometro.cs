namespace POO;

sealed class Cronometro
{
    private int _minutos;
    private int _segundos;

    public void Reiniciar()
    {
        _minutos = 0;
        _segundos = 0;
    }

    public void Avanzar()
    {
        _segundos++;
        if (_segundos > 59)
        {
            _segundos = 0;
            _minutos++;
        }
    }

    public string Tiempo()
    {
        if (_minutos == 0 && _segundos == 0) return "0 segundos";
        if (_minutos == 0) return $"{_segundos} segundos";
        if (_segundos == 0) return $"{_minutos} minutos";
        return $"{_minutos} minutos, {_segundos} segundos";
    }
}
