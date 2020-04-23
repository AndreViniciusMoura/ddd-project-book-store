using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        #region Properties

        #region Fields

        private IList<Subscription> _subscriptions;

        #endregion

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Document { get; private set; }

        public string Email { get; private set; }

        public string Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get => _subscriptions.ToArray(); }

        #endregion

        #region Constructor

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
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
