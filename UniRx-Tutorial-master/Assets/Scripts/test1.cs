using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx; //UniRx�̋@�\���g���ۂɕK�v

/// <summary>
/// Subject�Ƃ�
/// </summary>
public class test1 : MonoBehaviour
{
   
    void Start()
    {
        //Subject�̍쐬�i�j
        Subject<string> _subejct = new Subject<string>();

        //Subscribe�i�֐��̓o�^�j
        //�I�y���[�^�[�ɂ��t�B���^�����O�̎���
        _subejct
        .Where(msg=>msg.Length<10)
        .Where(msg=>msg== "HelloWorld!")
            .Subscribe(msg=>Debug.Log(msg));

        //OnNext (Value��n���ēo�^���ꂽ������)
        _subejct.OnNext("HelloWorld!");

    }

}
