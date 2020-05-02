using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        #region Proprieties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public void CreateSubscription(Student student)
        {

        }

        public bool DocumentExists(string document)
        {
            if (document == "99999999999") return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "hello@andre.io") return true;

            return false;
        }

        #endregion
    }
}
