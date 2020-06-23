using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class5_ifSwitchLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;

    [Header("分數")]
    public int score = 0;

    [Header("血量"), Range(0, 100)]
    public int hp = 100;

    [Header("道具")]
    public string prop = "生命之水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    private int i = 1;
    private int j = 1;

    //GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

    private void CreateFloor(int length, int width)
    {
        //巢狀迴圈
        //注意初始值名稱不能相同
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API 實例化 (生成)
                //生成(物件，座標，角度)
                //Vector3 三維向量(保存三個浮點數)
                //Quaternion 角度
                //Quaternion.identity 零角度
                //Quaternion.Euler(x, y, z) 歐拉角度 - 0~360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {
        #region 認識迴圈
        //使用 for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取得資料：" + scores[i]);
        }

        //foreach 迴圈
        //語法：foreach (取得資料的類型 取得資料的名稱 in 陣列) { 執行次數為陣列數量 }
        foreach (int item in scores)
        {
            print("foreach 迴圈取得資料：" + item);
        }

        CreateFloor(30,5);

        //while 迴圈
        //while (布林值) { 當布林值為 true 執行 }
        //迴圈之前評估：第一次判斷 i = 1
        while (i <= 10)
        {
            print("while 迴圈第：" + i + " 次");
            i++;
        }

        //迴圈之後評估：第一次判斷 j = 2
        do
        {
            print("do 迴圈第：" + j + " 次");
            j++;
        } while (j <= 10);

        //for (初始值 ; 條件 ; 跌代器)
        for (int k = 1; k <= 10; k++)
        {
            print("for 迴圈第：" + k + " 次");
        }

        for (int k = 10; k > 0; k--)
        {
            print("for 迴圈第：" + k + " 次");
        }
        #endregion

        /*for (int i = 0; i < 101; i++)
        {
            print("break 迴圈：" + i);

            //如果 i 等於 10 就打斷迴圈並執行迴圈下方的程式
            if (i == 10) break;
        }

        print("迴圈外的程式");*/

        /*for (int i = 0; i < 101; i++)
        {
            print("return 迴圈：" + i);

            //如果 i 等於 10 就跳出方法外，下方的程式皆不執行
            if (i == 10) return;
        }

        print("迴圈外的程式");*/

        /*//執行結果：0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue 迴圈：" + i);
        }

        print("continue 迴圈外的程式");*/

        for (int i = 0; i < 10; i++)
        {
            //goto 標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈：" + i);
        }

    Test:
        print("我豬豬啦~");
    }

    private void Start()
    {
        //if 判斷式
        //if (布林值) { 布林值 = true 時執行}
        if (true)
        {
            print("Hello, I'm HeroBoar.");
        }

    }

    //更新事件：一秒直行約 60 次 (60FPS)
    private void Update()
    {
        //當 openDoor 為 true 執行 {開門}
        //當 openDoor 為 false 執行 {關門}
        //if (openDoor == true)
        if (openDoor)
        {
            print("齁齁~");
        }
        else
        {
            print("齁~");
        }

        //比較運算子、邏輯運算子結果為布林值
        //大於等於 60 及格
        //小於 60 被當
        //一組判斷式只會有一個執行結果
        if (score >= 60)
        {
            print("汪汪~");
        }
        else if (score >= 40)
        {
            print("嗷嗚~");
        }
        else
        {
            print("汪!");
        }

        if (hp >= 70)
        {
            print("safe");
        }
        else if (hp >= 20)
        {
            print("warnning");
        }
        else
        {
            print("danger");
        }

        switch (prop)
        {
            case "生命之水":
                print("補 HP");
                break;
            case "藍水":
                print("補 MP");
                break;
            case "黃水":
                print("補 EXP");
                break;
            //default 可省略
            default:
                print("無法使用");
                break;
        }
        switch (season)
        {
            case Season.Spring:
                break;
            case Season.Summer:
                break;
            case Season.Fall:
                break;
            case Season.Winter:
                break;
        }

        //當道具數量 >= 5 任務完成 true
        //三元運算子語法 - 布林運算式 ? 運算式 A : 運算式 B
        //指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        /*if (count >= 5)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }*/
    }
}
