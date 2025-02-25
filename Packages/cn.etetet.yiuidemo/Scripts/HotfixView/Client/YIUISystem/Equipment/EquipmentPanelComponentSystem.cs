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
    [FriendOf(typeof(EquipmentPanelComponent))]
    public static partial class EquipmentPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this EquipmentPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this EquipmentPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this EquipmentPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(EquipmentPanelComponent.OnEventView3Invoke)]
        private static async ETTask OnEventView3Invoke(this EquipmentPanelComponent self)
        {
            TipsHelper.OpenSync<Equipment3ViewComponent>();
            await ETTask.CompletedTask;
        }
        
        [YIUIInvoke(EquipmentPanelComponent.OnEventView2Invoke)]
        private static async ETTask OnEventView2Invoke(this EquipmentPanelComponent self)
        {
            TipsHelper.OpenSync<Equipment2ViewComponent>("view2");
            await ETTask.CompletedTask;
        }
        
        [YIUIInvoke(EquipmentPanelComponent.OnEventView1Invoke)]
        private static async ETTask OnEventView1Invoke(this EquipmentPanelComponent self)
        {
            TipsHelper.OpenSync<Equipment1ViewComponent>(1234);
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
