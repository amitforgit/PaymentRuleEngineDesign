using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    /// <summary>
    /// EmailNotification
    /// </summary>
    public class EmailNotification : IEmailNotification
    {
        /// <summary>
        /// SendActivation
        /// </summary>
        public void SendActivation()
        {
            Console.WriteLine("Sent Activation Email");
        }

        /// <summary>
        /// SendUpgrade
        /// </summary>
        public void SendUpgrade()
        {
            Console.WriteLine("Sent Upgrade Email");
        }
    }
}
