using Farmer.Core.Configuration;

namespace Farmer.Core.Domain
{
    public class CatalogSettings : ISettings
    {
        /// <summary>
        /// 是否展示产品SKU
        /// </summary>
        public bool ShowProductSku { get; set; }

        /// <summary>
        /// 是否展示制造商信息
        /// </summary>
        public bool ShowManufacturerPartNumber { get; set; }

        /// <summary>
        /// 是否展示GTN
        /// </summary>
        public bool ShowGtin { get; set; }

        /// <summary>
        /// 是否展示包邮信息
        /// </summary>
        public bool ShowFreeShippingNotification { get; set; }

        /// <summary>
        ///允许产品排序
        /// </summary>
        public bool AllowProductSorting { get; set; }

        /// <summary>
        /// 允许改变产品视图模型
        /// </summary>
        public bool AllowProductViewModeChanging { get; set; }

        /// <summary>
        /// 缺省视图模式
        /// </summary>
        public string DefaultViewMode { get; set; }

        /// <summary>
        /// 是否从子分类中显示
        /// </summary>
        public bool ShowProductsFromSubcategories { get; set; }

        /// <summary>
        /// 是否展示分类产品Number
        /// </summary>
        public bool ShowCategoryProductNumber { get; set; }

        /// <summary>
        /// 是否展示分类产品Number包含子类
        /// </summary>
        public bool ShowCategoryProductNumberIncludingSubcategories { get; set; }

        /// <summary>
        /// 是否允许分类面包屑
        /// </summary>
        public bool CategoryBreadcrumbEnabled { get; set; }
        
        /// <summary>
        ///展示分享按钮
        /// </summary>
        public bool ShowShareButton { get; set; }

        /// <summary>
        /// 页面分享码
        /// </summary>
        public string PageShareCode { get; set; }

        /// <summary>
        ///回复是否必须审核
        /// </summary>
        public bool ProductReviewsMustBeApproved { get; set; }

        /// <summary>
        /// 缺省产品分值
        /// </summary>
        public int DefaultProductRatingValue { get; set; }

        /// <summary>
        ///是否允许任何人评论
        /// </summary>
        public bool AllowAnonymousUsersToReviewProduct { get; set; }

        /// <summary>
        /// 新评论是否通知
        /// </summary>
        public bool NotifyStoreOwnerAboutNewProductReviews { get; set; }

        /// <summary>
        /// 允许发送好友邮件
        /// </summary>
        public bool EmailAFriendEnabled { get; set; }

        /// <summary>
        /// 是否允许任何人发送邮件
        /// </summary>
        public bool AllowAnonymousUsersToEmailAFriend { get; set; }

        /// <summary>
        /// 最近查看产品
        /// </summary>
        public int RecentlyViewedProductsNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "Recently viewed products" feature is enabled
        /// </summary>
        public bool RecentlyViewedProductsEnabled { get; set; }

        /// <summary>
        /// 最新上架产品
        /// </summary>
        public string RecentlyAddedProductsNumber { get; set; }

        /// <summary>
        /// 是否允许最新产品
        /// </summary>
        public bool RecentlyAddedProductsEnabled { get; set; }

        /// <summary>
        /// 是否允许产品比较
        /// </summary>
        public bool CompareProductsEnabled { get; set; }

        /// <summary>
        /// 比较的产品号
        /// </summary>
        public int CompareProductsNumber { get; set; }

        /// <summary>
        ///搜索自动完成允许
        /// </summary>
        public bool ProductSearchAutoCompleteEnabled { get; set; }

        /// <summary>
        ///产品自动搜索完成产品号
        /// </summary>
        public string ProductSearchAutoCompleteNumberOfProducts { get; set; }

        /// <summary>
        /// 自动搜索完成时产品图片
        /// </summary>
        public bool ShowProductImagesInSearchAutoComplete { get; set; }

        /// <summary>
        ///产品搜索最小长度
        /// </summary>
        public int ProductSearchTermMinimumLength { get; set; }
        
        /// <summary>
        /// 是否首页展示畅销产品
        /// </summary>
        public bool ShowBestsellersOnHomepage { get; set; }

        /// <summary>
        /// 首页展示最畅销产品值
        /// </summary>
        public int NumberOfBestsellersOnHomepage { get; set; }

        /// <summary>
        /// 准备搜索产品页面
        /// </summary>
        public int SearchPageProductsPerPage { get; set; }
        /// <summary>
        /// 允许自定义产品搜索页大小
        /// </summary>
        public bool SearchPageAllowCustomersToSelectPageSize { get; set; }
        /// <summary>
        /// 搜索页面尺寸选项
        /// </summary>
        public string SearchPagePageSizeOptions { get; set; }

        /// <summary>
        ///是否允许产品也购买了
        /// </summary>
        public bool ProductsAlsoPurchasedEnabled { get; set; }

        /// <summary>
        /// 也购买的产品Id
        /// </summary>
        public string ProductsAlsoPurchasedNumber { get; set; }

        /// <summary>
        /// 是否允许动态价格更新
        /// </summary>
        public bool EnableDynamicPriceUpdate { get; set; }

        /// <summary>
        ///动态价格更新Ajax
        /// </summary>
        public bool DynamicPriceUpdateAjax { get; set; }

        /// <summary>
        /// 产品标签
        /// </summary>
        public int NumberOfProductTags { get; set; }

        /// <summary>
        /// 标签页产品数量
        /// </summary>
        public int ProductsByTagPageSize { get; set; }

        /// <summary>
        /// 产品标签是否允许顾客选择页面大小
        /// </summary>
        public bool ProductsByTagAllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// 标签页产品配置
        /// </summary>
        public string ProductsByTagPageSizeOptions { get; set; }

        /// <summary>
        /// 产品比较包含短描述
        /// </summary>
        public bool IncludeShortDescriptionInCompareProducts { get; set; }

        /// <summary>
        /// 产品比较页面包含完整描述
        /// </summary>
        public bool IncludeFullDescriptionInCompareProducts { get; set; }
        
        /// <summary>
        /// 产品正常list包含特性
        /// </summary>
        public bool IncludeFeaturedProductsInNormalLists { get; set; }
        
        /// <summary>
        /// 显示折扣价格层
        /// </summary>
        public bool DisplayTierPricesWithDiscounts { get; set; }
        
        /// <summary>
        /// 忽略优惠
        /// </summary>
        public bool IgnoreDiscounts { get; set; }

        /// <summary>
        /// 忽略产品特性
        /// </summary>
        public bool IgnoreFeaturedProducts { get; set; }

        /// <summary>
        /// 忽略负荷
        /// </summary>
        public bool IgnoreAcl { get; set; }

        /// <summary>
        /// 忽略库存最小值
        /// </summary>
        public bool IgnoreStoreLimitations { get; set; }

        /// <summary>
        /// 是否允许缓存产品价格
        /// </summary>
        public bool CacheProductPrices { get; set; }

        /// <summary>
        /// Gets or sets a value indicating maximum number of 'back in stock' subscription
        /// </summary>
        public int MaximumBackInStockSubscriptions { get; set; }

        /// <summary>
        /// 制造商块显示
        /// </summary>
        public int ManufacturersBlockItemsToDisplay { get; set; }

        /// <summary>
        /// 是否显示运费信息
        /// </summary>
        public bool DisplayTaxShippingInfoFooter { get; set; }
        /// <summary>
        ///详情页是否显示运费信息
        /// </summary>
        public bool DisplayTaxShippingInfoProductDetailsPage { get; set; }
        /// <summary>
        ///产品盒子显示运费信息
        /// </summary>
        public bool DisplayTaxShippingInfoProductBoxes { get; set; }
        /// <summary>
        /// 购物车显示快递价格
        /// </summary>
        public bool DisplayTaxShippingInfoShoppingCart { get; set; }
        /// <summary>
        /// 收藏夹显示运费价格
        /// </summary>
        public bool DisplayTaxShippingInfoWishlist { get; set; }
        /// <summary>
        ///订单详情页显示价格
        /// </summary>
        public bool DisplayTaxShippingInfoOrderDetailsPage { get; set; }


        /// <summary>
        /// 缺省分类页面大小设置
        /// </summary>
        public string DefaultCategoryPageSizeOptions { get; set; }
        /// <summary>
        /// 缺省分类页尺寸
        /// </summary>
        public int DefaultCategoryPageSize { get; set; }
        /// <summary>
        /// 缺省制造商页面大小设定
        /// </summary>
        public string DefaultManufacturerPageSizeOptions { get; set; }
        /// <summary>
        /// 缺省制造商页面大小
        /// </summary>
        public int DefaultManufacturerPageSize { get; set; }
    }
}