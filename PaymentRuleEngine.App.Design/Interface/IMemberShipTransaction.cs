namespace PaymentRuleEngine.App.Interfaces
{
    /// <summary>
    /// IMembershipTransaction
    /// </summary>
    interface IMembershipTransaction
    {
        /// <summary>
        /// ActivateMembership
        /// </summary>
        void ActivateMembershipForTransaction();
        /// <summary>
        /// UpgradeMembership
        /// </summary>
        void UpgradeMembershipForTransaction();
    }
}
