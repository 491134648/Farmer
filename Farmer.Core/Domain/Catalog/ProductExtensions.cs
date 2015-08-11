using System;
using System.Collections.Generic;
using System.Linq;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品扩展信息
    /// </summary>
    public static class ProductExtensions
    {
        /// <summary>
        /// 转换必须产品数组
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>A list of required product IDs</returns>
        public static string[] ParseRequiredProductIds(this Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            if (String.IsNullOrEmpty(product.RequiredProductIds))
                return new string[0];

            var ids = new List<string>();

            foreach (var idStr in product.RequiredProductIds
                .Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()))
            {
              if(!string.IsNullOrEmpty(idStr))
                    ids.Add(idStr);
            }

            return ids.ToArray();
        }

        /// <summary>
        /// 产品是否有效
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>Result</returns>
        public static bool IsAvailable(this Product product)
        {
            return IsAvailable(product, DateTime.Now);
        }

        /// <summary>
        /// Get a value indicating whether a product is available now (availability dates)
        /// </summary>
        /// <param name="product">Product</param>
        /// <param name="dateTime">Datetime to check</param>
        /// <returns>Result</returns>
        public static bool IsAvailable(this Product product, DateTime dateTime)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            if (product.AvailableStartDateTime.HasValue && product.AvailableStartDateTime.Value > dateTime)
            {
                return false;
            }

            if (product.AvailableEndDateTimeUtc.HasValue && product.AvailableEndDateTimeUtc.Value < dateTime)
            {
                return false;
            }

            return true;
        }
    }
}
