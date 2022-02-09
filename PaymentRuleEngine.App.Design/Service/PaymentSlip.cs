using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    /// <summary>
    /// PaymentSlip
    /// </summary>
    public class PaymentSlip : IPaymentSlip
    {
        /// <summary>
        /// AddCouponSlip
        /// </summary>
        public void AddCouponSlip()
        {
            Console.WriteLine("Coupon First Aid Video Free:");
        }

        /// <summary>
        /// GenerateDuplicatePackagingSlip
        /// </summary>
        public void GenerateDuplicatePackagingSlip()
        {
            Console.WriteLine("Generated Duplicate Payslip for Royality Bonus:");
        }

        /// <summary>
        /// GeneratePackagingSlip
        /// </summary>
        public void GeneratePackagingSlip()
        {
            Console.WriteLine("Generated Paylip for Packaging:");
        }
    }
}
