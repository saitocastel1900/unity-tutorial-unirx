using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class model1 : MonoBehaviour
{
    public  int healthMax = 100;
    public  IntReactiveProperty healthRP = new IntReactiveProperty();
    public int Health
    {
        get { return healthRP.Value; }
        set { healthRP.Value = value; }
    }
   
}
