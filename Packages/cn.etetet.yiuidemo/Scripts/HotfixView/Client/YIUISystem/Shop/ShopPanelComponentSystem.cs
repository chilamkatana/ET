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
    [FriendOf(typeof(ShopPanelComponent))]
    public static partial class ShopPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopPanelComponent self)
        {
            self.u_DataViewIndex.SetValue(0);
            self.u_DataViewIndex.AddValueChangeAction(self.OnDataViewChange);
        }

        [EntitySystem]
        private static void Destroy(this ShopPanelComponent self)
        {

        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopPanelComponent self)
        {
            self.u_DataViewIndex.SetValue(1,true);
            await ETTask.CompletedTask;
            return true;
        }
        
        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopPanelComponent self, EShopPanelViewEnum view)
        {
            await ETTask.CompletedTask;

            self.u_DataViewIndex.SetValue((int)view,true);
            return true;
        }
        
        public static void OnDataViewChange(this ShopPanelComponent self, int arg1, int arg2)
        {
            self.UIPanel.OpenViewAsync(((EShopPanelViewEnum)arg1).ToString()).NoContext();
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
