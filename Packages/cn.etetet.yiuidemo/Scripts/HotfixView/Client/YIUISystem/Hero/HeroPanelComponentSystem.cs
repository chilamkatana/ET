using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.23
    /// Desc
    /// </summary>
    [FriendOf(typeof(HeroPanelComponent))]
    public static partial class HeroPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this HeroPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this HeroPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this HeroPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(HeroPanelComponent.OnEventShopGoldInvoke)]
        private static async ETTask OnEventShopGoldInvoke(this HeroPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<ShopPanelComponent, EShopPanelViewEnum>(EShopPanelViewEnum.ShopGoldView);
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
