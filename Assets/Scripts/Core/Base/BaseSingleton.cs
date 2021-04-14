using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSingleton<T> : MonoBehaviour where T : BaseSingleton<T>
{
    #region Public Properties

    public static T Instance
    {
        get
        {
            if(_Instance != null)
                return _Instance;

            return null;
        }
    }
        
    #endregion

    #region Private Properties

    private static T _Instance;

    #endregion

    #region Unity Methods

    public virtual void Awake()
    {
        if (_Instance == null || !_Instance || !_Instance.gameObject)
        {
            _Instance = (T)this;
        }
        else if (_Instance != this)
        {
            Debug.LogError($"Another instance of {GetType()} already exists.");
            Destroy(this);
            return;
        }
    }
        
    #endregion
}