using System;
using System.Threading;

namespace fabricantevendedor
{
    public class Fabricante
    {
        private int _cantidad;

        private int _periodicidad;

        private Almacen _a;
        private Thread _t;
        private Random _rnd = new Random();
        public Fabricante(Almacen a, int cantidad, int periodicidad)
        {
            this._a = a;
            this._cantidad = cantidad;
            this._periodicidad = periodicidad;
        }

        public void Fabrica()
        {
            this._t = new Thread(() => this._Accion());
            this._t.Start();
        }

        public void Termina()
        {
            _t.Join();
        }

        private void _Accion()
        {
            int ms;
            for (int i = 0; i < _cantidad; i++)
            {
                ms = _periodicidad;
                Thread.Sleep(ms);
                _a.Guardar();
            }
        }
    }

}