# unity-tutorial-unirx-
This is the project I used to understand UniRx.   

## UniRxとは
イベント処理などで使用される(繰り返し実行されるUI系統とか)。非同期処理も対応しているが acync\awaitの方が便利なので使用されない

### Subject
Subscribeとは関数を登録する処理（購読）  
OnNextとは登録された関数を値を渡して実行する処理  


### Operator
LINQの様にフィルタリングすることができる  
一覧：https://qiita.com/toRisouP/items/3cf1c9be3c37e7609a2f  
また一連の処理をストリームと呼ぶ


## 発行されるメッセージ  
・OnNext:通常のイベントが発生した際に通知  
・OnError:例外が発生した際に通知  
・OnCompleted:ストリーム（一連の処理）が終了した際に通知  


##
参考にしたサイト
https://qiita.com/toRisouP/items/2f1643e344c741dd94f8
