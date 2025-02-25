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
    [FriendOf(typeof(LanguageViewComponent))]
    public static partial class LanguageViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this LanguageViewComponent self)
        {
            self.u_DataLanguage.SetValue(I2LocalizeMgr.Inst.CurrentLanguage);
            self.u_DataLanguage.AddValueChangeAction(self.OnDataLanguageChange);
        }

        [EntitySystem]
        private static void Destroy(this LanguageViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this LanguageViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }
        
        private static void OnDataLanguageChange(this LanguageViewComponent self,string arg1, string arg2)
        {
            I2LocalizeMgr.Inst.SetLanguage(arg1);
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
