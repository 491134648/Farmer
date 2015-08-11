using System;
using System.Collections.Generic;
using Farmer.Core.Domain;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品Model
    /// </summary>
    public partial class Product : BaseEntity, ILocalizedEntity, ISlugSupported, IAclSupported, IStoreMappingSupported
    {
        private ICollection<ProductCategory> _productCategories;
        private ICollection<ProductManufacturer> _productManufacturers;
        private ICollection<ProductPicture> _productPictures;
        private ICollection<ProductReview> _productReviews;
        private ICollection<ProductSpecificationAttribute> _productSpecificationAttributes;
        private ICollection<ProductTag> _productTags;
        private ICollection<ProductAttributeMapping> _productAttributeMappings;
        private ICollection<ProductAttributeCombination> _productAttributeCombinations;
        private ICollection<TierPrice> _tierPrices;
        private ICollection<Discount> _appliedDiscounts;
        private ICollection<ProductWarehouseInventory> _productWarehouseInventory;


        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// 团购父类产品IdGets or sets the parent product identifier. It's used to identify associated products (only with "grouped" products)
        /// </summary>
        public string ParentGroupedProductId { get; set; }
        /// <summary>
        /// 是否禁止单个Gets or sets the values indicating whether this product is visible in catalog or search results.
        /// It's used when this product is associated to some "grouped" one
        /// This way associated products could be accessed/added/etc only from a grouped product details page
        /// </summary>
        public bool VisibleIndividually { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///摘要描述
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// 完整描述
        /// </summary>
        public string FullDescription { get; set; }

        /// <summary>
        ///管理员评论
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// 产品模板
        /// </summary>
        public int ProductTemplateId { get; set; }

        /// <summary>
        /// 卖家Id
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// 首页展示
        /// </summary>
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        public string MetaKeywords { get; set; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string MetaDescription { get; set; }
        /// <summary>
        /// 标签Title
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// 是否允许顾客评论
        /// </summary>
        public bool AllowCustomerReviews { get; set; }
        /// <summary>
        /// 审核评分数
        /// </summary>
        public int ApprovedRatingSum { get; set; }
        /// <summary>
        ///未审核评分值
        /// </summary>
        public int NotApprovedRatingSum { get; set; }
        /// <summary>
        /// 审核评论数
        /// </summary>
        public int ApprovedTotalReviews { get; set; }
        /// <summary>
        /// 未审核评论总数
        /// </summary>
        public int NotApprovedTotalReviews { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is subject to ACL
        /// </summary>
        public bool SubjectToAcl { get; set; }
        /// <summary>
        /// 店铺限制
        /// </summary>
        public bool LimitedToStores { get; set; }

        /// <summary>
        /// 产品SKU
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// 制造商Id
        /// </summary>
        public string ManufacturerPartNumber { get; set; }
        /// <summary>
        /// Gtin
        /// </summary>
        public string Gtin { get; set; }

        /// <summary>
        ///是否购物卡
        /// </summary>
        public bool IsGiftCard { get; set; }
        /// <summary>
        /// 购物卡类型
        /// </summary>
        public int GiftCardTypeId { get; set; }
        /// <summary>
        /// Gets or sets gift card amount that can be used after purchase. If not specified, then product price will be used.
        /// </summary>
        public decimal? OverriddenGiftCardAmount { get; set; }

        /// <summary>
        /// 是否需要另外产品
        /// </summary>
        public bool RequireOtherProducts { get; set; }
        /// <summary>
        /// 必须另外产品Id
        /// </summary>
        public string RequiredProductIds { get; set; }
        /// <summary>
        /// 是否自动添加另外产品
        /// </summary>
        public bool AutomaticallyAddRequiredProducts { get; set; }

        /// <summary>
        /// 是否下载
        /// </summary>
        public bool IsDownload { get; set; }
        /// <summary>
        /// 下载Id
        /// </summary>
        public int DownloadId { get; set; }
        /// <summary>
        /// 是否无限下载
        /// </summary>
        public bool UnlimitedDownloads { get; set; }
        /// <summary>
        /// 下载最大数
        /// </summary>
        public int MaxNumberOfDownloads { get; set; }
        /// <summary>
        /// 下载过期天数
        /// </summary>
        public int? DownloadExpirationDays { get; set; }
        /// <summary>
        /// Gets or sets the download activation type
        /// </summary>
        public int DownloadActivationTypeId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the product has a sample download file
        /// </summary>
        public bool HasSampleDownload { get; set; }
        /// <summary>
        /// Gets or sets the sample download identifier
        /// </summary>
        public int SampleDownloadId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the product has user agreement
        /// </summary>
        public bool HasUserAgreement { get; set; }
        /// <summary>
        /// Gets or sets the text of license agreement
        /// </summary>
        public string UserAgreementText { get; set; }

        /// <summary>
        /// 是否循环
        /// </summary>
        public bool IsRecurring { get; set; }
        /// <summary>
        ///循环周期长度
        /// </summary>
        public int RecurringCycleLength { get; set; }
        /// <summary>
        /// Gets or sets the cycle period
        /// </summary>
        public int RecurringCyclePeriodId { get; set; }
        /// <summary>
        /// Gets or sets the total cycles
        /// </summary>
        public int RecurringTotalCycles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is rental
        /// </summary>
        public bool IsRental { get; set; }
        /// <summary>
        /// Gets or sets the rental length for some period (price for this period)
        /// </summary>
        public int RentalPriceLength { get; set; }
        /// <summary>
        /// Gets or sets the rental period (price for this period)
        /// </summary>
        public int RentalPricePeriodId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is ship enabled
        /// </summary>
        public bool IsShipEnabled { get; set; }
        /// <summary>
        /// 是否包邮
        /// </summary>
        public bool IsFreeShipping { get; set; }
        /// <summary>
        /// 单个快递
        /// </summary>
        public bool ShipSeparately { get; set; }
        /// <summary>
        /// 附加配送费用
        /// </summary>
        public decimal AdditionalShippingCharge { get; set; }
        /// <summary>
        /// 交付时间Id
        /// </summary>
        public int DeliveryDateId { get; set; }

        /// <summary>
        /// 是否免税
        /// </summary>
        public bool IsTaxExempt { get; set; }
        /// <summary>
        /// 税务类型
        /// </summary>
        public int TaxCategoryId { get; set; }
        /// <summary>
        ///电信或广告服务
        /// </summary>
        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }

        /// <summary>
        /// 库存管理方法
        /// </summary>
        public int ManageInventoryMethodId { get; set; }
        /// <summary>
        ///是否多仓库
        /// </summary>
        public bool UseMultipleWarehouses { get; set; }
        /// <summary>
        ///仓库名称
        /// </summary>
        public int WarehouseId { get; set; }
        /// <summary>
        ///库存数量
        /// </summary>
        public int StockQuantity { get; set; }
        /// <summary>
        /// 是否显示有效库存
        /// </summary>
        public bool DisplayStockAvailability { get; set; }
        /// <summary>
        /// 显示库存数量
        /// </summary>
        public bool DisplayStockQuantity { get; set; }
        /// <summary>
        /// 最小库存数量
        /// </summary>
        public int MinStockQuantity { get; set; }
        /// <summary>
        /// 低库存激活
        /// </summary>
        public int LowStockActivityId { get; set; }
        /// <summary>
        /// 低库存通知管理员
        /// </summary>
        public int NotifyAdminForQuantityBelow { get; set; }
        /// <summary>
        ///延期交货模型
        /// </summary>
        public int BackorderModeId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to back in stock subscriptions are allowed
        /// </summary>
        public bool AllowBackInStockSubscriptions { get; set; }
        /// <summary>
        /// 最小订单量
        /// </summary>
        public int OrderMinimumQuantity { get; set; }
        /// <summary>
        /// 最大订单数量
        /// </summary>
        public int OrderMaximumQuantity { get; set; }
        /// <summary>
        /// 允许数量
        /// </summary>
        public string AllowedQuantities { get; set; }
        /// <summary>
        /// 允许添加扩展特性组合Gets or sets a value indicating whether we allow adding to the cart/wishlist only attribute combinations that exist and have stock greater than zero.
        /// This option is used only when we have "manage inventory" set to "track inventory by product attributes"
        /// </summary>
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        /// <summary>
        /// 禁用购买按钮
        /// </summary>
        public bool DisableBuyButton { get; set; }
        /// <summary>
        /// 禁用收藏按钮
        /// </summary>
        public bool DisableWishlistButton { get; set; }
        /// <summary>
        ///允许预购买
        /// </summary>
        public bool AvailableForPreOrder { get; set; }
        /// <summary>
        /// 预购买有效时间
        /// </summary>
        public DateTime? PreOrderAvailabilityStartDateTime { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to show "Call for Pricing" or "Call for quote" instead of price
        /// </summary>
        public bool CallForPrice { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///旧价格
        /// </summary>
        public decimal OldPrice { get; set; }
        /// <summary>
        /// 陈本价
        /// </summary>
        public decimal ProductCost { get; set; }
        /// <summary>
        /// 特价
        /// </summary>
        public decimal? SpecialPrice { get; set; }
        /// <summary>
        /// 特价开始时间
        public DateTime? SpecialPriceStartDateTime { get; set; }
        /// <summary>
        /// 特价结束时间
        /// </summary>
        public DateTime? SpecialPriceEndDateTime { get; set; }
        /// <summary>
        /// 顾客购买价格
        /// </summary>
        public bool CustomerEntersPrice { get; set; }
        /// <summary>
        /// 最低顾客价格
        /// </summary>
        public decimal MinimumCustomerEnteredPrice { get; set; }
        /// <summary>
        /// Gets or sets the maximum price entered by a customer
        /// </summary>
        public decimal MaximumCustomerEnteredPrice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether base price (PAngV) is enabled. Used by German users.
        /// </summary>
        public bool BasepriceEnabled { get; set; }
        /// <summary>
        /// Gets or sets an amount in product for PAngV
        /// </summary>
        public decimal BasepriceAmount { get; set; }
        /// <summary>
        /// Gets or sets a unit of product for PAngV (MeasureWeight entity)
        /// </summary>
        public int BasepriceUnitId { get; set; }
        /// <summary>
        /// Gets or sets a reference amount for PAngV
        /// </summary>
        public decimal BasepriceBaseAmount { get; set; }
        /// <summary>
        /// Gets or sets a reference unit for PAngV (MeasureWeight entity)
        /// </summary>
        public int BasepriceBaseUnitId { get; set; }

        /// <summary>
        ///允许层级价格
        /// <remarks>The same as if we run this.TierPrices.Count > 0
        /// We use this property for performance optimization:
        /// if this property is set to false, then we do not need to load tier prices navigation property
        /// </remarks>
        /// </summary>
        public bool HasTierPrices { get; set; }
        /// <summary>
        /// 是否允许折扣
        /// <remarks>The same as if we run this.AppliedDiscounts.Count > 0
        /// We use this property for performance optimization:
        /// if this property is set to false, then we do not need to load Applied Discounts navigation property
        /// </remarks>
        /// </summary>
        public bool HasDiscountsApplied { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// Gets or sets the length
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// Gets or sets the width
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// Gets or sets the height
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        public DateTime? AvailableStartDateTime { get; set; }
        /// <summary>
        /// 有效结束时间
        /// </summary>
        public DateTime? AvailableEndDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets a display order.
        /// This value is used when sorting associated products (used with "grouped" products)
        /// This value is used when sorting home page products
        /// </summary>
        public int DisplayOrder { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        public bool Published { get; set; }
    

        
        /// <summary>
        ///最近更新时间
        /// </summary>
        public DateTime UpdatedOn { get; set; }






        /// <summary>
        /// 产品类型
        /// </summary>
        public ProductType ProductType
        {
            get
            {
                return (ProductType)this.ProductTypeId;
            }
            set
            {
                this.ProductTypeId = (int)value;
            }
        }

        /// <summary>
        /// 延迟发货模式
        /// </summary>
        public BackorderMode BackorderMode
        {
            get
            {
                return (BackorderMode)this.BackorderModeId;
            }
            set
            {
                this.BackorderModeId = (int)value;
            }
        }

        /// <summary>
        /// 下载激活类型
        /// </summary>
        public DownloadActivationType DownloadActivationType
        {
            get
            {
                return (DownloadActivationType)this.DownloadActivationTypeId;
            }
            set
            {
                this.DownloadActivationTypeId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the gift card type
        /// </summary>
        public GiftCardType GiftCardType
        {
            get
            {
                return (GiftCardType)this.GiftCardTypeId;
            }
            set
            {
                this.GiftCardTypeId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the low stock activity
        /// </summary>
        public LowStockActivity LowStockActivity
        {
            get
            {
                return (LowStockActivity)this.LowStockActivityId;
            }
            set
            {
                this.LowStockActivityId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the value indicating how to manage inventory
        /// </summary>
        public ManageInventoryMethod ManageInventoryMethod
        {
            get
            {
                return (ManageInventoryMethod)this.ManageInventoryMethodId;
            }
            set
            {
                this.ManageInventoryMethodId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the cycle period for recurring products
        /// </summary>
        public RecurringProductCyclePeriod RecurringCyclePeriod
        {
            get
            {
                return (RecurringProductCyclePeriod)this.RecurringCyclePeriodId;
            }
            set
            {
                this.RecurringCyclePeriodId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the period for rental products
        /// </summary>
        public RentalPricePeriod RentalPricePeriod
        {
            get
            {
                return (RentalPricePeriod)this.RentalPricePeriodId;
            }
            set
            {
                this.RentalPricePeriodId = (int)value;
            }
        }






        /// <summary>
        /// Gets or sets the collection of ProductCategory
        /// </summary>
        public virtual ICollection<ProductCategory> ProductCategories
        {
            get { return _productCategories ?? (_productCategories = new List<ProductCategory>()); }
            protected set { _productCategories = value; }
        }

        /// <summary>
        /// Gets or sets the collection of ProductManufacturer
        /// </summary>
        public virtual ICollection<ProductManufacturer> ProductManufacturers
        {
            get { return _productManufacturers ?? (_productManufacturers = new List<ProductManufacturer>()); }
            protected set { _productManufacturers = value; }
        }

        /// <summary>
        /// Gets or sets the collection of ProductPicture
        /// </summary>
        public virtual ICollection<ProductPicture> ProductPictures
        {
            get { return _productPictures ?? (_productPictures = new List<ProductPicture>()); }
            protected set { _productPictures = value; }
        }

        /// <summary>
        /// Gets or sets the collection of product reviews
        /// </summary>
        public virtual ICollection<ProductReview> ProductReviews
        {
            get { return _productReviews ?? (_productReviews = new List<ProductReview>()); }
            protected set { _productReviews = value; }
        }

        /// <summary>
        /// Gets or sets the product specification attribute
        /// </summary>
        public virtual ICollection<ProductSpecificationAttribute> ProductSpecificationAttributes
        {
            get { return _productSpecificationAttributes ?? (_productSpecificationAttributes = new List<ProductSpecificationAttribute>()); }
            protected set { _productSpecificationAttributes = value; }
        }

        /// <summary>
        /// Gets or sets the product tags
        /// </summary>
        public virtual ICollection<ProductTag> ProductTags
        {
            get { return _productTags ?? (_productTags = new List<ProductTag>()); }
            protected set { _productTags = value; }
        }

        /// <summary>
        /// Gets or sets the product attribute mappings
        /// </summary>
        public virtual ICollection<ProductAttributeMapping> ProductAttributeMappings
        {
            get { return _productAttributeMappings ?? (_productAttributeMappings = new List<ProductAttributeMapping>()); }
            protected set { _productAttributeMappings = value; }
        }

        /// <summary>
        /// Gets or sets the product attribute combinations
        /// </summary>
        public virtual ICollection<ProductAttributeCombination> ProductAttributeCombinations
        {
            get { return _productAttributeCombinations ?? (_productAttributeCombinations = new List<ProductAttributeCombination>()); }
            protected set { _productAttributeCombinations = value; }
        }

        /// <summary>
        /// Gets or sets the tier prices
        /// </summary>
        public virtual ICollection<TierPrice> TierPrices
        {
            get { return _tierPrices ?? (_tierPrices = new List<TierPrice>()); }
            protected set { _tierPrices = value; }
        }

        /// <summary>
        /// Gets or sets the collection of applied discounts
        /// </summary>
        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }
        
        /// <summary>
        /// Gets or sets the collection of "ProductWarehouseInventory" records. We use it only when "UseMultipleWarehouses" is set to "true" and ManageInventoryMethod" to "ManageStock"
        /// </summary>
        public virtual ICollection<ProductWarehouseInventory> ProductWarehouseInventory
        {
            get { return _productWarehouseInventory ?? (_productWarehouseInventory = new List<ProductWarehouseInventory>()); }
            protected set { _productWarehouseInventory = value; }
        }
    }
}