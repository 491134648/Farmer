using System;
using System.Collections.Generic;
using Farmer.Core;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Represents a category
    /// </summary>
    public partial class Category : BaseEntity, ILocalizedEntity, ISlugSupported, IAclSupported, IStoreMappingSupported
    {
        private ICollection<Discount> _appliedDiscounts;
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///��Ŀģ��Id
        /// </summary>
        public Guid CategoryTemplateId { get; set; }

        /// <summary>
        /// �ؼ���
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// ��ǩ����
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// ��ǩ����
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public Guid ParentCategoryId { get; set; }

        /// <summary>
        /// ͼƬId
        /// </summary>
        public Guid PictureId { get; set; }

        /// <summary>
        /// ҳ���С
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// ����˿�ѡ��ҳ���С
        /// </summary>
        public bool AllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// ҳ���С����
        /// </summary>
        public string PageSizeOptions { get; set; }

        /// <summary>
        /// �۸�Χ
        /// </summary>
        public string PriceRanges { get; set; }

        /// <summary>
        /// �Ƿ���ҳչʾ
        /// </summary>
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// ���������˵�
        /// </summary>
        public bool IncludeInTopMenu { get; set; }

        /// <summary>
        /// �Ƿ������ۿ��Ż�
        /// <remarks>The same as if we run category.AppliedDiscounts.Count > 0
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
        ///�����������
        /// </summary>
        public bool LimitedToStores { get; set; }

        /// <summary>
        ///�Ƿ񷢲�
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int DisplayOrder { get; set; }
        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        public virtual Picture Picture { get; set;}
       
        /// <summary>
        /// �ۿ��Ż���Ϣ
        /// </summary>
        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }
    }
}
