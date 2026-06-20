namespace POO;

sealed class CuentaCorriente : CuentaBancaria
{
    private readonly decimal _limiteDescubierto;

    public CuentaCorriente(decimal limiteDescubierto)
    {
        _limiteDescubierto = limiteDescubierto;
    }

    public override bool Extraer(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine($"  ERROR: Monto ${monto} inválido para extraer.");
            return false;
        }

        if (Saldo - monto < -_limiteDescubierto)
        {
            Console.WriteLine($"  ERROR: Supera el límite de descubierto (${_limiteDescubierto}). " +
                              $"Saldo: ${Saldo}, solicitado: ${monto}");
            return false;
        }

        Descontar(monto);
        return true;
    }
}
