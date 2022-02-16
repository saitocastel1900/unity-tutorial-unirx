using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx; 

/// <summary>
/// ÉfÅ[É^ä«óùèä
/// </summary>
public class model3 : MonoBehaviour
{
    [SerializeField]
    private IntReactiveProperty _current = new IntReactiveProperty(0);

    public IReadOnlyReactiveProperty<int> Current => _current;

    public void UpdateCount(int value)
    {
        _current.Value = Mathf.Clamp(value,0,100);
    }
}
