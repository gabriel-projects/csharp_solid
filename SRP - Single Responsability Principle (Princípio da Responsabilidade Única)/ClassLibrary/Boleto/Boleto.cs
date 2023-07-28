
namespace ClassLibrary.Boleto
{
    //Boleto tem a unica responsabilidade de gerar email
    //E delega a dependencia de gerar email para a implementação que foi injetada na classe
    //separando as responsabilidades de boleto e email
    public class Boleto
    {
        private IEmail Email { get; }

        public Boleto(IEmail email)
        {
            Email = email;
        }

        public async void Gerar()
        {
            await Email.Enviar("a");
        }
    }
}
