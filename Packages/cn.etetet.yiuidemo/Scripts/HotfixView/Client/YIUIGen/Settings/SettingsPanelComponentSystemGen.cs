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
    [EntitySystemOf(typeof(SettingsPanelComponent))]
    public static partial class SettingsPanelComponentSystem
    {
        [EntitySystem]
        private static void Awake(this SettingsPanelComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this SettingsPanelComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this SettingsPanelComponent self)
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

            self.u_DataLanguage = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueString>("u_DataLanguage");
            self.u_EventLanguage = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventLanguage");
            self.u_EventLanguageHandle = self.u_EventLanguage.Add(self,SettingsPanelComponent.OnEventLanguageInvoke);
            self.u_UIYIUIClose_Black = self.UIBase.CDETable.FindUIOwner<ET.Client.YIUICloseCommonComponent>("YIUIClose_Black");

        }
    }
}
