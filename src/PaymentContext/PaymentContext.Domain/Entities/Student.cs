using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        #region Properties

        #region Fields

        private IList<Subscription> _subscriptions;

        #endregion

        public Name Name { get; private set; }

        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public Address Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get => _subscriptions.ToArray(); }

        #endregion

        #region Constructor

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        #endregion

        #region Behaviors

        public void AddSubscription(Subscription subscription)
        {
            //Se já tiver uma assinatura ativa, cancela

            //Cancela todas as outras assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
            {
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }

        #endregion
    }
}
