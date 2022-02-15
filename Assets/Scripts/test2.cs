using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class test2 : MonoBehaviour
{


    //ストリーム終了通知
 
     void Start()
    {
        Subject<string> _subject = new Subject<string>();


        _subject.Subscribe(text=>Debug.Log(text)
        , ()=>Debug.Log("処理終了"));


        _subject.OnNext("こんにちわ！");
        //ストリームの終了通知（これ以降は購読通知をしない）
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
                Debug.Log("例外が発生したため、再購読します");
        })
           
          
            .Subscribe(text => Debug.Log("通常"+text)
            ,ex=>Debug.Log("例外:"+ex));

        //エラーを捕まえた場合は処理が途中で止まってしまう...
        _subject.OnNext("こんにちわ！");
        _subject.OnNext("111");
    }
    */
}
