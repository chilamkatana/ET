using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.24
    /// Desc
    /// </summary>
    [FriendOf(typeof(Equipment3ViewComponent))]
    public static partial class Equipment3ViewComponentSystem
    {
        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ET.Client.Equipment3ViewComponent self, YIUIFramework.ParamVo param1)
        {
            await ETTask.CompletedTask;
            return true;
        }
        [EntitySystem]
        private static void YIUIInitialize(this Equipment3ViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this Equipment3ViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this Equipment3ViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
