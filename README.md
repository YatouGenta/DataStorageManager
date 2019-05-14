# DataStorageManager
データ預け管理クラス

<h2>概要</h2>

クラス外などでやりとりしたいデータを預かる管理クラス

<h2>開発環境</h2>

Unity2019.1

<h2>使い方</h2>

この機能はStorageDataを継承したクラスとStorageKeyのenumをセットにしDictionaryで管理をしています  
DataStorageManagerはstaticなクラスなのでどの場面でも呼び出すことが可能です

・データの保存  
DataStorageManager.DataStorage(StorageKey キー, StorageData 預けたいデータ)

・データの取得
DataStorageManager.GetStorageData(StorageKey キー, bool 取得した後元のデータを消すかどうか)


<h2>備考</h2>


