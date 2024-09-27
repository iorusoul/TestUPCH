namespace upch.test
{
    public class RespuestaGenerica<T>
    {
        public string CodigoError { get; set; }
        public bool TieneError { get; set; }
        public string MensajeError { get; set; }
        public T Resultado { get; set; }
    }
}
