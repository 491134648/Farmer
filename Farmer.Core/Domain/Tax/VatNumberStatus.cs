
namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��ֵ˰��ö��
    /// </summary>
    public enum VatNumberStatus
    {
        /// <summary>
        /// δ֪
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// ��
        /// </summary>
        Empty = 10,
        /// <summary>
        /// V��Ч
        /// </summary>
        Valid = 20,
        /// <summary>
        /// ��Ч
        /// </summary>
        Invalid = 30
    }
}
