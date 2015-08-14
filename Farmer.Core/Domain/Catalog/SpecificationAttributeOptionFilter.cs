
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 规格特性过滤
    /// </summary>
    public class SpecificationAttributeOptionFilter
    {
        /// <summary>
        /// Gets or sets the specification attribute identifier
        /// </summary>
        public Guid SpecificationAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute name
        /// </summary>
        public string SpecificationAttributeName { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute display order
        /// </summary>
        public  int SpecificationAttributeDisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute option identifier
        /// </summary>
        public Guid SpecificationAttributeOptionId { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute option name
        /// </summary>
        public string SpecificationAttributeOptionName { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute option display order
        /// </summary>
        public int SpecificationAttributeOptionDisplayOrder { get; set; }
    }
}
