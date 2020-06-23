using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形狀：基底類別
/// </summary>
public class Shape : MonoBehaviour
{
    [Header("長寬高")]
    public float length;
    public float width;
    public float height;

    /// <summary>
    /// 體積
    /// protected 保護：允許子類別存取禁止外部存取
    /// </summary>
    protected float volume;

    /// <summary>
    /// 取得體積
    /// virtual 虛擬：允許子類別覆寫
    /// </summary>
    /// <returns>體積</returns>
    public virtual float GetVolume()
    {
        volume = length * width * height;
        return volume;
    }

}
