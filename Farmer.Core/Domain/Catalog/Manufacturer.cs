using System;
using System.Collections.Generic;
using Farmer.Core.Domain;


namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��������
    /// </summary>
    public partial class Manufacturer : BaseEntity, ILocalizedEntity, ISlugSupported, IAclSupported, IStoreMappingSupported
    {
        private ICollection<Discount> _appliedDiscounts;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ������ģ��
        /// </summary>
        public Guid ManufacturerTemplateId { get; set; }

        /// <summary>
        /// �ؼ���
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets the meta description
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta title
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public Guid PictureId { get; set; }

        /// <summary>
        /// ҳ���С
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// �����û�ѡ��ҳ���С
        /// </summary>
        public bool AllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// ��Ч�û�ҳ���С����
        /// </summary>
        public string PageSizeOptions { get; set; }

        /// <summary>
        /// �۸�����
        /// </summary>
        public string PriceRanges { get; set; }

        /// <summary>
        /// �Ƿ������ۿ��Ż�
        /// <remarks>The same as if we run manufacturer.AppliedDiscounts.Count > 0
        /// We use this property for performance optimization:
        /// if this property is set to false, then we do not need to load Applied Discounts navigation property
        /// </remarks>
        /// </summary>
        public bool HasDiscountsApplied { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is subject to ACL
 	    /// </summary>
        public bool SubjectToAcl { get; set; }

        /// <summary>
        /// ĳ��������
        /// </summary>
        public bool LimitedToStores { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the collection of applied discounts
        /// </summary>
        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }
    }
}
