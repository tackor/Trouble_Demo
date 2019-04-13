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
using UIWidgetsGallery.gallery;

public class HomeItemView : StatefulWidget
{
    public string avatarIcon;
    public string author;
    public string textContent;
    public string timeStr;

    public string videoUrl;

    public string startCount = "收藏";
    public string shardCount = "转发";
    public string writeCount = "评论";
    public string interestedCount = "喜欢";
        
    public HomeItemView(HomeItemModel itemData)
    {
        this.avatarIcon = itemData.avatarIcon;
        this.author = itemData.author;
        this.textContent = itemData.textContent;
        this.timeStr = itemData.timeStr;
        this.videoUrl = itemData.videoUrl;
        this.startCount = itemData.startCount;
        this.shardCount = itemData.shardCount;
        this.writeCount = itemData.writeCount;
        this.interestedCount = itemData.interestedCount;
    }
        
    public override State createState()
    {
        return new CommonPageState();
    }
}

public class CommonPageState : State<HomeItemView>
{
    private float itemHeadHeight = 200;
    
    
    public override Widget build(BuildContext context)
    {
        return new Container(
            color: Colors.lightBlue
            ,child: new Column(
                children: new List<Widget>
                {
                    new Container(
                        child: new Row(
                            children: new List<Widget>
                            {
                                new Container(
                                    padding: EdgeInsets.fromLTRB(10, 20, 10, 0),
                                    color: Colors.red,
                                    width: 120,
                                    height: itemHeadHeight
                                )
                                ,new Expanded(
                                    child: new Container(
                                        color: Colors.yellow,
                                        height: itemHeadHeight,
                                        padding: EdgeInsets.fromLTRB(10, 20, 20, 10),
                                        child: new Stack(
                                            fit: StackFit.expand,
                                            children: new List<Widget>
                                            {
                                                Image.asset("Images/page", fit: BoxFit.fill),
                                                new Padding(
                                                    padding: EdgeInsets.fromLTRB(10, 20, 20, 10),
                                                    child: new Column(
                                                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                                                        children: new List<Widget>
                                                        {
                                                            new Container(
                                                                color: Colors.orange,
                                                                child: new Row(
                                                                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                                                    children: new List<Widget>
                                                                    {
                                                                        new Text(widget.author)
                                                                        ,new Text(widget.timeStr)
                                                                    }    
                                                                )
                                                            )
                                                            ,new Container(
                                                                color: Colors.pink
                                                                ,child: new Text(widget.textContent)
                                                            )
                                                            ,new Align(
                                                                alignment: Alignment.centerLeft,
                                                                child: new Text ("#原创   #鬼畜")    
                                                            )
                                                        }
                                                    )    
                                                )
                                            }
                                        )
                                    )    
                                )
                            }
                        )
                    )
                    ,new Container(
                        color: Colors.cyan
                        ,width: MediaQuery.of(context).size.width
                        ,height: 300
                        ,child: new Text(widget.videoUrl)
                    )
                    ,new Divider()
                    ,new Container(
                        color: Colors.yellow,
                        margin: EdgeInsets.only(top: 0, bottom: 10),
                        child: new Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: new List<Widget>
                            {
                                new RaisedButton(
                                    child: new Row(
                                        children: new List<Widget>
                                        {
                                            new Icon(Icons.keyboard_arrow_down)
                                            ,new Text(widget.startCount)
                                        }    
                                    )
                                )
                                ,
                                new RaisedButton(
                                    child: new Row(
                                        children: new List<Widget>
                                        {
                                            new Icon(Icons.search)
                                            ,new Text(widget.shardCount)
                                        }    
                                    )
                                )
                                ,
                                new RaisedButton(
                                    child: new Row(
                                        children: new List<Widget>
                                        {
                                            new Icon(Icons.account_circle)
                                            ,new Text(widget.writeCount)
                                        }    
                                    )
                                )
                                ,
                                new RaisedButton(
                                    child: new Row(
                                        children: new List<Widget>
                                        {
                                            new Icon(Icons.notifications)
                                            ,new Text(widget.interestedCount)
                                        }    
                                    )
                                )
                                
                            }    
                        )
                    )
                }
            )
        );
    }
}
