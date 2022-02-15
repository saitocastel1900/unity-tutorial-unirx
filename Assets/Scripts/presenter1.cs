using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class presenter1 : MonoBehaviour
{
    public model1 model;
    public view1 healthview;

    private void Awake()
    {
        model.healthRP.Subscribe(value=>healthview.SetRate(model.healthMax,value));
    }
}
