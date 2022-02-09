namespace PaymentRuleEngine.App.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// OrderTypes
        /// </summary>
        public enum OrderTypes
        {
            PhysicalProduct,
            Book,
            Video,
            Membership
        }
        /// <summary>
        /// OrderMode
        /// </summary>
        public enum OrderModes
        {
            ActivateMembership,
            UpgradeMemebership
        }
    }
}
