using System.Collections.Generic;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 缺省权限记录
    /// </summary>
    public class DefaultPermissionRecord
    {
        public DefaultPermissionRecord() 
        {
            this.PermissionRecords = new List<PermissionRecord>();
        }

        /// <summary>
        /// Gets or sets the customer role system name
        /// </summary>
        public string CustomerRoleSystemName { get; set; }

        /// <summary>
        /// Gets or sets the permissions
        /// </summary>
        public IEnumerable<PermissionRecord> PermissionRecords { get; set; }
    }
}
