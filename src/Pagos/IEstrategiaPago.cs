namespace WhyShop.Pagos
{
    public interface IEstrategiaPago
    {
        string NombreMetodo { get; }
        ResultadoPago ProcesarPago(decimal monto);
    }
}
