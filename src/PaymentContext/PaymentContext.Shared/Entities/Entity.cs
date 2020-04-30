using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity: Notifiable
    {
        #region Proprieties

        public Guid Id { get; private set; }

        #endregion

        #region Construtor

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Behaviors

        #endregion
    }
}
