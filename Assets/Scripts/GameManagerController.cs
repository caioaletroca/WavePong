using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    #region Unity Events

    public void Awake() {

    }

    public void Start()
    {
        // SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Additive);
    }   

    public void OnStartMatch()
    {
        SceneManager.UnloadSceneAsync("MainMenuScene");
        
        SceneManager.LoadScene("MainScene", LoadSceneMode.Additive);
    }

    #endregion
}
