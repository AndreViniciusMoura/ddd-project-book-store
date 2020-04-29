﻿using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document: ValueObject
    {
        #region Proprieties

        public string Number { get; private set; }

        public EDocumentType Type { get; private set; }

        #endregion

        #region Construtor

        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
