using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    /// <summary>
    /// MemberShipTransaction
    /// </summary>
    public class MemberShipTransaction : IMembershipTransaction
    {
        /// <summary>
        /// ActivateMembershipForTransaction
        /// </summary>
        public void ActivateMembershipForTransaction()
        {
            Console.WriteLine("Membership Activated");
            EmailNotification email = new EmailNotification();
            email.SendActivation();

        }

        /// <summary>
        /// UpgradeMembershipForTransaction
        /// </summary>
        public void UpgradeMembershipForTransaction()
        {
            Console.WriteLine("Membership Upgraded");
            EmailNotification email = new EmailNotification();
            email.SendUpgrade();
        }
    }
}
