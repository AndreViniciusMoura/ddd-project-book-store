using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {        
        #region Proprieties

        public string Street { get; private set; }

        public string Number { get; private set; }

        public string Nighborhood { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }

        public string ZipCode { get; private set; }

        #endregion

        #region Construtor

        public Address(string street, string number, string nighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Nighborhood = nighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
