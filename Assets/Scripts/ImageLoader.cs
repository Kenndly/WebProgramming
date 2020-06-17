using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLoader : MonoBehaviour
{
    public string url = "https://i.pinimg.com/originals/9e/1d/d6/9e1dd6458c89b03c506b384f537423d9.jpg";
    public string url1 = "https://pbs.twimg.com/profile_images/1018168850460733440/P1sBOSD__400x400.jpg";
    public Renderer thisRenderer;

    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine()); 

        thisRenderer.material.color = Color.red;
    }

    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("Загрузка ...");
        WWW wwwLoader = new WWW(url1);
        yield return wwwLoader;

        Debug.Log("Загружен");
        thisRenderer.material.color = Color.white;
        thisRenderer.material.mainTexture = wwwLoader.texture;
    }
}