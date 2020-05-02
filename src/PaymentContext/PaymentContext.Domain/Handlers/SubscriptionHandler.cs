using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Commands.Payment;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable, IHandler<CreateBoletoSubscriptionCommand>,
                                                   IHandler<CreatePayPalSubscriptionCommand>
    {
        #region Proprieties

        private readonly IStudentRepository _studentRepository;
        private readonly IEmailService _emailService;

        #endregion

        #region Constructor

        public SubscriptionHandler(IStudentRepository studentRepository,
                                   IEmailService emailService)
        {
            _studentRepository = studentRepository;
            _emailService = emailService;
        }

        #endregion

        #region Methods

        private Student CrateStudentFactory(CreatePaymentSubscription command)
        {
            // Gerar os VOs
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document, EDocumentType.CPF);
            var email = new Email(command.Email);
            var address = new Address(command.Street,
                                      command.Number,
                                      command.Nighborhood,
                                      command.City,
                                      command.State,
                                      command.Country,
                                      command.ZipCode);

            // Gerar as Entidades
            var student = new Student(name, document, email);
            var subscription = new Subscription(DateTime.Now.AddMonths(1));
            
            student.AddSubscription(subscription);

            return student;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            //Fail Fast Validations
            command.Validate();

            if (command.Invalid)
                return new CommandResult(false, "Não foi possível realizar sua assinatura");

            // Verificar se Documento já esta cadastrado
            if (_studentRepository.DocumentExists(command.Document))
                AddNotification("Document", "Este CPF já está em uso");

            // Verificar se E-mail já esta cadastrado
            if (_studentRepository.EmailExists(command.Email))
                AddNotification("email", "Este E-mail já está em uso");

            var student = CrateStudentFactory(command);

            //Criar Pagamento
            var payment = new BoletoPayment(command.BarCode,
                                            command.BoletoNumber,
                                            command.PaidDate,
                                            command.ExpireDate,
                                            command.Total,
                                            command.TotalPaid,
                                            command.Payer,
                                            student.Address,
                                            new Document(command.PayerDocument, command.PayerDocumentType),
                                            student.Email);

            //Relacionamento
            var subscription = student.Subscriptions.First();
            subscription.AddPayment(payment);

            //agrupar as Validações
            AddNotifications(student.Name, 
                             student.Document, 
                             student.Email, 
                             student.Address, 
                             student,
                             subscription,
                             payment);

            // Salvar as Informações
            _studentRepository.CreateSubscription(student);

            // Enviar E-mail de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao andre.io", "sua assinatura foi criada");

            // Retornar informações
            return new CommandResult(true, "Assinatura realizada com sucesso");
        }

        public ICommandResult Handle(CreatePayPalSubscriptionCommand command)
        {
            //Fail Fast Validations
            
            // Verificar se Documento já esta cadastrado
            if (_studentRepository.DocumentExists(command.Document))
                AddNotification("Document", "Este CPF já está em uso");

            // Verificar se E-mail já esta cadastrado
            if (_studentRepository.EmailExists(command.Email))
                AddNotification("email", "Este E-mail já está em uso");

            // Gerar os VOs
            var student = CrateStudentFactory(command);

            //Criar Pagamento
            var payment = new PayPalPayment(command.TransactionCode,                                            
                                            command.PaidDate,
                                            command.ExpireDate,
                                            command.Total,
                                            command.TotalPaid,
                                            command.Payer,
                                            student.Address,
                                            new Document(command.PayerDocument, command.PayerDocumentType),
                                            student.Email);

            //Relacionamento
            var subscription = student.Subscriptions.First();
            subscription.AddPayment(payment);

            //Agrupar as Validações
            AddNotifications(student.Name,
                             student.Document,
                             student.Email,
                             student.Address,
                             student,
                             subscription,
                             payment);

            // Salvar as Informações
            _studentRepository.CreateSubscription(student);

            // Enviar E-mail de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao andre.io", "sua assinatura foi criada");

            // Retornar informações
            return new CommandResult(true, "Assinatura realizada com sucesso");
        }

        #endregion
    }
}
