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
    public partial class ShopPanelComponent : Entity,IYIUIOpen<EShopPanelViewEnum>
    {

    }

    [EnableClass]
    public class ShopItemData
    {
        public bool IsAd;       //是否广告
        public string Name;     //名称
        public string Icon;     //图标
        public int Price;    //价格
        public bool IsPopular;  //是否热门
    }
}
