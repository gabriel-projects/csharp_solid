using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PaymentProcessor
{

    //Nesse exemplo, temos uma interface IPaymentProcessor que define um contrato para processar pagamentos.
    //Em vez de ter uma única classe que processa todos os tipos de pagamento, utilizamos a abordagem do OCP para permitir a extensão do sistema para novos métodos de pagamento. 
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Lógica para processar o pagamento com cartão de crédito
        }
    }

    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Lógica para processar o pagamento com PayPal
        }
    }
}
