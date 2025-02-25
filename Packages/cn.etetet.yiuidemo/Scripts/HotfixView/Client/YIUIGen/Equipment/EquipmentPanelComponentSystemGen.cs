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
    [FriendOf(typeof(YIUIWindowComponent))]
    [FriendOf(typeof(YIUIPanelComponent))]
    [EntitySystemOf(typeof(EquipmentPanelComponent))]
    public static partial class EquipmentPanelComponentSystem
    {
        [EntitySystem]
        private static void Awake(this EquipmentPanelComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this EquipmentPanelComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this EquipmentPanelComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();
            self.u_UIWindow = self.UIBase.GetComponent<YIUIWindowComponent>();
            self.u_UIPanel = self.UIBase.GetComponent<YIUIPanelComponent>();
            self.UIWindow.WindowOption = EWindowOption.None;
            self.UIPanel.Layer = EPanelLayer.Panel;
            self.UIPanel.PanelOption = EPanelOption.TimeCache;
            self.UIPanel.StackOption = EPanelStackOption.VisibleTween;
            self.UIPanel.Priority = 0;
            self.UIPanel.CachePanelTime = 10;

            self.u_EventView1 = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventView1");
            self.u_EventView1Handle = self.u_EventView1.Add(self,EquipmentPanelComponent.OnEventView1Invoke);
            self.u_EventView2 = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventView2");
            self.u_EventView2Handle = self.u_EventView2.Add(self,EquipmentPanelComponent.OnEventView2Invoke);
            self.u_EventView3 = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventView3");
            self.u_EventView3Handle = self.u_EventView3.Add(self,EquipmentPanelComponent.OnEventView3Invoke);
            self.u_UIYIUIDemoHome = self.UIBase.CDETable.FindUIOwner<ET.Client.YIUIDemoHomeCommonComponent>("YIUIDemoHome");
            self.u_UIYIUIClose_Black = self.UIBase.CDETable.FindUIOwner<ET.Client.YIUICloseCommonComponent>("YIUIClose_Black");

        }
    }
}
