namespace PaymentRuleEngine.App.Interfaces
{
    /// <summary>
    /// IPaymentSlip
    /// </summary>
    interface IPaymentSlip
    {
        /// <summary>
        /// GeneratePackingSlip
        /// </summary>
        void GeneratePackagingSlip();
        /// <summary>
        /// GenerateDuplicatePackingSlip
        /// </summary>
        void GenerateDuplicatePackagingSlip();
        /// <summary>
        /// AddCouponToSlip
        /// </summary>
        void AddCouponSlip();
    }
}
