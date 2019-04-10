using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;

namespace Tackor.App
{
    
    public class TabItem
    {
        public string normalIcon;
        public string activeIcon;
    
        public TabItem(string normalIcon, string activeIcon)
        {
            this.normalIcon = normalIcon;
            this.activeIcon = activeIcon;
        }
    }
    
    public class Constants
    {
        //Theme ----------------------------------
        /// <summary>
        /// 主题颜色
        /// </summary>
        private static Color CurThemeColor = new Color(0xFFFB7299);
        
        //BottomTabBar ----------------------------------
        /// <summary>T
        /// BottomBar Item的文本
        /// </summary>
        public static List<string> TabTitle = new List<string>
        {
            "首页", "频道", "", "会员购", "我的"
        };
        
        /// <summary>
        /// BottomTabBar 中间BarItem
        /// </summary>
        public static TabItem CenterTabItem = new TabItem("Images/center_normal", "Images/center_active");
    
        /// <summary>
        /// BottomTabBar 其他BarItem
        /// </summary>
        public static List<TabItem> TabItems = new List<TabItem>
        {
            new TabItem("Images/home_normal", "Images/home_active"),
            new TabItem("Images/pindao_normal", "Images/pindao_active"),
            new TabItem("Images/normal", "Images/normal"),
            new TabItem("Images/huiyuangou_normal", "Images/huiyuangou_active"),
            new TabItem("Images/my_normal", "Images/my_active"),
        };
        
    }
}
