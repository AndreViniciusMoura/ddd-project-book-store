using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        #region Properties

        public string TransactionCode { get; private set; }

        #endregion

        #region Constructor
        public PayPalPayment(string transactionCode, 
                             DateTime paidDate, 
                             DateTime expireDate, 
                             decimal total, 
                             decimal taotalPaid, 
                             string payer,
                             Address address,
                             Document document,
                             Email email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
        {
            TransactionCode = transactionCode;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
