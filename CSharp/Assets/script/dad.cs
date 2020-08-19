using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class9
{
    public class dad : MonoBehaviour
    {
        public Boy boy;

        private void Start()
        {
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 10;
            print("給你10塊");
        }

        private void HitBoy()
        {
            print("打你的小手手");
        }
    }
}
