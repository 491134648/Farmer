
using System;

namespace Farmer.Core.Domain
{
    public class EmailAccountSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a store default email account identifier
        /// </summary>
        public Guid DefaultEmailAccountId { get; set; }

    }

}
