namespace POO;

abstract class CuentaBancaria
{
    private decimal _saldo;

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine($"  ERROR: No se puede depositar ${monto}. El monto debe ser positivo.");
            return;
        }
        _saldo += monto;
    }

    public virtual bool Extraer(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine($"  ERROR: Monto ${monto} inválido para extraer.");
            return false;
        }

        if (monto > _saldo)
        {
            Console.WriteLine($"  ERROR: Saldo insuficiente. Disponible: ${_saldo}, solicitado: ${monto}");
            return false;
        }

        _saldo -= monto;
        return true;
    }

    public void MostrarSaldo() => Console.WriteLine($"  Saldo: ${_saldo}");

    protected decimal Saldo => _saldo;
    protected void Descontar(decimal monto) => _saldo -= monto;
}
