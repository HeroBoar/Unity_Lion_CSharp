using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class house : MonoBehaviour
{
    [Header("血量"), Range(100, 10000)]
    public float hp;
    [Header("血條")]
    public Image hpBar;

    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }

    /// <summary>
    /// 接收傷害
    /// </summary>
    /// <param name="damage">傷害值</param>
    public void Damage(float damage)
    {
        hp -= damage;                       //血量 遞減 傷害值
        hpBar.fillAmount = hp / hpMax;      //更新 血條
    }
}
