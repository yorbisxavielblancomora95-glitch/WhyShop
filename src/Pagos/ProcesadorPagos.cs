using System;

namespace WhyShop.Pagos
{
    public class ProcesadorPagos
    {
        private IEstrategiaPago _estrategia;

        public ProcesadorPagos(IEstrategiaPago estrategia)
        {
            _estrategia = estrategia ?? throw new ArgumentNullException(nameof(estrategia));
        }

        // Permite cambiar el método de pago en tiempo de ejecución
        public void EstablecerEstrategia(IEstrategiaPago nuevaEstrategia)
        {
            _estrategia = nuevaEstrategia ?? throw new ArgumentNullException(nameof(nuevaEstrategia));
        }

        public ResultadoPago EjecutarPago(decimal monto)
        {
            return _estrategia.ProcesarPago(monto);
        }
    }
}
