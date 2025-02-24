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
    [FriendOf(typeof(YIUIDemoHomeCommonComponent))]
    public static partial class YIUIDemoHomeCommonComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this YIUIDemoHomeCommonComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this YIUIDemoHomeCommonComponent self)
        {
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(YIUIDemoHomeCommonComponent.OnEventHomeInvoke)]
        private static async ETTask OnEventHomeInvoke(this YIUIDemoHomeCommonComponent self)
        {
            await YIUIMgrComponent.Inst.HomePanel<MainPanelComponent>();
        }
        #endregion YIUIEvent结束
    }
}
