using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public void OnPlayAgain()
    {
        GameManager.instance.RestartLevel();
    }

    public void OnContinuePlaying()
    {
        // show ad
        // player continues to play same level from start
    }

    #region Testing purposes
    /// <summary>
    /// Test purpose only
    /// </summary>
    public void RestartLevel()
    {
        OnPlayAgain();
    }
    #endregion

}
