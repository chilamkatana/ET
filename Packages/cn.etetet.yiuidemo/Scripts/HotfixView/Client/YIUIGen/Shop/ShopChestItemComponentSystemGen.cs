using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [FriendOf(typeof(YIUIChild))]
    [EntitySystemOf(typeof(ShopChestItemComponent))]
    public static partial class ShopChestItemComponentSystem
    {
        [EntitySystem]
        private static void Awake(this ShopChestItemComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this ShopChestItemComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this ShopChestItemComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();

            self.u_DataAd = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataAd");
            self.u_DataIcon = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueString>("u_DataIcon");
            self.u_DataName = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueString>("u_DataName");
            self.u_DataPopular = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataPopular");
            self.u_DataPrice = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueInt>("u_DataPrice");
            self.u_DataSelect = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataSelect");
            self.u_EventAd = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventAd");
            self.u_EventAdHandle = self.u_EventAd.Add(self,ShopChestItemComponent.OnEventAdInvoke);
            self.u_EventBuy = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventBuy");
            self.u_EventBuyHandle = self.u_EventBuy.Add(self,ShopChestItemComponent.OnEventBuyInvoke);
            self.u_EventSelect = self.UIBase.EventTable.FindEvent<UIEventP0>("u_EventSelect");
            self.u_EventSelectHandle = self.u_EventSelect.Add(self,ShopChestItemComponent.OnEventSelectInvoke);

        }
    }
}
