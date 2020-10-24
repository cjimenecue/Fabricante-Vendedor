﻿using System;

namespace fabricantevendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIO");
            Almacen almacen = new Almacen();
            Fabricante fabricante = new Fabricante(almacen, 8, 500);
            Vendedor vendedor1 = new Vendedor(almacen, 3, 800);
            Vendedor vendedor2 = new Vendedor(almacen, 3, 1000);
            Vendedor vendedor3 = new Vendedor(almacen, 2, 1200);
            fabricante.Fabrica();
            vendedor1.Vende();
            vendedor2.Vende();
            vendedor3.Vende();
            fabricante.Termina();
            vendedor1.Termina();
            vendedor2.Termina();
            vendedor3.Termina();
            Console.WriteLine("FIN");
        }
    }
}

// > dotnet run
// INICIO
// | 5  1105 Bloqueo. Almacen 0
// + 4  1735 Guarda.  Almacen 1
// - 5  1736 Saca.    Almacen 0
// | 5  3102 Bloqueo. Almacen 0
// + 4  3148 Guarda.  Almacen 1
// - 5  3148 Saca.    Almacen 0
// | 5  4337 Bloqueo. Almacen 0
// + 4  4529 Guarda.  Almacen 1
// - 5  4529 Saca.    Almacen 0
// | 5  5783 Bloqueo. Almacen 0
// + 4  6086 Guarda.  Almacen 1
// - 5  6086 Saca.    Almacen 0
// + 4  7123 Guarda.  Almacen 1
// - 5  7579 Saca.    Almacen 0
// + 4  8137 Guarda.  Almacen 1
// - 5  8835 Saca.    Almacen 0
// + 4  9405 Guarda.  Almacen 1
// - 5 10106 Saca.    Almacen 0
// + 4 11289 Guarda.  Almacen 1
// - 5 11431 Saca.    Almacen 0
// | 5 12556 Bloqueo. Almacen 0
// + 4 13180 Guarda.  Almacen 1
// - 5 13180 Saca.    Almacen 0
// | 5 14422 Bloqueo. Almacen 0
// + 4 14731 Guarda.  Almacen 1
// - 5 14731 Saca.    Almacen 0
// FIN