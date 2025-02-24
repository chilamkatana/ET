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
    public partial class HeroPanelComponent : Entity, IDestroy, IAwake, IYIUIBind, IYIUIInitialize, IYIUIOpen
    {
        public const string PkgName = "Hero";
        public const string ResName = "HeroPanel";

        public EntityRef<YIUIChild> u_UIBase;
        public YIUIChild UIBase => u_UIBase;
        public EntityRef<YIUIWindowComponent> u_UIWindow;
        public YIUIWindowComponent UIWindow => u_UIWindow;
        public EntityRef<YIUIPanelComponent> u_UIPanel;
        public YIUIPanelComponent UIPanel => u_UIPanel;
        public EntityRef<ET.Client.YIUIDemoHomeCommonComponent> u_UIYIUIDemoHome;
        public ET.Client.YIUIDemoHomeCommonComponent UIYIUIDemoHome => u_UIYIUIDemoHome;
        public EntityRef<ET.Client.YIUICloseCommonComponent> u_UIYIUIClose_Black;
        public ET.Client.YIUICloseCommonComponent UIYIUIClose_Black => u_UIYIUIClose_Black;
        public UITaskEventP0 u_EventShopGold;
        public UITaskEventHandleP0 u_EventShopGoldHandle;
        public const string OnEventShopGoldInvoke = "HeroPanelComponent.OnEventShopGoldInvoke";

    }
}