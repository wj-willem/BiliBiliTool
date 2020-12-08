﻿using Microsoft.Extensions.Configuration;

namespace Ray.BiliBiliTool.Infrastructure
{
    /// <summary>
    /// 配置
    /// </summary>
    public class RayConfiguration
    {
        /// <summary>
        /// 根配置
        /// </summary>
        public static IConfigurationRoot Root { get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        public static string Env { get; set; }
    }
}
