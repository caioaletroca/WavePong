using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    #region Unity Events

    public void OnPlayButtonClick()
    {
        GameManagerController.Instance.StartMultiPlayer();
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }

    #endregion
}
