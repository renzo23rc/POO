namespace POO;

sealed class Auto : IVehiculo
{
    private readonly double _velocidad;
    private double _posicion;

    public Auto(double velocidad = 40) => _velocidad = velocidad;

    public void Mover(int segundos) => _posicion += _velocidad * segundos;

    public double Posicion() => _posicion;

    public void Reiniciar() => _posicion = 0;
}
