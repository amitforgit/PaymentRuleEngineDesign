using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Factory.ConcreateFactory;
using PaymentRuleEngine.App.Models;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Factory
{
    /// <summary>
    /// PaymentFactoryService Factory
    /// </summary>
    public class PaymentFactoryService : PaymentFactory
    {
        /// <summary>
        /// TransactionDone
        /// </summary>
        /// <param name="payment"></param>
        public override void TransactionDone(PaymentModel payment)
        {
            switch (payment.Type)
            {
                case OrderTypes.Book:
                    BookPaymentFactory bookPaymentFactory = new BookPaymentFactory();
                    bookPaymentFactory.TransactionDone(payment);
                    break;

                case OrderTypes.PhysicalProduct:
                    PhysicalProductPaymentFactory physicalProductPaymentFactory = new PhysicalProductPaymentFactory();
                    physicalProductPaymentFactory.TransactionDone(payment);
                    break;

                case OrderTypes.Video:
                    VideoPaymentFactory videoPaymentFactory = new VideoPaymentFactory();
                    videoPaymentFactory.TransactionDone(payment);
                    break;

                case OrderTypes.Membership:
                    MembershipFactory membershipFactory = new MembershipFactory();
                    membershipFactory.TransactionDone(payment);
                    break;
            }
        }
    }
}
