using System;
using System.Collections.Generic;
using System.Linq;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;
using Image = Unity.UIWidgets.widgets.Image;


namespace Tackor.App
{
//    public class AppMain : UIWidgetsPanel
    public class AppMain : MaterialApp
    {
//        protected virtual PageRouteFactory pageRouteBuilder {
//            get {
//                return (RouteSettings settings, WidgetBuilder builder) =>
//                    new PageRouteBuilder(
//                        settings: settings,
//                        pageBuilder: (BuildContext context, Animation<float> animation,
//                            Animation<float> secondaryAnimation) => builder(context)
//                    );
//            }
//        }
        
        protected override Widget createWidget()
        {
            return new WidgetsApp(
                home: new RootPage()
            );
        }
        
        public class RootPage : StatefulWidget
        {
            public override State createState()
            {
                return new RootPageState();
            }
        }
        
        public class RootPageState : State<RootPage>
        {
            private int centIndex = Constants.TabTitle.Count / 2;
            private int tabIndex = 0;
            TextStyle tabTextStyleNormal = new TextStyle(color: new Color(0xff969696));
            TextStyle tabTextStyleSelected = new TextStyle(color: Colors.pink[300]);
            
            private List<Widget> _pages = new List<Widget>
            {
                new CommonPage("首页", Colors.red),
                new CommonPage("A", Colors.blue),
                new CommonPage("B", Colors.green),
                new CommonPage("C", Colors.orange),
                new CommonPage("D", Colors.cyan)
            };
    
            private IndexedStack _body;
    
            public override Widget build(BuildContext context)
            {
                _body = new IndexedStack(
                    children: _pages.ToList()
                );
                
                return new Scaffold(
                    body: _body
                    ,
                    
                    floatingActionButton: new Container(
                        width: tabIndex == 2 ? 75 : 50,
                        height: tabIndex == 2 ? 75 : 50,
                        margin: EdgeInsets.only(top: tabIndex == 2 ? 25 : 50),
                        child: new IconButton (
                            icon: GetCenterIcon(),
                            onPressed: () =>
                            {
                                setState(() => { tabIndex = centIndex;});
                            }
                        )
                    ),
                    floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
                    
                    //BottomNavigationBar ------------------
                    bottomNavigationBar: new BottomNavigationBar(
                        items: new List<BottomNavigationBarItem>
                        {
                            new BottomNavigationBarItem(
                                icon: GetTabItemIcon(0),
                                title: GetTabItemTitle(0)
                            ),
                            new BottomNavigationBarItem(
                                icon: GetTabItemIcon(1),
                                title: GetTabItemTitle(1)
                            ),
                            new BottomNavigationBarItem(
                                icon: GetTabItemIcon(2),
                                title: GetTabItemTitle(2)
                            ),
                            new BottomNavigationBarItem(
                                icon: GetTabItemIcon(3),
                                title: GetTabItemTitle(3)
                            ),
                            new BottomNavigationBarItem(
                                icon: GetTabItemIcon(4),
                                title: GetTabItemTitle(4)
                            ),
                        }
                    )
                    
                );
            }
            
            
            //自定义方法 ----------------
            Image GetCenterIcon()
            {
                if (centIndex == tabIndex)
                    return Image.asset(Constants.CenterTabItem.activeIcon, width: 80, height: 80);
                
                return Image.asset(Constants.CenterTabItem.normalIcon, width: 50, height: 50);
            }
    
            Image GetTabItemIcon(int index)
            {
                return Image.asset(Constants.TabItems[index].normalIcon, width: 50, height: 50);
            }
    
            Text GetTabItemTitle(int index)
            {
                return new Text(Constants.TabTitle[index], style: index==tabIndex ? tabTextStyleSelected : tabTextStyleNormal);
            }
            
        }
    }

    
}
