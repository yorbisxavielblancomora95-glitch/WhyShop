using System;

namespace WhyShop.Pagos
{
    public class PagoTransferencia : IEstrategiaPago
    {
        private readonly string _numeroCuenta;
        private readonly string _banco;

        public string NombreMetodo => "Transferencia Bancaria";

        public PagoTransferencia(string numeroCuenta, string banco)
        {
            _numeroCuenta = numeroCuenta;
            _banco = banco;
        }

        public ResultadoPago ProcesarPago(decimal monto)
        {
            if (monto <= 0)
            {
                return new ResultadoPago(false, "Error: El monto de la transferencia debe ser mayor a cero.", monto);
            }

            if (string.IsNullOrWhiteSpace(_numeroCuenta))
            {
                return new ResultadoPago(false, "Alerta: Debe indicar un número de cuenta válido.", monto);
            }

            string codigo = $"TRANS-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
            return new ResultadoPago(true, $"Transferencia validada desde {_banco}.", monto, codigo);
        }
    }
}
