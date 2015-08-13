using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// ²Ö¿âĞÅÏ¢
    /// </summary>
    public partial class Warehouse : BaseEntity
    {
        /// <summary>
        /// Gets or sets the warehouse name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets the address identifier of the warehouse
        /// </summary>
        public Guid AddressId { get; set; }
    }
}