namespace POO;

interface IJugador
{
    bool Correr(int minutos);
    bool EstaCansado();
    void Descansar(int minutos);
}
