using System.Collections.Generic;
using UIWidgetsSample;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using UnityEngine.Analytics;
using Color = Unity.UIWidgets.ui.Color;
using Icons = UIWidgetsSample.Icons;
using TextStyle = Unity.UIWidgets.painting.TextStyle;
using Image = Unity.UIWidgets.widgets.Image;


namespace Tackor.App
{
    public class AppMain : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new MaterialApp(
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
            
            private IndexedStack _body;
            
            private List<Widget> _pages = new List<Widget>
            {
                new HomePage(),
                new CommonPage("A", Colors.blue),
                new CommonPage("B", Colors.green),
                new CommonPage("C", Colors.orange),
                new CommonPage("D", Colors.cyan)
            };
    
            public override Widget build(BuildContext context)
            {
                _body = new IndexedStack(
                    children: _pages,
                    index: tabIndex
                    
                );
                
                return new Scaffold(
                
                    body: _body
                    ,
                    
                    floatingActionButton: new Container(
                        color: Colors.blue,
                        width: tabIndex == 2 ? 80 : 60,
                        height: tabIndex == 2 ? 80 : 60,
//                        margin: EdgeInsets.only(top: tabIndex == 2 ? 25 : 50),
                        margin: EdgeInsets.only(top: tabIndex == 2 ? 45 : 70),
                        child: new IconButton (
                            icon: GetCenterIcon(),
                            onPressed: () =>
                            {
                                setState(() => { tabIndex = centIndex;});
                            }
                        )
                    ),
                    floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked
                    ,
                    
                  //BottomNavigationBar ------------------
//                    bottomNavigationBar: new BottomNavigationBar_Capertino(
                    bottomNavigationBar: new BottomNavigationBar(
                        type: BottomNavigationBarType.fix,
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
                        },
                        onTap: ((index) => { setState(() => { tabIndex = index;}); })
                    )
                    
                );
            }
            
            
            //自定义方法 ----------------
            Image GetCenterIcon()
            {
                if (centIndex == tabIndex)
                    return Image.asset(Constants.CenterTabItem.activeIcon);
                
                return Image.asset(Constants.CenterTabItem.normalIcon);
            }
    
            Widget GetTabItemIcon(int index)
            {
                if (index == tabIndex)
                {
                    return new Container(
                        color: Colors.lightBlue,
                        child: new Padding(
                            padding: EdgeInsets.only(bottom: 5),
                            child: Image.asset(Constants.TabItems[index].activeIcon)
                        )
                    );
                }
                
                
                return new Container(
                    color: Colors.green,
                    child: new Padding(
                        padding: EdgeInsets.only(bottom: 5),
                        child: Image.asset(Constants.TabItems[index].normalIcon)
                    )
                );
            }
    
            Text GetTabItemTitle(int index)
            {
                return new Text(Constants.TabTitle[index], style: index==tabIndex ? tabTextStyleSelected : tabTextStyleNormal);
            }
            
        }
    }

    
}
