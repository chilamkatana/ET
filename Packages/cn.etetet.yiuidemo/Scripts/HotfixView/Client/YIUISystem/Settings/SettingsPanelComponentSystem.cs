using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;
using I2.Loc;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.24
    /// Desc
    /// </summary>
    [FriendOf(typeof(SettingsPanelComponent))]
    public static partial class SettingsPanelComponentSystem
    {
        [EntitySystem]
        private static async ETTask DynamicEvent(this ET.Client.SettingsPanelComponent self, ET.Client.EventView_ChangeLanguage param1)
        {
            await ETTask.CompletedTask;
            
            self.u_DataLanguage.SetValue(param1.Language);
        }
        [EntitySystem]
        private static void YIUIInitialize(this SettingsPanelComponent self)
        {
            self.u_DataLanguage.SetValue(I2LocalizeMgr.Inst.CurrentLanguage);
        }

        [EntitySystem]
        private static void Destroy(this SettingsPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this SettingsPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始

        [YIUIInvoke(SettingsPanelComponent.OnEventLanguageInvoke)]
        private static async ETTask OnEventLanguageInvoke(this SettingsPanelComponent self)
        {
            await self.UIPanel.OpenViewAsync<LanguageViewComponent>();
        }
        #endregion YIUIEvent结束
    }
}
