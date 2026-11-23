namespace WhyShop.Pagos
{
    public class ResultadoPago
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public string CodigoTransaccion { get; set; }
        public decimal Monto { get; set; }

        public ResultadoPago(bool exitoso, string mensaje, decimal monto, string codigoTransaccion = "")
        {
            Exitoso = exitoso;
            Mensaje = mensaje;
            Monto = monto;
            CodigoTransaccion = codigoTransaccion;
        }
    }
}

