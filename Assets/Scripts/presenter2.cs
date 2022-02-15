using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

/// <summary>
/// ˆ—‚Ì“o˜^‚ÆÀ{
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
        //ReactivePropaty‚Í’l‚ª•Ï‰»‚µ‚½Û‚Éˆ—‚ªÀ{‚³‚ê‚é
        //ŠÖ”‚Ì“o˜^
        _model.Score
            .Subscribe(x=>_text.text = x.ToString())
            .AddTo(this);

        //AddTo‚Åˆ—‚ª’â~‚³‚ê‚é
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
