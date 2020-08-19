using System.Collections;
using System.Collections.Generic;       //List<T>、Dictionary<TK,TV>、Queue<T>、Stack<T>
using UnityEngine;
using System.Linq;                      //系統 LinQ

namespace Class10
{
    public class Class10_LinQ : MonoBehaviour
    {
        public int[] numbers = { 7, 24, 31, 90, 5, 91, 6, 46 };

        public List<float> atk = new List<float>() { 505f, 30.1f, 99.9f, 3.7f, 10f, 26.4f };

        private void Start()
        {
            //LinQ 查詢語法

            //區域變數
            var even =
                from data in numbers        //在陣列 numbers 取得資料 存在 data
                where (data % 2) == 0       //條件 資料 與 2 餘數 為 0
                select data;                //選取 符合條件的 資料

            foreach (var item in even) print("所有偶數：" + item);

            var odd =
                from data in numbers
                where (data % 2) == 1
                orderby data ascending      //排序 資料 由小到大 ascending - 由大到小 descending
                select data;

            foreach (var item in odd) print("所以奇數：" + item);

            //LinQ 方法語法
            print("總和：" + atk.Sum());
            print("平均：" + atk.Average());
            print("最小：" + atk.Min());
            print("最大：" + atk.Max());

            var a20 = atk.Where((x) => x <= 20);

            foreach (var item in a20) print("小於20的資料：" + item);
        }
    }
}
