using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{

    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [YIUI(EUICodeType.Common)]
    [ComponentOf(typeof(YIUIChild))]
    public partial class ShopChestItemComponent : Entity, IDestroy, IAwake, IYIUIBind, IYIUIInitialize
    {
        public const string PkgName = "Shop";
        public const string ResName = "ShopChestItem";

        public EntityRef<YIUIChild> u_UIBase;
        public YIUIChild UIBase => u_UIBase;
        public YIUIFramework.UIDataValueBool u_DataAd;
        public YIUIFramework.UIDataValueString u_DataIcon;
        public YIUIFramework.UIDataValueString u_DataName;
        public YIUIFramework.UIDataValueBool u_DataPopular;
        public YIUIFramework.UIDataValueInt u_DataPrice;
        public YIUIFramework.UIDataValueBool u_DataSelect;
        public UITaskEventP0 u_EventAd;
        public UITaskEventHandleP0 u_EventAdHandle;
        public const string OnEventAdInvoke = "ShopChestItemComponent.OnEventAdInvoke";
        public UITaskEventP0 u_EventBuy;
        public UITaskEventHandleP0 u_EventBuyHandle;
        public const string OnEventBuyInvoke = "ShopChestItemComponent.OnEventBuyInvoke";
        public UIEventP0 u_EventSelect;
        public UIEventHandleP0 u_EventSelectHandle;
        public const string OnEventSelectInvoke = "ShopChestItemComponent.OnEventSelectInvoke";

    }
}