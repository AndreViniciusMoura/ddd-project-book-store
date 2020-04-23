using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
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
                             string address, 
                             string document, 
                             string email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
        {
            TransactionCode = transactionCode;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
