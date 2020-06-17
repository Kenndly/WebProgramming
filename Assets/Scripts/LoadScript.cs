using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour
{
   // string bundleURL = "https://yadi.sk/d/8h4F5b0GUbx4Zg"; 
         string bundleURL = "https://my-files.su/Save/h5z96i/spritesandsounds";
    int version = 0;
    [SerializeField] AudioSource source;
    [SerializeField] SpriteRenderer sRendrer;
    public void OnClickDownload()
    {
        StartCoroutine(DownLoadAndCache());
    }
    IEnumerator DownLoadAndCache()
    {
        while (!Caching.ready)
            yield return null;

        var www = WWW.LoadFromCacheOrDownload(bundleURL, version);
        yield return www;
        if(!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
            yield break;
        }
        Debug.Log("Бандл загружен!");
        var assetBundle = www.assetBundle;
        string musicName = "sound_18666.mp3";
        string spriteName = "7DBnwhE2Z3c.jpg";
        var musicRequest = assetBundle.LoadAssetAsync(musicName, typeof(AudioClip));
        yield return musicRequest;
        Debug.Log("Музыкальный файл распакован!");
        var spriteRequest = assetBundle.LoadAssetAsync(spriteName, typeof(Sprite));
        yield return spriteRequest;
        Debug.Log("Изображение распаковано!");
        source.clip = musicRequest.asset as AudioClip;
        source.Play();
        sRendrer.sprite = spriteRequest.asset as Sprite;
    }
}

