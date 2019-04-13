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
        public static Color CurThemeColor = new Color(0xFFFB7299);
        
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
        
        
        //HomePage ----------------------------------
        public static List<string> TopTitles = new List<string>
        {
            "推荐",
            "关注"
        };
        
        
        //测试 ----------------------------------
        public static List<HomeItemModel> Test_HomeListData = new List<HomeItemModel>
        {
            new HomeItemModel(
                "https://upload.jianshu.io/users/upload_avatars/1476913/37ca4d8d-3f30-4e26-9ca3-85362ae338e2.png?imageMogr2/auto-orient/strip|imageView2/1/w/240/h/240",
                "推荐 - tackor",
                "下面是新创作的作品, 希望大家喜欢! 求关注, 多多转发, 点赞!!!",
                "3小时前",
                "---",
                "9.2w",
                "6.5w",
                "2.8w",
                "1.3w"
            ),
            new HomeItemModel(
                "https://upload.jianshu.io/users/upload_avatars/1476913/37ca4d8d-3f30-4e26-9ca3-85362ae338e2.png?imageMogr2/auto-orient/strip|imageView2/1/w/240/h/240",
                "推荐 - tackor",
                "下面是新创作的作品, 希望大家喜欢! 求关注, 多多转发, 点赞!!! 下面是新创作的作品, 希望大家喜欢! 求关注, 多多转发, 点赞!!!",
                "12分钟前",
                "---",
                "9.2w",
                "6.5w",
                "2.8w",
                "1.3w"
            ),
            new HomeItemModel(
                "https://upload.jianshu.io/users/upload_avatars/1476913/37ca4d8d-3f30-4e26-9ca3-85362ae338e2.png?imageMogr2/auto-orient/strip|imageView2/1/w/240/h/240",
                "推荐 - tackor",
                "1341345123",
                "67分钟前",
                "---",
                "9.2w",
                "6.5w",
                "2.8w",
                "1.3w"
            ),
            new HomeItemModel(
                "https://upload.jianshu.io/users/upload_avatars/1476913/37ca4d8d-3f30-4e26-9ca3-85362ae338e2.png?imageMogr2/auto-orient/strip|imageView2/1/w/240/h/240",
                "推荐 - tackor",
                "839482942",
                "半个钟头前",
                "---",
                "9.2w",
                "32326.5w",
                "2.8w",
                "1.3w"
            ),
            new HomeItemModel(
                "https://upload.jianshu.io/users/upload_avatars/1476913/37ca4d8d-3f30-4e26-9ca3-85362ae338e2.png?imageMogr2/auto-orient/strip|imageView2/1/w/240/h/240",
                "推荐 - tackor",
                "下希望大家喜欢! 求关注, 多多转发, 点赞!!!",
                "3个月前",
                "---",
                "9.2w",
                "6.5w",
                "13232.8w",
                "987.0w"
            )
        };
        
        
    }
}
