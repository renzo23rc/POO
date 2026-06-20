namespace POO;

sealed class Carta(string palo, string numero)
{
    public string Palo { get; } = palo;
    public string Numero { get; } = numero;

    public override string ToString() => $"{Numero} de {Palo}";
}
