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
    [FriendOf(typeof(Equipment2ViewComponent))]
    public static partial class Equipment2ViewComponentSystem
    {
        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ET.Client.Equipment2ViewComponent self, YIUIFramework.ParamVo param1)
        {
            Log.Error($"{param1.Get<string>()}");
            await ETTask.CompletedTask;
            return true;
        }
        [EntitySystem]
        private static void YIUIInitialize(this Equipment2ViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this Equipment2ViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this Equipment2ViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
