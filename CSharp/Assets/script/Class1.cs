﻿using UnityEngine;    //引用 Unity API (函式庫：Unity 屬性、功能...)

//類別 class 定義一個物件
//語法：class 類別名稱
//：MonoBehaviour 可以將此腳本掛在Unity物件上
//類別必須掛在物件上才會執行
public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小不一樣
    //2.括號成對出現 () [] {} '' "" < >

    [Header("Car1")]
    public Car car1;
    [Header("Car2")]
    public Car car2;

    //事件：在特定時間會以指定次數執行的方法(名稱為藍色的)
    //開始事件：播放遊戲時執行一次-初始設定
    private void Start()
    {
        //輸出("文字訊息");
        //C# 結尾為分號;
        print("Hello World~0.<");

        //取得 get
        print("Car1的cc數"+car1.cc);
        print("Car2的重量"+car2.weight);

        //設定 set
        car1.brake = true;
        car1.brand = "汪";
        car1.cc = 2222;
        car1.weight = 77.7f;
    }
}
