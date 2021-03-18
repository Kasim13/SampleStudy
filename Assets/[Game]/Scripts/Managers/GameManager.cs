using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int LevelCoinMultiplier = 2;

    private void OnEnable()
    {
        EventManager.OnGameOver.AddListener(GameOver);
    }

    private void OnDisable()
    {
        EventManager.OnGameOver.RemoveListener(GameOver);
    }

    public void GameOver()
    {
        StartCoroutine(LoadNextSceneCo());
    }

    private IEnumerator LoadNextSceneCo()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        int scenesCount = SceneManager.sceneCount;

        List<Scene> scenesToBeUnloaded = new List<Scene>();

        for(int i = 0; i <= scenesCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name.Contains("Level"))
            {
                scenesToBeUnloaded.Add(scene);
            }
        }

        foreach(var sc in scenesToBeUnloaded)
        {
            yield return SceneManager.UnloadSceneAsync(sc);
        }
        
        if (!Application.CanStreamedLevelBeLoaded(buildIndex))
        {
            buildIndex = 1;
        }

        yield return SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
        Debug.Log("Next Level");
    }
}
