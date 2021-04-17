using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    #region Private Methods

    private void PauseGame()
    {
        
    }
        
    #endregion
    
    #region Unity Events

    public void OnResumeButtonClick()
    {

    }

    public void OnExitButtonClick()
    {
        Debug.Log("Exiting match");
    }
        
    #endregion
}
