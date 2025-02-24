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
    public partial class ShopChestViewComponent : Entity
    {
        public List<ShopItemData> m_ShopItemDataList;
        public EntityRef<YIUILoopScrollChild> m_Loop;
        
        public YIUILoopScrollChild Loop => this.m_Loop;
    }
}
