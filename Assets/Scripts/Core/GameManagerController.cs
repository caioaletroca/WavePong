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
        // Checks if there is a scene loaded
        if(SceneManager.sceneCount == 1)
            LoadScene(Scenes.MainMenu);
    }   

    public void OnStartMatch()
    {
        SceneManager.UnloadSceneAsync("MainMenuScene");
        
        SceneManager.LoadScene("MainScene", LoadSceneMode.Additive);
    }

    #endregion

    #region Public Methods
    
    public void LoadScene(string SceneName) {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
    }
        
    #endregion
}
