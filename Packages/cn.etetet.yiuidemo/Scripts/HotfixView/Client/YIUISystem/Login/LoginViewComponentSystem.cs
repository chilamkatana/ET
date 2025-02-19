using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  ck
    /// Date    2025.2.18
    /// Desc
    /// </summary>
    [FriendOf(typeof(LoginViewComponent))]
    public static partial class LoginViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this LoginViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this LoginViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this LoginViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(LoginViewComponent.OnEventLoginInvoke)]
        private static async ETTask OnEventLoginInvoke(this LoginViewComponent self)
        {
            Log.Info($"登录");
            GlobalComponent globalComponent = self.Root().GetComponent<GlobalComponent>();
            await LoginHelper.Login(self.Root(),
                globalComponent.GlobalConfig.Address,
                self.u_ComAccount.text,
                self.u_ComPassWord.text);
        }
        
        [YIUIInvoke(LoginViewComponent.OnEventLoginSignUpInvoke)]
        private static async ETTask OnEventLoginSignUpInvoke(this LoginViewComponent self)
        {
            await self.UIView.GetPanelComponent().OpenViewAsync<LoginSignUpViewComponent>();
            // await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
