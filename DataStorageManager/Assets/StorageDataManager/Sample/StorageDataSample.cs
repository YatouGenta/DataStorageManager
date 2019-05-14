using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ストレージデータサンプル
/// </summary>
public class StorageDataSample : MonoBehaviour
{
    //結果表示用のText
    [SerializeField]
    private Text text = null;

    /// <summary>
    /// 保存
    /// </summary>
    public void OnClickStorage()
    {
        SampleStorageData data = new SampleStorageData();
        data.message = "ストレージデータ送信！";
        DataStorageManager.DataStorage(DataStorageManager.StorageKey.Sample, data);
        text.text = "データを保存しました";
    }

    /// <summary>
    /// 取得
    /// </summary>
    public void OnClickGetStorage()
    {
        SampleStorageData data = (SampleStorageData)DataStorageManager.GetStorageData(DataStorageManager.StorageKey.Sample);
        if(data != null)
        {
            text.text = "データを取得メッセージは\n" + data.message;
        }
        else
        {
            text.text = "データを取得失敗";
        }
    }

}

public class SampleStorageData : StorageData
{
    public string message;
}