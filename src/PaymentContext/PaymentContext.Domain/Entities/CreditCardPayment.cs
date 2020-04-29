using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        #region Properties

        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumber { get; private set; }

        #endregion

        #region Constructor
        public CreditCardPayment(string cardHolderName, 
                                 string cardNumber, string lastTransactionNumber,
                                 DateTime paidDate,
                                 DateTime expireDate,
                                 decimal total,
                                 decimal taotalPaid,
                                 string payer,
                                 Address address,
                                 Document document,
                                 Email email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
