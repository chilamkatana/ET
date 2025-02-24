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
    [EntitySystemOf(typeof(YIUIDemoHomeCommonComponent))]
    public static partial class YIUIDemoHomeCommonComponentSystem
    {
        [EntitySystem]
        private static void Awake(this YIUIDemoHomeCommonComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this YIUIDemoHomeCommonComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this YIUIDemoHomeCommonComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();

            self.u_EventHome = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventHome");
            self.u_EventHomeHandle = self.u_EventHome.Add(self,YIUIDemoHomeCommonComponent.OnEventHomeInvoke);

        }
    }
}
