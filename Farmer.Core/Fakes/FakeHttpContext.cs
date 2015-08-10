using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace Farmer.Core.Fakes
{
    /// <summary>
    /// 伪连接Http上下文
    /// </summary>
   public class FakeHttpContext:HttpContextBase
    {
        private readonly HttpCookieCollection _cookies;//cokie集合
        private readonly NameValueCollection _formParams;//forms参数集合
        private IPrincipal _principal;//用户对象基本功能
        private readonly NameValueCollection _queryStringParams;//参数字符串集合
        private readonly string _relativeUrl;//关联url
        private readonly string _method;//方法
        private readonly SessionStateItemCollection _sessionItems;//会话状态对象集合
        private readonly NameValueCollection _serverVariables;//服务变量键值对集合
        private HttpResponseBase _response;//http响应
        private HttpRequestBase _request;//http请求
        private readonly IDictionary _items;
        /// <summary>
        /// 根路径
        /// </summary>
        /// <returns></returns>
        public static FakeHttpContext Root()
        {
            return new FakeHttpContext("~/");
        }
        /// <summary>
        /// 构建一个FakeHttpContext新实例
        /// </summary>
        /// <param name="relativeUrl">关联url</param>
        /// <param name="method">方法</param>
        public FakeHttpContext(string relativeUrl, string method)
            : this(relativeUrl, method, null, null, null, null, null, null)
        {
        }

        public FakeHttpContext(string relativeUrl)
            : this(relativeUrl, null, null, null, null, null, null)
        {
        }

        public FakeHttpContext(string relativeUrl,
            IPrincipal principal, NameValueCollection formParams,
            NameValueCollection queryStringParams, HttpCookieCollection cookies,
            SessionStateItemCollection sessionItems, NameValueCollection serverVariables)
            : this(relativeUrl, null, principal, formParams, queryStringParams, cookies, sessionItems, serverVariables)
        {
        }

        public FakeHttpContext(string relativeUrl, string method,
            IPrincipal principal, NameValueCollection formParams,
            NameValueCollection queryStringParams, HttpCookieCollection cookies,
            SessionStateItemCollection sessionItems, NameValueCollection serverVariables)
        {
            relativeUrl = relativeUrl;
            _method = method;
            _principal = principal;
            _formParams = formParams;
            _queryStringParams = queryStringParams;
            _cookies = cookies;
            _sessionItems = sessionItems;
            _serverVariables = serverVariables;

            _items = new Dictionary<object, object>();
        }

        public override HttpRequestBase Request
        {
            get
            {
                return _request ??
                       new FakeHttpRequest(_relativeUrl, _method, _formParams, _queryStringParams, _cookies, _serverVariables);
            }
        }

        public void SetRequest(HttpRequestBase request)
        {
            _request = request;
        }

        public override HttpResponseBase Response
        {
            get
            {
                return _response ?? new FakeHttpResponse();
            }
        }
        /// <summary>
        /// 设定Response
        /// </summary>
        /// <param name="response"></param>
        public void SetResponse(HttpResponseBase response)
        {
            _response = response;
        }

        public override IPrincipal User
        {
            get { return _principal; }
            set { _principal = value; }
        }

        public override HttpSessionStateBase Session
        {
            get { return new FakeHttpSessionState(_sessionItems); }
        }

        public override IDictionary Items
        {
            get
            {
                return _items;
            }
        }


        public override bool SkipAuthorization { get; set; }

        public override object GetService(Type serviceType)
        {
            return null;
        }
    }
}
