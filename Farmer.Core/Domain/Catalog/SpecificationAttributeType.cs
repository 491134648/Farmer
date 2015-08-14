namespace Farmer.Core.Domain
{
    /// <summary>
    /// 规格特性类型
    /// </summary>
    public enum SpecificationAttributeType
    {
        /// <summary>
        /// Option
        /// </summary>
        Option = 0,
        /// <summary>
        /// 自定义文本
        /// </summary>
        CustomText = 10,
        /// <summary>
        /// 自定义Html
        /// </summary>
        CustomHtmlText = 20,
        /// <summary>
        /// Hyperlink
        /// </summary>
        Hyperlink = 30
    }
}