using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class test2 : MonoBehaviour
{


    //�X�g���[���I���ʒm
 
     void Start()
    {
        Subject<string> _subject = new Subject<string>();


        _subject.Subscribe(text=>Debug.Log(text)
        , ()=>Debug.Log("�����I��"));


        _subject.OnNext("����ɂ���I");
        //�X�g���[���̏I���ʒm�i����ȍ~�͍w�ǒʒm�����Ȃ��j
        _subject.OnCompleted();
    }


    /*
    private void Start()
    {
        Subject<string> _subject = new Subject<string>();


        _subject
           .Select(text=>int.Parse(text))
           .OnErrorRetry((FormatException ex)=>
            {
                Debug.Log("��O�������������߁A�čw�ǂ��܂�");
        })
           
          
            .Subscribe(text => Debug.Log("�ʏ�"+text)
            ,ex=>Debug.Log("��O:"+ex));

        //�G���[��߂܂����ꍇ�͏������r���Ŏ~�܂��Ă��܂�...
        _subject.OnNext("����ɂ���I");
        _subject.OnNext("111");
    }
    */
}
