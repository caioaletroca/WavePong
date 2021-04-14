using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : BaseSingleton<GameManagerController>
{
    #region Unity Events

    public void Start()
    {
        // Checks if there is a scene loaded
        if(SceneManager.sceneCount == 1)
            LoadScene(Scenes.MainMenu);
    }   

    public void StartMultiPlayer()
    {
        SceneManager.UnloadSceneAsync(Scenes.MainMenu);
        
        SceneManager.LoadScene(Scenes.MultiPlay, LoadSceneMode.Additive);
    }

    #endregion

    #region Public Methods
    
    public void LoadScene(string SceneName) {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
    }
        
    #endregion
}
