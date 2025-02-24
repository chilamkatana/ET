using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.20
    /// Desc
    /// </summary>
    [FriendOf(typeof(ShopChestItemComponent))]
    public static partial class ShopChestItemComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopChestItemComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this ShopChestItemComponent self)
        {
        }

        public static void Select(this ShopChestItemComponent self, bool value)
        {
            self.u_DataSelect.SetValue(value);
        }

        public static void Refresh(this ShopChestItemComponent self, ShopItemData shopItemData)
        {
            self.u_DataName.SetValue(shopItemData.Name);
            self.u_DataIcon.SetValue(shopItemData.Icon);
            self.u_DataPrice.SetValue(shopItemData.Price);
            self.u_DataPopular.SetValue(shopItemData.IsPopular);
            self.u_DataAd.SetValue(shopItemData.IsAd);
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(ShopChestItemComponent.OnEventSelectInvoke)]
        private static void OnEventSelectInvoke(this ShopChestItemComponent self)
        {

        }
        
        [YIUIInvoke(ShopChestItemComponent.OnEventBuyInvoke)]
        private static async ETTask OnEventBuyInvoke(this ShopChestItemComponent self)
        {
            Log.Error($"购买{self.u_DataName.GetValue()} 价格:{self.u_DataPrice.GetValue()}");
            await ETTask.CompletedTask;
        }
        
        [YIUIInvoke(ShopChestItemComponent.OnEventAdInvoke)]
        private static async ETTask OnEventAdInvoke(this ShopChestItemComponent self)
        {
            Log.Error($"看广告{self.u_DataName.GetValue()}");
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
