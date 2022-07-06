﻿// --------------------------
// 作者：烟雨迷离半世殇
// 邮箱：1778139321@qq.com
// 日期：2022年7月6日, 星期三
// --------------------------

namespace ET
{
    public class GlobalDefine
    {
        public static bool DevelopMode = true;

        /// <summary>
        /// 固定间隔的目标FPS
        /// </summary>
        public const int FixedUpdateTargetFPS = 30;

        public const float FixedUpdateTargetDTTime_Float = 1f / FixedUpdateTargetFPS;

        public const long FixedUpdateTargetDTTime_Long = (long)(FixedUpdateTargetDTTime_Float * 1000);
    }
}