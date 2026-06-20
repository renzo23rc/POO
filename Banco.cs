namespace POO;

sealed class Banco
{
    private readonly List<CuentaBancaria> _cuentas = [];

    public void Agregar(CuentaBancaria cuenta) => _cuentas.Add(cuenta);

    public void Transferir(CuentaBancaria origen, CuentaBancaria destino, decimal monto)
    {
        if (!_cuentas.Contains(origen))
        {
            Console.WriteLine("  ERROR: La cuenta origen no está registrada en el banco.");
            return;
        }
        if (!_cuentas.Contains(destino))
        {
            Console.WriteLine("  ERROR: La cuenta destino no está registrada en el banco.");
            return;
        }
        if (monto <= 0)
        {
            Console.WriteLine($"  ERROR: El monto a transferir debe ser positivo (${monto}).");
            return;
        }

        if (origen.Extraer(monto))
        {
            destino.Depositar(monto);
            Console.WriteLine($"  Transferencia de ${monto} realizada con éxito.");
        }
        else
        {
            Console.WriteLine("  Transferencia cancelada.");
        }
    }
}
