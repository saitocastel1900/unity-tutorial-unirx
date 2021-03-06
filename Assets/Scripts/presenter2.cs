using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

/// <summary>
/// 処理の登録と実施
/// </summary>
public class presenter2 : MonoBehaviour
{
    [SerializeField] private model2 _model; 

    [SerializeField]private Text _text;
    [SerializeField] private Button _upButton;
    [SerializeField] private Button _downButton;

    // Start is called before the first frame update
    void Start()
    {
        //ReactivePropatyは値が変化した際に処理が実施される
        //関数の登録
        _model.Score
            .Subscribe(x=>_text.text = x.ToString())
            .AddTo(this);

        //AddToで処理が停止される
        _upButton
            .OnClickAsObservable()
            
            .Subscribe(_ => _model.Score.Value++)
            .AddTo(this);


        _downButton
          .OnClickAsObservable()
        .Subscribe(_ => _model.Score.Value--)
          .AddTo(this);
    }

   
}
