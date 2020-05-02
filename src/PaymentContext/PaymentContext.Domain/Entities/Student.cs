using Flunt.Validations;
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

        public Student(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        #endregion

        #region Behaviors

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = _subscriptions.Any(s => s.Active);

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
                .AreNotEquals(0, subscription.Payments.Count, "Student.Subscription", "Esta assinatura não possui pagamentos")
            );

            //Alternativa
            //Se já tiver uma assinatura ativa, erro
            //if (hasSubscriptionActive)
            //    AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");

            if (Valid)
                _subscriptions.Add(subscription);
        }

        #endregion
    }
}
