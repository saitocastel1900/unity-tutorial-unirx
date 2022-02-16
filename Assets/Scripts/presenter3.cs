using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

/// <summary>
/// 仲介役
/// </summary>
public class presenter3 : MonoBehaviour
{
    //modelへの参照
    [SerializeField] private model3 _countmodel;

    //Viewのコンポーネント
    [SerializeField] private InputField _inputfield;
    [SerializeField] private Button _upButton;
    [SerializeField] private Button _downButton;
    [SerializeField] private Slider _slider;


    // Start is called before the first frame update
    void Start()
    {

        _countmodel.Current
            .Subscribe(x => {

                _inputfield.text = x.ToString();
        })
            .AddTo(this);


        _inputfield
            .OnValueChangedAsObservable()
            .Select(x =>
            {
                var isSucceed = int.TryParse(x, out var value);
                return (isSucceed, value);
            })
            .Where(x => x.isSucceed)
            .Subscribe(x => _countmodel.UpdateCount(x.value))
            .AddTo(this);


        _slider
            .OnValueChangedAsObservable()
            .Subscribe(x => _countmodel.UpdateCount((int)x))
            .AddTo(this);


        Observable.Merge
            (
            _upButton.OnClickAsObservable().Select(_ => +1),
            _downButton.OnClickAsObservable().Select(_ => -1)
            )
            .Subscribe(value =>
            {
                _countmodel.UpdateCount(_countmodel.Current.Value + value);
            })
            .AddTo(this);
    }

}
