namespace POO;

sealed class EstadoSemaforo(string nombre, int duracionSegundos)
{
    public string Nombre { get; } = nombre;
    public int DuracionSegundos { get; } = duracionSegundos;
}
