using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Farmer.Core.Fakes
{
    /// <summary>
    /// 伪HttpResponse
    /// </summary>
    public class FakeHttpResponse : HttpResponseBase
    {
        private readonly HttpCookieCollection _cookies;
        public FakeHttpResponse()
        {
            this._cookies = new HttpCookieCollection();
        }
        private readonly StringBuilder _outputString = new StringBuilder();

        /// <summary>
        /// 输入reponse信息
        /// </summary>
        public string ResponseOutput
        {
            get { return _outputString.ToString(); }
        }

        public override int StatusCode { get; set; }
        /// <summary>
        /// 重定向
        /// </summary>
        public override string RedirectLocation { get; set; }

        /// <summary>
        /// 写入输出
        /// </summary>
        /// <param name="s"></param>
        public override void Write(string s)
        {
            _outputString.Append(s);
        }
        /// <summary>
        /// 虚拟路径修改
        /// </summary>
        /// <param name="virtualPath"></param>
        /// <returns></returns>
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
        /// <summary>
        /// 输出cookie信息
        /// </summary>
        public override HttpCookieCollection Cookies
        {
            get
            {
                return _cookies;
            }
        }
    }
}
