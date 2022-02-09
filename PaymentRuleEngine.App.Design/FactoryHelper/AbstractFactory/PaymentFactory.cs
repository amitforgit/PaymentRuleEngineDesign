using PaymentRuleEngine.App.Models;

namespace PaymentRuleEngine.App.Factory.AbstractFactory
{
    /// <summary>
    /// PaymentFactory
    /// </summary>
    public abstract class PaymentFactory
    {
        /// <summary>
        /// TransactionDone
        /// </summary>
        /// <param name="payment"></param>
        public abstract void TransactionDone(PaymentModel payment);

        /// <summary>
        /// ReportingService
        /// </summary>
        public void ReportingService()
        {
          // Event Sourcing And Logging
        }
    }
}
