using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// Subjectになりうるもの
/// </summary>
public class test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ReactivePropetry=>変数にSubjectの機能をつけた物
        var rp = new ReactiveProperty<int>(10);

        //代入と値の読み取りが可能
        rp.Value = 20;
        var currentvalue = rp.Value;

        rp.Subscribe(x=>Debug.Log(x));

        //値が変わる際にOnNextが呼び出される
        rp.Value = 30;
    }


}
