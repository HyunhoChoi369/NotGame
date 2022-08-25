using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayfabLogin : MonoBehaviour
{
    private void Start()
    {

    }

    public void Login()
    {
        var request = new LoginWithCustomIDRequest()
        {
            TitleId = PlayFabSettings.TitleId,
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    private void OnSuccess(LoginResult result)
    {
        Debug.Log("Login Success");
        SceneManager.LoadSceneAsync("Loading");
    }

    private void OnError(PlayFabError error)
    {
        Debug.LogError("Login Error");
    }
}
