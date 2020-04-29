using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var student = new Student(new Name("André", "Moura"), new Document("1234567890", Domain.Enums.EDocumentType.CPF), new Email("andre@email.com"));
            student.AddSubscription(new Subscription(null));
        }
    }
}
