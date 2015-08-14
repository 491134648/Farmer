using System;
namespace Farmer.Core.Domain
{
    /// <summary>
    /// Represents an address attribute value
    /// </summary>
    public partial class AddressAttributeValue : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// Gets or sets the address attribute identifier
        /// </summary>
        public Guid AddressAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the checkout attribute name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the value is pre-selected
        /// </summary>
        public bool IsPreSelected { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the address attribute
        /// </summary>
        public virtual AddressAttribute AddressAttribute { get; set; }
    }

}
