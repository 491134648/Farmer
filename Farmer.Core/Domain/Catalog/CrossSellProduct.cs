namespace Farmer.Core.Domain
{
    /// <summary>
    /// �������۲�Ʒ
    /// </summary>
    public partial class CrossSellProduct : BaseEntity
    {
        /// <summary>
        /// ��Ʒ1
        /// </summary>
        public string ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public string ProductId2 { get; set; }
    }

}
