using Invoicing.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace InvoicingTests
{
    [TestClass]
    public class BankInformationTests
    {
        private const string SIMPLE_ACCOUNT_NUMBER = "1234567";
        private const string BANK_CODE = "0800";
        private readonly string accountNumber = $"{SIMPLE_ACCOUNT_NUMBER}/{BANK_CODE}";

        [TestMethod]
        public void GetSimpleAccountNumberTest()
        {
            var testConfigs = new List<(string accountNumber, string expectedResult)>
            {
                (null, string.Empty),
                (string.Empty, string.Empty),
                (SIMPLE_ACCOUNT_NUMBER, string.Empty),
                (accountNumber, SIMPLE_ACCOUNT_NUMBER)
            };

            foreach (var config in testConfigs)
            {
                var accNumber = config.accountNumber;
                var expected = config.expectedResult;
                var information = new BankInformation { AccountNumber = accNumber };

                var actual = information.GetSimpleAccountNumber();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetBankCodeTest()
        {
            var testConfigs = new List<(string accountNumber, string expectedResult)>
            {
                (null, string.Empty),
                (string.Empty, string.Empty),
                (SIMPLE_ACCOUNT_NUMBER, string.Empty),
                (accountNumber, BANK_CODE)
            };

            foreach (var config in testConfigs)
            {
                var accNumber = config.accountNumber;
                var expected = config.expectedResult;
                var information = new BankInformation { AccountNumber = accNumber };

                var actual = information.GetBankCode();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
