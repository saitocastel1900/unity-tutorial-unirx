using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

/// <summary>
/// �����̓o�^�Ǝ��{
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
        //ReactivePropaty�͒l���ω������ۂɏ��������{�����
        //�֐��̓o�^
        _model.Score
            .Subscribe(x=>_text.text = x.ToString())
            .AddTo(this);

        //AddTo�ŏ�������~�����
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
