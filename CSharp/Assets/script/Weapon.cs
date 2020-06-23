using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeNameSpace
{
    public class Weapon : MonoBehaviour,ICanUse
    {
        public Data data;

        public void Use()
        {
            print("裝備武器：" + data.name);

            transform.SetParent(FindObjectOfType<Player>().hand);       //設定父物件(玩家.手)
            transform.localEulerAngles = new Vector3(0, 0, 45);         //旋轉角度
            transform.localPosition = Vector3.zero;                     //區域座標 = 零
            GetComponent<Collider>().enabled = false;                   //關閉碰撞
        }
    }
}