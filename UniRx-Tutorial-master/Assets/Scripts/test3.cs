using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// Subject�ɂȂ肤�����
/// </summary>
public class test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ReactivePropetry=>�ϐ���Subject�̋@�\��������
        var rp = new ReactiveProperty<int>(10);

        //����ƒl�̓ǂݎ�肪�\
        rp.Value = 20;
        var currentvalue = rp.Value;

        rp.Subscribe(x=>Debug.Log(x));

        //�l���ς��ۂ�OnNext���Ăяo�����
        rp.Value = 30;
    }


}
