using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeItemModel
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

    public HomeItemModel(
        string icon,
        string author,
        string content,
        string time,
        string video,
        string start,
        string shared,
        string write,
        string interested
    )
    {
        this.avatarIcon = icon;
        this.author = author;
        this.textContent = content;
        this.timeStr = time;
        this.videoUrl = video;
        this.startCount = start;
        this.shardCount = shared;
        this.writeCount = write;
        this.interestedCount = interested;
    }

}
