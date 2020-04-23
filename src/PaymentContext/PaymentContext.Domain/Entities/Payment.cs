using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {        
        #region Properties

        public string Number { get; private set; }

        public DateTime PaidDate { get; private set; }

        public DateTime ExpireDate { get; private set; }

        public decimal Total { get; private set; }

        public decimal TaotalPaid { get; private set; }

        public string Payer { get; private set; }

        public string Address { get; private set; }

        public string Document { get; private set; }

        public string Email { get; private set; }

        #endregion

        #region Constructor

        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal taotalPaid, string payer, string address, string document, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TaotalPaid = taotalPaid;
            Payer = payer;
            Address = address;
            Document = document;
            Email = email;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
