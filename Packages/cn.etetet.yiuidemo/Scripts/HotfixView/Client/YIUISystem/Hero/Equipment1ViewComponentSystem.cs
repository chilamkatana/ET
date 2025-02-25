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
    [FriendOf(typeof(Equipment1ViewComponent))]
    public static partial class Equipment1ViewComponentSystem
    {
        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ET.Client.Equipment1ViewComponent self, YIUIFramework.ParamVo param1)
        {
            Log.Error($"{param1.Get<int>()}");
            await ETTask.CompletedTask;
            return true;
        }
        [EntitySystem]
        private static void YIUIInitialize(this Equipment1ViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this Equipment1ViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this Equipment1ViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
