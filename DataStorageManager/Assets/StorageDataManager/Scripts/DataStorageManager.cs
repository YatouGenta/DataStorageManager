using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 受け渡し用データ預かり管理クラス
/// </summary>
public static class DataStorageManager
{
    //データ預かりキー
    //種類が増えたらここに記述する
    public enum StorageKey
    {
        Sample = 0,
        Non = 999,
    }
    //データストレージディクショナリー
    private static Dictionary<StorageKey, StorageData> storageList = new Dictionary<StorageKey, StorageData>();
    
    /// <summary>
    /// データを預ける
    /// </summary>
    public static void DataStorage(StorageKey key, StorageData data)
    {
        //キーが存在しなおかつデータがあるとき
        if (storageList.ContainsKey(key))
        {
            //データを保存、もし何かあったとしても強制で上書き
            storageList[key] = data;
        }
        else
        {
            //keyがなければ追加
            storageList.Add(key, data);
        }
    }

    /// <summary>
    /// 預けたデータを取得する
    /// </summary>
    /// <param name="key">キー</param>
    /// <param name="getIsDelete">取得した後元のものを消すか否か,デフォルトで消す</param>
    public static StorageData GetStorageData(StorageKey key, bool getIsDelete = true)
    {
        if (storageList.ContainsKey(key))
        {
            StorageData data = storageList[key];
            //削除フラグが立てば消す
            if (getIsDelete)
            {
                storageList.Remove(key);
            }

            return data;
        }
        else
        {
            //keyがそもそも存在しなければnull
            return null;
        }
    }
    
}

//実際にやりとりするデータクラス
public class StorageData
{
    //基本継承して使用
}