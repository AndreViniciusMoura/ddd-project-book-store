﻿using PaymentContext.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Mocks
{
    public class EmailServiceFake : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {
            
        }
    }
}
