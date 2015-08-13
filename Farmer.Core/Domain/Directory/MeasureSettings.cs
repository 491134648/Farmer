
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 测量设定
    /// </summary>
    public class MeasureSettings : ISettings
    {
        public Guid BaseDimensionId { get; set; }
        public Guid BaseWeightId { get; set; }
    }
}