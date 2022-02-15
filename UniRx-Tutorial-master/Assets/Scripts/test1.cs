using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx; //UniRxの機能を使う際に必要

/// <summary>
/// Subjectとは
/// </summary>
public class test1 : MonoBehaviour
{
   
    void Start()
    {
        //Subjectの作成（）
        Subject<string> _subejct = new Subject<string>();

        //Subscribe（関数の登録）
        //オペレーターによるフィルタリングの実装
        _subejct
        .Where(msg=>msg.Length<10)
        .Where(msg=>msg== "HelloWorld!")
            .Subscribe(msg=>Debug.Log(msg));

        //OnNext (Valueを渡して登録された処理実)
        _subejct.OnNext("HelloWorld!");

    }

}
