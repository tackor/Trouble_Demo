using System;
using System.Collections.Generic;
using System.Linq;
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
using UIWidgetsGallery.gallery;


namespace Tackor.App
{
    public class HomePage : StatefulWidget
    {
        public override State createState()
        {
            return new HomePageState();
        }
    }
    
    public class HomePageState : SingleTickerProviderStateMixin<HomePage>
    {
        private TabController _tabController;
//        private ScrollController _scrollViewController;

        /// <summary>
        /// 搜索框的点击事件
        /// </summary>
        void SearchAct()
        {
            Debug.Log("Search -----------> ");
        }

        public override void initState()
        {
            base.initState();
            
            _tabController = new TabController(length: Constants.TopTitles.Count, vsync: this);
//            _scrollViewController = new ScrollController(initialScrollOffset: 0.0f);
        }

        public override void dispose()
        {
            _tabController.dispose();
//            _scrollViewController.dispose();
            
            base.dispose();
        }

        //推荐页面
        Widget TuiJianView()
        {
            return new Container(
                color: Colors.lightBlue,
                child: ListView.builder(
                    itemCount: Constants.Test_HomeListData.Count,
                    itemBuilder: (context, i) =>
                    {
                        return CreateCell(i);
                    }
                )
            );
        }
        
        //关注页面
        Widget GuanZhuView()
        {
            return new Container(
                color: Colors.green
            );
        }

        StatefulWidget CreateCell(int index)
        {
            return new HomeItemView(Constants.Test_HomeListData[index]);
        }


        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                appBar: new AppBar (
                    backgroundColor: Colors.white,
                    brightness: Brightness.light,
                    elevation: 0
                    
                    //左侧搜索按钮-------------
                    ,
                    leading: new IconButton(
                        icon: new Icon(Icons.search, color: Colors.black87),
                        onPressed: () => { SearchAct(); }
                    )
                    
                    //中间-------------
                    ,
                    title: new Container(
                        width: 180,
//                        color: Colors.red,
                        child: new TabBar(
                            labelColor: Constants.CurThemeColor
                            ,unselectedLabelColor: Colors.black54
                            ,indicatorSize: TabBarIndicatorSize.label
                            ,indicatorColor: Constants.CurThemeColor
                            ,tabs: new List<Widget>
                            {
                                new Tab(
                                    child: new Text(Constants.TopTitles[0], style: new TextStyle(fontSize: 18))    
                                )
                                , new Tab(
                                    child: new Text(Constants.TopTitles[1], style: new TextStyle(fontSize: 18))    
                                )

                            }
                            ,controller: _tabController
                        )   
                    )
                    ,centerTitle: true
                    
                    //右侧搜索按钮-------------

                    ,
                    actions: new List<Widget>
                    {
                        new IconButton(
                            icon: new Icon(Icons.add, color: Colors.black87),
                            onPressed: () => { SearchAct(); }
                        )
                    }

                )
                ,
                
                body: new Container(
                    color: Colors.lightBlue
                    ,child: new TabBarView(
                        children: new List<Widget>
                        {
                            TuiJianView()
                            ,GuanZhuView()
                        }
                        ,controller: _tabController
                    )
                )
            );
        }
    }
    

}