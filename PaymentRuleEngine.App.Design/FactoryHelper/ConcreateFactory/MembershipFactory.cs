using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Interfaces;
using PaymentRuleEngine.App.Models;
using PaymentRuleEngine.App.Services;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Factory.ConcreateFactory
{
    /// <summary>
    /// MembershipFactory
    /// </summary>
    public class MembershipFactory : PaymentFactory
    {
        /// <summary>
        /// TransactionDone
        /// </summary>
        /// <param name="payment"></param>
        public override void TransactionDone(PaymentModel payment)
        {

            switch (payment.OrderMode)
            {

                case OrderModes.ActivateMembership:
                    IMembershipTransaction activateMembership = new MemberShipTransaction();
                    activateMembership.ActivateMembershipForTransaction();
                    break;

                case OrderModes.UpgradeMemebership:
                    IMembershipTransaction upgradeMembership = new MemberShipTransaction();
                    upgradeMembership.UpgradeMembershipForTransaction();
                    break;
            }

            base.ReportingService();
        }
    }
}
