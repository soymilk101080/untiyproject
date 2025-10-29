using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerCtrl: MonoBehaviour
{
    #region �򥻰Ѽ�
    public CharacterController charCtrl;
    /// <summary>
    /// �����q
    /// </summary>
    public int HP;
    /// <summary>
    /// �n��~����J
    /// </summary>
    Vector2 input;
    Vector3 look;
    #endregion �򥻰Ѽ�

    #region ���⤽�}���A
    /// <summary>
    /// ����O�_��������J�ާ@
    /// </summary>
    public bool isMove => input != Vector2.zero;
    #endregion ���⤽�}���A

    #region UNITY�ͩR�g��
    /// <summary>
    /// ��l��
    /// </summary>
    void Start()
    {
        HP = 100;
    }

    /// <summary>
    /// ��s:�����ާ@
    /// </summary>
    void Update()
    {
        Action();
    }
    #endregion UNITY�ͩR�g��

    #region �ާ@�]�p
    /// <summary>
    /// ������
    /// </summary>
    void Action() 
    {
        //��ʨ���
        look.z = input.y;
        look.x = input.x;
        transform.rotation = Quaternion.LookRotation(look);
        //���ⱱ�.����(���e)
        if  (isMove) charCtrl.SimpleMove(transform.forward);
    }

    public void Move(CallbackContext callback) 
    {
        input = callback.ReadValue<Vector2>();
    }
    #endregion �ާ@�]�p
}
