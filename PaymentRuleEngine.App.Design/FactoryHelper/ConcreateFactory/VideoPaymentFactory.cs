using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Interfaces;
using PaymentRuleEngine.App.Models;
using PaymentRuleEngine.App.Services;

namespace PaymentRuleEngine.App.Factory.ConcreateFactory
{
    /// <summary>
    /// VideoPaymentFactory
    /// </summary>
    public class VideoPaymentFactory : PaymentFactory
    {
        /// <summary>
        /// TransactionDone
        /// </summary>
        /// <param name="payment"></param>
        public override void TransactionDone(PaymentModel payment)
        {
            Interfaces.IPaymentSlip slip = new Services.PaymentSlip();
            slip.AddCouponSlip();
            slip.GeneratePackagingSlip();

            base.ReportingService();
        }
    }
}
