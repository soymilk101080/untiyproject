using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

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

    }

    public void Move(CallbackContext callback) 
    {
        //���ⱱ�.����(���e)
        charCtrl.SimpleMove(Vector3.forward);
    }
}
