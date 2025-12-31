using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyCountCtrl : MonoBehaviour
{
    public Image[] keys;
    public Color got;
    public Color none;

    // Start is called before the first frame update
    void Start()
    {
        UpdateKeyUI();
    }

    public void UpdateKeyUI() 
    {
    //起始；終點:增值
    for (int i = 0;i < GameData.hpMax; i++)
    {
        if(i< GameData.keyCount) keys[i].color = got;
        else keys[i].color = none;
    }
    }

}
