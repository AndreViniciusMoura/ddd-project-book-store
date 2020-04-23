using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
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
                             string address,
                             string document,
                             string email) : base(paidDate, expireDate, total, taotalPaid, payer, address, document, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
