﻿using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
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

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento inválido")
            );
        }

        #endregion

        #region Behaviors

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14) return true;

            if (Type == EDocumentType.CPF && Number.Length == 11) return true;

            return false;
        }

        #endregion
    }
}
