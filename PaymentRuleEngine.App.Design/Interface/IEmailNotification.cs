namespace PaymentRuleEngine.App.Interfaces
{
    /// <summary>
    /// IEmailNotification
    /// </summary>
    interface IEmailNotification
    {
        /// <summary>
        /// SendActivation
        /// </summary>
        void SendActivation();
        /// <summary>
        /// SendUpgrade
        /// </summary>
        void SendUpgrade();
    }
}
