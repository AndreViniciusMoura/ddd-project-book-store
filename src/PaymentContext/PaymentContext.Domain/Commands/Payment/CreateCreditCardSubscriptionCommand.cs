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

        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumber { get; private set; }

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
