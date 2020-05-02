

using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using System;

namespace PaymentContext.Domain.Commands.Payment
{
    public class CreateBoletoSubscriptionCommand : CreatePaymentSubscription
    {
        #region Proprieties

        public string BarCode { get; set; }

        public string BoletoNumber { get; set; }

        public string TransactionCode { get; set; }

        #endregion

        #region Contructor

        #endregion

        #region Methods

        public override void Validate()
        {
            AddNotifications( new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres.")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres.")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres.")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres."));
        }

        #endregion
    }
}
