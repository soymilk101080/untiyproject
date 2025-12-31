using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    /// <summary>
    /// 當前血量
    /// </summary>
    public static int hp = 30;
    /// <summary>
    /// 
    /// </summary>
    public static int hpMax = 100;
    /// <summary>
    /// 血量百分比(UI用)
    /// </summary>
    public static float hpFillAmount
    {
        get
        {
            return (float)hp / (float)hpMax;
        }
    }
    /// <summary>
    /// 當前取得的鑰匙數量
    /// </summary>
    public static int keyCount = 0;
    /// <summary>
    /// 需要的鑰匙總數
    /// </summary>
    public static int keyMax = 3;

    public static Action updateKey;
    public static void AddKEY()
    {
        keyCount += 1;
    }
}