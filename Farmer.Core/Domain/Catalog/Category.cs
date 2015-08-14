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
        /// 类目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类目描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///类目模板Id
        /// </summary>
        public Guid CategoryTemplateId { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// 标签标题
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// 父分类
        /// </summary>
        public Guid ParentCategoryId { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        public Guid PictureId { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 允许顾客选择页面大小
        /// </summary>
        public bool AllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// 页面大小配置
        /// </summary>
        public string PageSizeOptions { get; set; }

        /// <summary>
        /// 价格范围
        /// </summary>
        public string PriceRanges { get; set; }

        /// <summary>
        /// 是否首页展示
        /// </summary>
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// 包含顶级菜单
        /// </summary>
        public bool IncludeInTopMenu { get; set; }

        /// <summary>
        /// 是否允许折扣优惠
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
        ///允许店面限制
        /// </summary>
        public bool LimitedToStores { get; set; }

        /// <summary>
        ///是否发布
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int DisplayOrder { get; set; }
        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        public virtual Picture Picture { get; set;}
       
        /// <summary>
        /// 折扣优惠信息
        /// </summary>
        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }
    }
}
