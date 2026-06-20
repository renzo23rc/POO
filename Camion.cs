namespace POO;

sealed class Camion : IVehiculo
{
    private const double Velocidad = 30;
    private double _posicion;

    public void Mover(int segundos) => _posicion += Velocidad * segundos;

    public double Posicion() => _posicion;

    public void Reiniciar() => _posicion = 0;
}
