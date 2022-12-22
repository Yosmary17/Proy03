using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces    
{

    public enum Mode
    {
        Creditcard, DebitCard, Paypal, Pse
    }

    public class PaymentModeFactory
    {
        public static IPaymentMode Create(Mode mode)
        {
            if (mode == Mode.Creditcard)
                return new CreditCardPaymment();

            else if (mode == Mode.DebitCard)
                 return new DebitCardPaymment();

            else if (mode == Mode.Paypal)
                return new PaypalPayment();
            else
                return new PSEPayment();
        }
    }
}