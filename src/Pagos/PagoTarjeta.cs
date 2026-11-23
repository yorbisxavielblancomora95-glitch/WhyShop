using System;

namespace WhyShop.Pagos
{
    public class PagoTarjeta : IEstrategiaPago
    {
        private readonly string _numeroTarjeta;
        private readonly string _titular;

        public string NombreMetodo => "Tarjeta de Crédito/Débito";

        public PagoTarjeta(string numeroTarjeta, string titular)
        {
            _numeroTarjeta = numeroTarjeta;
            _titular = titular;
        }

        public ResultadoPago ProcesarPago(decimal monto)
        {
            if (monto <= 0)
            {
                return new ResultadoPago(false, "Error: El monto a pagar debe ser mayor a cero.", monto);
            }

            if (string.IsNullOrWhiteSpace(_numeroTarjeta) || _numeroTarjeta.Length < 16)
            {
                return new ResultadoPago(false, "Alerta: Número de tarjeta inválido. Verifica los datos.", monto);
            }

            string codigo = $"TARJ-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
            return new ResultadoPago(true, $"Pago aprobado para {_titular} con {NombreMetodo}.", monto, codigo);
        }
    }
}
