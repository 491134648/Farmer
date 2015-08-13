
namespace Farmer.Core.Domain
{
    /// <summary>
    /// 增值税号枚举
    /// </summary>
    public enum VatNumberStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 空
        /// </summary>
        Empty = 10,
        /// <summary>
        /// V有效
        /// </summary>
        Valid = 20,
        /// <summary>
        /// 无效
        /// </summary>
        Invalid = 30
    }
}
