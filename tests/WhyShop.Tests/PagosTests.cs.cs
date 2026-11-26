using Xunit;
using WhyShop.Pagos;

namespace WhyShop.Tests
{
    public class PagosTests
    {
        // CP-01: Unitaria - Escenario correcto con tarjeta
        [Fact]
        public void PagoTarjeta_DatosValidos_DebeAprobarPago()
        {
            var estrategia = new PagoTarjeta("4532123456789012", "Gabriel Jimenez");
            var resultado = estrategia.ProcesarPago(1500.00m);

            Assert.True(resultado.Exitoso);
            Assert.StartsWith("TARJ-", resultado.CodigoTransaccion);
            Assert.Equal(1500.00m, resultado.Monto);
        }

        // CP-02: Unitaria - Dato invalido (tarjeta con letras) -> Detecta el defecto
        [Fact]
        public void PagoTarjeta_ConLetras_DebeRechazarPago()
        {
            var estrategia = new PagoTarjeta("1234ABCD5678EFGH", "Raylin Ortiz");
            var resultado = estrategia.ProcesarPago(500.00m);

            Assert.False(resultado.Exitoso);
            Assert.Equal(string.Empty, resultado.CodigoTransaccion);
        }

        // CP-03: Unitaria - Caso limite (monto en cero)
        [Fact]
        public void PagoTarjeta_MontoCero_DebeRechazarPago()
        {
            var estrategia = new PagoTarjeta("4532123456789012", "Ariel Perez");
            var resultado = estrategia.ProcesarPago(0m);

            Assert.False(resultado.Exitoso);
            Assert.Contains("mayor a cero", resultado.Mensaje);
        }

        // CP-04: Unitaria - Escenario correcto con transferencia
        [Fact]
        public void PagoTransferencia_DatosValidos_DebeAprobarPago()
        {
            var estrategia = new PagoTransferencia("00123456789", "Banreservas");
            var resultado = estrategia.ProcesarPago(2500.00m);

            Assert.True(resultado.Exitoso);
            Assert.StartsWith("TRANS-", resultado.CodigoTransaccion);
        }

        // CP-05: Integracion - ProcesadorPagos cambiando de estrategia en ejecucion
        [Fact]
        public void ProcesadorPagos_CambioDeEstrategia_DebeProcesarAmbosMetodos()
        {
            var procesador = new ProcesadorPagos(new PagoTarjeta("4532123456789012", "Xavier Blanco"));
            var resTarjeta = procesador.EjecutarPago(1000.00m);

            procesador.EstablecerEstrategia(new PagoTransferencia("00987654321", "Banco Popular"));
            var resTransferencia = procesador.EjecutarPago(3200.00m);

            Assert.True(resTarjeta.Exitoso);
            Assert.StartsWith("TARJ-", resTarjeta.CodigoTransaccion);
            Assert.True(resTransferencia.Exitoso);
            Assert.StartsWith("TRANS-", resTransferencia.CodigoTransaccion);
        }
    }
}