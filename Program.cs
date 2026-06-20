using POO;

// ── Mazo de cartas ──
Console.WriteLine("═══ MAZO DE CARTAS ═══");
Mazo mazo = new();
Console.WriteLine($"Cartas en el mazo: {mazo.CartasRestantes()}");
mazo.Barajar();

Mano mano = new();
mano.Recibir(mazo.Robar());
mano.Recibir(mazo.Robar());
mano.Recibir(mazo.Robar());
Console.WriteLine("Mano del jugador:");
mano.Mostrar();
Console.WriteLine($"Cartas restantes: {mazo.CartasRestantes()}");

// ── Banco ──
Console.WriteLine("\n═══ BANCO ═══");
CajaDeAhorro ca = new();
CuentaCorriente cc = new(limiteDescubierto: 500);
Banco banco = new();

banco.Agregar(ca);
banco.Agregar(cc);

ca.Depositar(1000);
cc.Depositar(300);

Console.WriteLine("Antes de la transferencia:");
ca.MostrarSaldo();
cc.MostrarSaldo();

banco.Transferir(ca, cc, 200);

Console.WriteLine("Después de la transferencia:");
ca.MostrarSaldo();
cc.MostrarSaldo();

// ── Carrera ──
Console.WriteLine("\n═══ CARRERA ═══");
Auto auto = new(velocidad: 45);
Bicicleta bici = new();
Carrera.Simular(auto, bici, segundos: 10);

// ── Jugadores ──
Console.WriteLine("\n═══ JUGADORES ═══");
Aficionado aficionado = new();
Profesional profesional = new();

Console.WriteLine($"Aficionado corre 15 min: {(aficionado.Correr(15) ? "OK" : "No pudo")}");
Console.WriteLine($"Aficionado cansado: {aficionado.EstaCansado()}");
Console.WriteLine($"Aficionado corre 10 min: {(aficionado.Correr(10) ? "OK" : "No pudo")}");

Console.WriteLine($"Profesional corre 35 min: {(profesional.Correr(35) ? "OK" : "No pudo")}");
Console.WriteLine($"Profesional cansado: {profesional.EstaCansado()}");

aficionado.Descansar(30);
Console.WriteLine($"Aficionado descansó 30 min. Cansado: {aficionado.EstaCansado()}");

// ── Cronómetro ──
Console.WriteLine("\n═══ CRONÓMETRO ═══");
Cronometro crono = new();
for (int i = 0; i < 125; i++)
    crono.Avanzar();
Console.WriteLine($"Tiempo: {crono.Tiempo()}");

// ── Semáforo ──
Console.WriteLine("\n═══ SEMÁFORO ═══");
Semaforo semaforo = new("Rojo");
Console.WriteLine($"Inicial: {semaforo.MostrarColor()}");

semaforo.Avanzar(20);
Console.WriteLine($"Luego de 20s: {semaforo.MostrarColor()}");

semaforo.Avanzar(15);
Console.WriteLine($"Luego de 15s más: {semaforo.MostrarColor()}");

semaforo.PonerEnIntermitente();
semaforo.Avanzar(3);
Console.WriteLine($"Intermitente +3s: {semaforo.MostrarColor()}");

semaforo.SacarDeIntermitente();
Console.WriteLine($"Vuelve de intermitente: {semaforo.MostrarColor()}");
