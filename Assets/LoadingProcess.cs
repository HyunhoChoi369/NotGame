using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingProcess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var task = SceneManager.LoadSceneAsync("Game", LoadSceneMode.Additive);
        task.completed += OnSceneLoadComplete;
    }


    private void OnSceneLoadComplete(AsyncOperation operation)
    {
        SceneManager.UnloadSceneAsync("Loading");
    }
}
