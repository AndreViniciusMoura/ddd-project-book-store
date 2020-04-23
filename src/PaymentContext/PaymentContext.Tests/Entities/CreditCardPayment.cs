using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
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
                                 string address,
                                 string document,
                                 string email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
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
