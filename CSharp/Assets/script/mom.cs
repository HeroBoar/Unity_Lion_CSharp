using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class9
{
    public class mom : MonoBehaviour
    {
        //訂閱者：訂閱事件
        public Boy boy;

        private void Start()
        {
            //1. 訂閱事件
            boy.onNoMoney += GiveMoney;
        }

        //2. 實作方法
        private void GiveMoney()
        {
            print("這麼快就花完拉!!");
            boy.money += 1000;
        }
    }
}
