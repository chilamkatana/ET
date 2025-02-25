using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{

    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [YIUI(EUICodeType.View)]
    [ComponentOf(typeof(YIUIChild))]
    public partial class LanguageViewComponent : Entity, IDestroy, IAwake, IYIUIBind, IYIUIInitialize, IYIUIOpen
    {
        public const string PkgName = "Settings";
        public const string ResName = "LanguageView";

        public EntityRef<YIUIChild> u_UIBase;
        public YIUIChild UIBase => u_UIBase;
        public EntityRef<YIUIWindowComponent> u_UIWindow;
        public YIUIWindowComponent UIWindow => u_UIWindow;
        public EntityRef<YIUIViewComponent> u_UIView;
        public YIUIViewComponent UIView => u_UIView;
        public YIUIFramework.UIDataValueString u_DataLanguage;
        public EntityRef<ET.Client.YIUICloseCommonComponent> u_UIYIUICloseCommon;
        public ET.Client.YIUICloseCommonComponent UIYIUICloseCommon => u_UIYIUICloseCommon;
        public EntityRef<ET.Client.YIUICloseCommonComponent> u_UIYIUIClose;
        public ET.Client.YIUICloseCommonComponent UIYIUIClose => u_UIYIUIClose;

    }
}