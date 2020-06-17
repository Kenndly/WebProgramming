using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public string url;
    void Start()
    {
        StartCoroutine(DownLoadModel());
    }
    private IEnumerator DownLoadModel()
    {       
        WWW www = new WWW(url);
        yield return www;   
        AssetBundle assetBundle = www.assetBundle;
       // GameObject g = Instantiate(assetBundle.LoadAllAssets("")) as GameObject;
    }
}
    