using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace Farmer.Core.Fakes
{
    /// <summary>
    /// HttpSessionState状态
    /// </summary>
    public class FakeHttpSessionState : HttpSessionStateBase
    {
        private readonly SessionStateItemCollection _sessionItems;

        public FakeHttpSessionState(SessionStateItemCollection sessionItems)
        {
            _sessionItems = sessionItems;
        }

        public override int Count
        {
            get { return _sessionItems.Count; }
        }

        public override NameObjectCollectionBase.KeysCollection Keys
        {
            get { return _sessionItems.Keys; }
        }

        public override object this[string name]
        {
            get { return _sessionItems[name]; }
            set { _sessionItems[name] = value; }
        }
        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exists(string key)
        {
            return _sessionItems[key] != null;
        }

        public override object this[int index]
        {
            get { return _sessionItems[index]; }
            set { _sessionItems[index] = value; }
        }
        /// <summary>
        /// 增加SessionState对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public override void Add(string name, object value)
        {
            _sessionItems[name] = value;
        }

        public override IEnumerator GetEnumerator()
        {
            return _sessionItems.GetEnumerator();
        }
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="name"></param>
        public override void Remove(string name)
        {
            _sessionItems.Remove(name);
        }
    }
}
