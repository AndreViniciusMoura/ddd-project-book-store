using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Commands.Payment
{
    public class CreateCreditCardSubscriptionCommand : CreatePaymentSubscription
    {
        #region Proprieties

        public string CardHolderName { get; set; }

        public string CardNumber { get; set; }

        public string LastTransactionNumber { get; set; }

        #endregion

        #region Contructor

        #endregion

        #region Methods

        public override void Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
