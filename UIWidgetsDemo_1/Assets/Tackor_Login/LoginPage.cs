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


public class LoginPage : UIWidgetsSamplePanel
{
    protected override Widget createWidget() {
        return new WidgetsApp(
            home: new LoginApp(),
            pageRouteBuilder: this.pageRouteBuilder);
    }
    
    
    protected override void Awake() {
        base.Awake();
        FontManager.instance.addFont(Resources.Load<Font>("GalleryIcons"), "GalleryIcons");
    }
    
    public class LoginApp : StatefulWidget {
        
        public LoginApp(Key key = null) : base(key) {
        }

        public override State createState() {
            return new _LoginAppState();
        }
    }

    public class _LoginAppState : State<LoginApp>
    {
        private Color themeColor = Colors.red;

        //获取验证码
        void GetVerifyCodeAct()
        {
            print("GGL_  获取验证码 ---> ");
        }

        //登录
        void LoginAct()
        {
            print("GGL_  登录 ---> ");
        }

        //第三方登录
        void OtherLoginAct(int index)
        {
            print("GGL_  第三方登录 ---> " + index);
        }
        
        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                
                //AppBar ----------------------------
                appBar: new AppBar(
                    backgroundColor: themeColor,
                    brightness: Brightness.light,
                    elevation:0,
                    
                    title: new Text("登录", style: new TextStyle(color: Colors.white, fontSize: 24)),
                    centerTitle: true
                    
                ),
                
                //body ----------------------------
                body: new Container(
                    color: Colors.black12,
                    child: new Center(
                        child: new Column(
                            children: new List<Widget>
                            {
                                new Expanded(
                                    flex: 1,
                                    child: new Container(
//                                        color: Colors.lightBlue
                                    )
                                ),
                                //手机号 -----------------
                                new Container(
//                                    color: Colors.amber,
                                    width: MediaQuery.of(context).size.width - 100,
                                    child: new Row(
                                        mainAxisAlignment: MainAxisAlignment.center,
                                        children: new List<Widget>{
                                            new Padding(
                                                padding: EdgeInsets.only(right: 8),
                                                child: new Icon(GalleryIcons.phone_iphone, size: 40)
                                            ),
                                            new Expanded(
                                                child: new TextField(
                                                    autofocus: true,
                                                    keyboardType: TextInputType.phone,
                                                    cursorColor: Colors.black54,
                                                    style: new TextStyle(
                                                        fontSize: 20    
                                                    ),
                                                    decoration: new InputDecoration(
                                                        hintText: "  请输入手机号  ",
                                                        hintStyle: new TextStyle(
                                                            fontSize: 20    
                                                        ),
                                                        focusedBorder: new UnderlineInputBorder (
                                                            borderSide: new BorderSide(
                                                                color: Colors.black54    
                                                            )    
                                                        )
                                                    )
                                                )       
                                            )
                                        }
                                    )
                                ),
                                //验证码 -----------------
                                new Container(
//                                    color: Colors.green,
                                    margin: EdgeInsets.only(top: 30),
                                    width: MediaQuery.of(context).size.width - 100,
                                    child: new Row(
                                        mainAxisAlignment: MainAxisAlignment.center,
                                        children: new List<Widget>{
                                            new Expanded(
                                                child: new TextField(
                                                    autofocus: true,
                                                    keyboardType: TextInputType.phone,
                                                    cursorColor: Colors.black54,
                                                    style: new TextStyle(
                                                        fontSize: 20
                                                    ),
                                                    decoration: new InputDecoration(
                                                        hintText: "  请输入手机号  ",
                                                        hintStyle: new TextStyle(
                                                            fontSize: 20    
                                                        ),
                                                        focusedBorder: new UnderlineInputBorder(
                                                            borderSide: new BorderSide(
                                                                color: Colors.black54 
                                                            )    
                                                        )
                                                    )
                                                )    
                                            ),
                                            new RaisedButton(
                                                child: new Text("获取验证码"),
                                                textColor: Colors.white70,
                                                elevation: 0,
                                                highlightElevation: 0,
                                                splashColor: Colors.transparent,
                                                color: themeColor,
                                                shape: new StadiumBorder(
                                                    side: new BorderSide(
                                                        color: Colors.black54,
                                                        width: 2
                                                    )
                                                ),
                                                onPressed: () => { GetVerifyCodeAct(); }
                                            )
                                        }
                                    )
                                ),
                                
                                // 登录按钮 ---------------
                                new Container(
//                                    color: Colors.lightBlue,
                                    width: MediaQuery.of(context).size.width - 100,
                                    height: 60,
                                    margin: EdgeInsets.only(top: 80),
                                    child: new RaisedButton(
                                        child: new Text("登录", style: new TextStyle(fontSize: 28)),
                                        textColor: Colors.white,
                                        elevation: 0,
                                        highlightElevation: 0,
                                        splashColor: Colors.transparent,
                                        color: themeColor,
                                        shape: new StadiumBorder (
                                            side: new BorderSide(
                                                color: Colors.black54,
                                                width: 2
                                            )
                                        ),
                                        onPressed: () => { LoginAct();}
                                    )
                                ),
                                
                                new Expanded(
                                    flex: 3,
                                    child: new Container(
                                        padding: EdgeInsets.only(bottom: 30),
//                                        color: Colors.yellow,
                                        child: new Column(
                                            mainAxisAlignment: MainAxisAlignment.end,
                                            children: new List<Widget>
                                            {
                                                //分割线 ---------------
                                                new Container(
                                                    padding: EdgeInsets.only(top: 120),
                                                    width: MediaQuery.of(context).size.width - 60,
                                                    child: new Row(
                                                        children: new List<Widget>
                                                        {
                                                            new Expanded(
                                                                child: new Container(
                                                                    color: Colors.black38,
                                                                    height: 2
                                                                )
                                                            ),
                                                            new Text("  其他方式登录  ", style: new TextStyle(color: Colors.black38)),
                                                            new Expanded(
                                                                child: new Container(
                                                                    color: Colors.black38,
                                                                    height: 2
                                                                ) 
                                                            )
                                                        }    
                                                    )
                                                ),
                                                
                                                //第三方登录 ---------------------
                                                new Container(
                                                    margin: EdgeInsets.only(top: 30),
                                                    width: MediaQuery.of(context).size.width - 100,
                                                    child: new Row(
                                                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                                        children: new List<Widget>
                                                        {
                                                            new IconButton (
                                                                iconSize: 48,
                                                                splashColor: Colors.transparent,
                                                                icon: Image.asset("images/wechat"),
                                                                onPressed: () => { OtherLoginAct(0); }
                                                            ),
                                                            new IconButton (
                                                                iconSize: 48,
                                                                splashColor: Colors.transparent,
                                                                icon: Image.asset("images/qq"),
                                                                onPressed: () => { OtherLoginAct(1); }
                                                            ),
                                                            new IconButton (
                                                                iconSize: 48,
                                                                splashColor: Colors.transparent,
                                                                icon: Image.asset("images/weibo"),
                                                                onPressed: () => { OtherLoginAct(2); }
                                                            ),
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
                )
            );
        }
    }
    
}