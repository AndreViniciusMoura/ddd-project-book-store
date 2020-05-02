using Flunt.Notifications;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Commands.Payment
{
    public class CreatePayPalSubscriptionCommand : CreatePaymentSubscription
    {
        #region Proprieties

        public string TransactionCode { get; set; }

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
