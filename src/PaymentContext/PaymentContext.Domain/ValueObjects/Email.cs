﻿using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        #region Proprieties

        public string Address { get; private set; }

        #endregion

        #region Construtor

        public Email(string address)
        {
            Address = address;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
