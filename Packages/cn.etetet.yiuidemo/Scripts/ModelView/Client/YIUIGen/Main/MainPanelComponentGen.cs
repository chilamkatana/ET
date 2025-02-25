using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{

    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [YIUI(EUICodeType.Panel, EPanelLayer.Panel)]
    [ComponentOf(typeof(YIUIChild))]
    public partial class MainPanelComponent : Entity, IDestroy, IAwake, IYIUIBind, IYIUIInitialize, IYIUIOpen
    {
        public const string PkgName = "Main";
        public const string ResName = "MainPanel";

        public EntityRef<YIUIChild> u_UIBase;
        public YIUIChild UIBase => u_UIBase;
        public EntityRef<YIUIWindowComponent> u_UIWindow;
        public YIUIWindowComponent UIWindow => u_UIWindow;
        public EntityRef<YIUIPanelComponent> u_UIPanel;
        public YIUIPanelComponent UIPanel => u_UIPanel;
        public UITaskEventP0 u_EventShop;
        public UITaskEventHandleP0 u_EventShopHandle;
        public const string OnEventShopInvoke = "MainPanelComponent.OnEventShopInvoke";
        public UITaskEventP0 u_EventGem;
        public UITaskEventHandleP0 u_EventGemHandle;
        public const string OnEventGemInvoke = "MainPanelComponent.OnEventGemInvoke";
        public UITaskEventP0 u_EventGold;
        public UITaskEventHandleP0 u_EventGoldHandle;
        public const string OnEventGoldInvoke = "MainPanelComponent.OnEventGoldInvoke";
        public UITaskEventP0 u_EventHero;
        public UITaskEventHandleP0 u_EventHeroHandle;
        public const string OnEventHeroInvoke = "MainPanelComponent.OnEventHeroInvoke";
        public UITaskEventP0 u_EventEquipment;
        public UITaskEventHandleP0 u_EventEquipmentHandle;
        public const string OnEventEquipmentInvoke = "MainPanelComponent.OnEventEquipmentInvoke";
        public UITaskEventP0 u_EventSettings;
        public UITaskEventHandleP0 u_EventSettingsHandle;
        public const string OnEventSettingsInvoke = "MainPanelComponent.OnEventSettingsInvoke";

    }
}