namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
         /*    // crea las formas de pago 
            CreditCardPaymment pagoTarCredito = new CreditCardPaymment();
            DebitCardPaymment pagoTarDebito = new DebitCardPaymment();
            PaypalPayment pagoPayPal = new PaypalPayment(); */

            PaymentModeFactory.Create(Mode.Creditcard).MakePayment();
            PaymentModeFactory.Create(Mode.DebitCard).MakePayment();
            PaymentModeFactory.Create(Mode.Paypal).MakePayment();
            PaymentModeFactory.Create(Mode.Pse).MakePayment();
            

     

        }
    }

}