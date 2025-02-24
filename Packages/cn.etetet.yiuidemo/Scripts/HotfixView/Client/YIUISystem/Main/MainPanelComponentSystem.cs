using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    [FriendOf(typeof(MainPanelComponent))]
    public static partial class MainPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this MainPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this MainPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this MainPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(MainPanelComponent.OnEventShopInvoke)]
        private static async ETTask OnEventShopInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<ShopPanelComponent>();
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventGoldInvoke)]
        private static async ETTask OnEventGoldInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<ShopPanelComponent, EShopPanelViewEnum>(EShopPanelViewEnum.ShopGoldView);
            await ETTask.CompletedTask;
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventGemInvoke)]
        private static async ETTask OnEventGemInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<ShopPanelComponent, EShopPanelViewEnum>(EShopPanelViewEnum.ShopGemView);
            await ETTask.CompletedTask;
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventHeroInvoke)]
        private static async ETTask OnEventHeroInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<HeroPanelComponent>();
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
