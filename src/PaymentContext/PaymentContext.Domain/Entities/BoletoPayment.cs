using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        #region Properties

        public string BarCode { get; private set; }

        public string BoletoNumber { get; private set; }

        #endregion

        #region Constructor
        public BoletoPayment(string barCode, 
                             string boletoNumber,
                             DateTime paidDate,
                             DateTime expireDate,
                             decimal total,
                             decimal taotalPaid,
                             string payer,
                             Address address,
                             Document document,
                             Email email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
