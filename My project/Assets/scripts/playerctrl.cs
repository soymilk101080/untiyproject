using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl: MonoBehaviour
{
    public CharacterController charCtrl;
    public int HP;

    //��l��
    void Start()
    {
        HP = 100;
    }

    //��s:�����ާ@
    void Update()
    {
        //��(��J����w���U)���ⱱ�.����(���e)
        if (Input.GetKey(KeyCode.W)) charCtrl.SimpleMove(Vector3.forward);
    }
}
