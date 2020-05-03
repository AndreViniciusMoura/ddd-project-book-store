using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        //Red, Green, Refactor
        #region Proprieties

        private IList<Student> _students = new List<Student>();

        #endregion

        #region Constructor

        public StudentQueriesTests()
        {
            for (int i = 0; i <= 10; i++)
            {
                var name = new Name("Bruce", "Wayne");
                var document = new Document("35111507795", EDocumentType.CPF);
                var email = new Email("bruce.wayne@dc.com");
                var address = new Address("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "12345");
                var student = new Student(name, document, email, address);

                _students.Add(student);
            }
        }

        #endregion

        #region Methods

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExists()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, student);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentExists()
        {
            var exp = StudentQueries.GetStudentInfo("35111507795");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, student);
        }

        #endregion
    }
}
