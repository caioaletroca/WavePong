using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiPlayerUIController : MonoBehaviour
{
    #region Public Properties

    public PlayerModelScriptableObject Player1Model;

    public TextMeshProUGUI Player1Score;

    #endregion

    #region Unity Methods

    private void Update()
    {
        Player1Score.text = Player1Model.Score.ToString();
    }
        
    #endregion
}
