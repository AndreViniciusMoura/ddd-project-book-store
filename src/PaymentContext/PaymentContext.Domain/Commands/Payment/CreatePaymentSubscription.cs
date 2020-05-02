using Flunt.Notifications;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using System;

namespace PaymentContext.Domain.Commands.Payment
{
    public abstract class CreatePaymentSubscription : Notifiable, ICommand
    {
        #region Proprieties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string PaymentNumber { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; }

        public string Payer { get; set; }

        public string PayerEmail { get; set; }

        public string PayerDocument { get; set; }

        public EDocumentType PayerDocumentType { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Nighborhood { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        #endregion

        #region Contructor

        #endregion

        #region Methods

        public abstract void Validate();

        #endregion
    }
}
