namespace POO;

sealed class Bicicleta : IVehiculo
{
    private const double Velocidad = 10;
    private double _posicion;

    public void Mover(int segundos) => _posicion += Velocidad * segundos;

    public double Posicion() => _posicion;

    public void Reiniciar() => _posicion = 0;
}
