using NUnit.Framework;
using PaymentRuleEngine.App.Factory;
using PaymentRuleEngine.App.Models;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.Tests
{
    /// <summary>
    /// PaymentClientTest
    /// </summary>
    public class ValidatePaymentClientTest
    {
        #region Private 
        private PaymentFactoryService makePayment;

        #endregion

        #region Public
        /// <summary>
        /// SetUp
        /// </summary>
        [SetUp]
        public void Setup()
        {
             makePayment = new PaymentFactoryService();
        }

        [Test]
        public void PaymentClient_OrderBook()
        {
            var payment = new PaymentModel() { Type = OrderTypes.Book, Amount = 500};   
            makePayment.TransactionDone(payment);
            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderPhysicalProduct()
        {
            var payment = new PaymentModel() { Type = OrderTypes.PhysicalProduct, Amount = 100 };
            makePayment.TransactionDone(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderVideo()
        {
            var payment = new PaymentModel() { Type = OrderTypes.Video, Amount = 200 };
            makePayment.TransactionDone(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderMembershlipActivate()
        {
            var payment = new PaymentModel() { Type = OrderTypes.Membership, Amount = 999, OrderMode = OrderModes.ActivateMembership };
            makePayment.TransactionDone(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderMembershlipUpgrade()
        {
            var payment = new PaymentModel() { Type = OrderTypes.Membership, Amount = 899, OrderMode = OrderModes.UpgradeMemebership };
            makePayment.TransactionDone(payment);

            Assert.Pass();
        }
        
        #endregion

    }
}