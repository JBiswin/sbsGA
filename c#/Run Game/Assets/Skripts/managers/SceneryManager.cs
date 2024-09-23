using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : SingleTon<SceneryManager>
{
    [SerializeField] Image screenImage;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator AsyncLoad(int index)
    {
        screenImage.gameObject.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        Color color = screenImage.color;

        color.a = 0f;

        while(asyncOperation.isDone == false)
        {
            color.a += Time.deltaTime;

            screenImage.color = color;

            if(asyncOperation.progress >= 0.9f)
            {
                color.a = Mathf.Lerp(color.a, 1f, Time.deltaTime);

                screenImage.color = color;

                if(color.a >= 1.0f)
                {
                    asyncOperation.allowSceneActivation = true;


                    yield break;
                }
            }

            yield return null;
        }
    }


    private void OnEnable()
    {
        SceneManager.sceneLoaded += onSceneLoaded;
    }

    public IEnumerator FadeIn()
    {
        Color color = screenImage.color;

        color.a = 1;

        screenImage.gameObject.SetActive (true);

        while(color.a >= 0.0f)
        {
            color.a -= Time.deltaTime;

            screenImage.color = color;

            yield return null;
        }

        screenImage.gameObject.SetActive(false);
    }

    

    void onSceneLoaded(Scene scene , LoadSceneMode mode)
    {
        StartCoroutine(FadeIn());
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= onSceneLoaded;
    }
    
}
