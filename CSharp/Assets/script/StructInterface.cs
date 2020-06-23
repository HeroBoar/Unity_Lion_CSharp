using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructInterface : MonoBehaviour
{
    //Unity 定義的結構
    public Vector3 pos;

    //使用結構
    public Direction myDire1;

    //new 新增物件，並且可以使用建構子
    public Direction myDire2 = new Direction(4);

    private void Start()
    {
        //使用結構成員
        //三維向量結構 方法成員
        pos.Set(1, 2, 3);
        //三維向量結構 結構成員
        print("座標：" + pos.x);

        //指定結構成員
        myDire1.direction = 1;

        //常數與靜態取得用法是一樣的
        print("方向右邊的值：" + Direction.right);

        //錯誤：不能變更常數
        //Direction.left = 5;

        myDire1.Set("左");
        print("方向：" + myDire1.direction);

        //透過 new 新增的方向資訊
        print("第二筆方向資訊：" + myDire2.direction);
    }

    //類別一定要使用 new 新增物件
    //結構可用可不用
    public Class_Data c_data1 = new Class_Data();
    public Struct_Data s_data;

    //類別：參考型別 - 傳址
    public Class_Data c2 = new Class_Data("豬豬", 99999, 10000);
    public Class_Data c3 = new Class_Data("雞雞兔兔", 9999, 500);

    //結構：參考型別 - 傳值
    public Struct_Data s2 = new Struct_Data("豬豬", 99999, 10000);
    public Struct_Data s3 = new Struct_Data("雞雞兔兔", 9999, 500);

    private void Awake()
    {
        c_data1.name = "皮皮";
        print(c_data1.name);

        s_data.name = "汪醬汪柴";
        print(s_data.name);

        c2 = c3;                //c2 = c3 兩筆資料 地址 相同
        c2.name = "雞雞兔兔";    //修改 c2 等同於修改 c3

        s2 = s3;                //c2 = c3 兩筆資料 數值 相同
        s2.name = "雞雞兔兔";    //修改 c2 不會修改到 c3
    }
}
