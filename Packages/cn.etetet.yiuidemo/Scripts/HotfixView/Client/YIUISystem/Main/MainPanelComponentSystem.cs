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
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventGemInvoke)]
        private static async ETTask OnEventGemInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<ShopPanelComponent, EShopPanelViewEnum>(EShopPanelViewEnum.ShopGemView);
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventHeroInvoke)]
        private static async ETTask OnEventHeroInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<HeroPanelComponent>();
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventEquipmentInvoke)]
        private static async ETTask OnEventEquipmentInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<EquipmentPanelComponent>();
        }
        
        [YIUIInvoke(MainPanelComponent.OnEventSettingsInvoke)]
        private static async ETTask OnEventSettingsInvoke(this MainPanelComponent self)
        {
            await YIUIMgrComponent.Inst.Root.OpenPanelAsync<SettingsPanelComponent>();
        }
        #endregion YIUIEvent结束
    }
}
