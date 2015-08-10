using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Fakes
{
    /// <summary>
    /// Fake唯一标识
    /// </summary>
    public class FakeIdentity : IIdentity
    {
        private readonly string _name;

        public FakeIdentity(string userName)
        {
            _name = userName;
        }
        /// <summary>
        /// 认证类型
        /// </summary>
        public string AuthenticationType
        {
            get { throw new NotImplementedException(); }
        }
        /// <summary>
        /// 是否认证
        /// </summary>
        public bool IsAuthenticated
        {
            get { return !String.IsNullOrEmpty(_name); }
        }

        public string Name
        {
            get { return _name; }
        }

    }
}
