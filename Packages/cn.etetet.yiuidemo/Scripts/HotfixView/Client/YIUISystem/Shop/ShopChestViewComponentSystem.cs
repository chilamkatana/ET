using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.20
    /// Desc
    /// </summary>
    [FriendOf(typeof(ShopChestViewComponent))]
    public static partial class ShopChestViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopChestViewComponent self)
        {
            self.m_ShopItemDataList = new()
            {
                new ShopItemData(){Name = "Item1",Price = 10,Icon ="Chest_Close_m_01",IsAd = true,IsPopular = true},
                new ShopItemData(){Name = "Item2",Price = 20,Icon ="Chest_Close_m_02",IsAd = false,IsPopular = true},
                new ShopItemData(){Name = "Item3",Price = 30,Icon ="Chest_Close_m_03",IsAd = false,IsPopular = false},
                new ShopItemData(){Name = "Item4",Price = 40,Icon ="Chest_Close_m_04",IsAd = false,IsPopular = false},
                new ShopItemData(){Name = "Item5",Price = 50,Icon ="Chest_Close_m_05",IsAd = false,IsPopular = false},
            };

            self.m_Loop = self.AddChild<YIUILoopScrollChild, LoopScrollRect, Type, string>(self.u_ComLoopScrollHorizontal,
                typeof(ShopChestItemComponent), "u_EventSelect");
        }

        [EntitySystem]
        private static void YIUILoopRenderer(this ShopChestViewComponent self, ShopChestItemComponent item, ShopItemData data, int index, bool select)
        {
            item.Refresh(data);
            item.Select(select);
        }

        [EntitySystem]
        private static void YIUILoopOnClick(this ShopChestViewComponent self, ShopChestItemComponent item, ShopItemData data, int index, bool select)
        {
            item.Select(select);
        }
        

        [EntitySystem]
        private static void Destroy(this ShopChestViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopChestViewComponent self)
        {
            await ETTask.CompletedTask;
            self.Loop.ClearSelect();
            self.Loop.SetDataRefresh(self.m_ShopItemDataList,0).NoContext();
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
