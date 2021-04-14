using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    #region Unity Events

    public void OnPlayButtonClick()
    {
        // SceneManager.LoadScene("MainScene");
        var test = Object.FindObjectOfType<GameManagerController>();
        test.OnStartMatch();
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }

    #endregion
}
