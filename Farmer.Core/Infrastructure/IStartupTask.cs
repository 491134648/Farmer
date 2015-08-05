﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Infrastructure
{
    /// <summary>
    /// 开始任务接口
    /// </summary>
   public interface IStartupTask
    {
        /// <summary>
        ///执行任务
        /// </summary>
        void Execute();

        /// <summary>
        /// Order
        /// </summary>
        int Order { get; }
    }
}
