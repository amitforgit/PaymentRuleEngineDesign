using System.ComponentModel.DataAnnotations;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Models
{
    /// <summary>
    /// PaymentModel
    /// </summary>
    public class PaymentModel
    {
        /// <summary>
        /// Type
        /// </summary>
        [Required]
        public OrderTypes Type { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [Required]
        public decimal Amount { get; set; }
        /// <summary>
        /// OrderMode
        /// </summary>
        public OrderModes OrderMode { get; set; }

    }
}
