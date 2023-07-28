namespace ClassLibrary.Boleto
{
    public interface IEmail
    {
        Task Enviar(string boleto);
    }
}
