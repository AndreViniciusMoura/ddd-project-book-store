using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands.Payment;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        //Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new EmailServiceFake());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@andre.io2";
            command.PaymentNumber = "123456789";
            command.BarCode = "12345678987";
            command.PaymentNumber = "123121";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNER CORP";
            command.PayerEmail = "batman@dc.com";
            command.PayerDocument = "12345678945";
            command.PayerDocumentType = EDocumentType.CPF;
            command.Street = "wqewqewq";
            command.Number = "51651";
            command.Nighborhood = "ewqewqewq";
            command.City = "as";
            command.State = "as";
            command.Country = "as";
            command.ZipCode = "123456789";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);

        }
    }
}
