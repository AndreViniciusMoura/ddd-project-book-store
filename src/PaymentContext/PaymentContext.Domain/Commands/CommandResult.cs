using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        #region Proprieties

        public bool Success { get; set; }

        public string Message { get; set; }

        #endregion

        #region Contrusctor

        public CommandResult()
        {

        }

        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        #endregion

        #region Methods

        #endregion
    }
}
