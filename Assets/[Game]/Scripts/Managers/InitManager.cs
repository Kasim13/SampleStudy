using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        Scene scene = SceneManager.GetSceneByName("Level01");
        yield return SceneManager.LoadSceneAsync(scene.buildIndex, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(scene);
        Destroy(gameObject);
    }
}
