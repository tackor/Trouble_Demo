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

namespace Tackor.App
{
    public class CommonPage : StatefulWidget
    {
        public Color _bgColor;
        public string _title;
        
        public CommonPage(string title, Color bgColor)
        {
            this._title = title;
            this._bgColor = bgColor;
        }
        
        public override State createState()
        {
            throw new NotImplementedException();
        }
    }

    public class CommonPageState : State<CommonPage>
    {
        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                appBar: new AppBar (
                    backgroundColor: widget._bgColor,
                    brightness: Brightness.light,
                    elevation: 0,
                    
                    title: new Text(widget._title, style: new TextStyle(color: Colors.white, fontSize: 24))
                )
                ,
                
                body: new Container(
                    color: widget._bgColor    
                )
            );
        }
    }
    
}
