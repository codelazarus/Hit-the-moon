using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameObject GameOverUI;

    // Use this for initialization
    private void Awake()
    {
        if (instance == null)
            instance = this;
       
    }

    // Update is called once per frame
    void Update () {
		
	}


    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OnGameOver()
    {
        // show panel pause the game
        Debug.LogError("GAME OVER");
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ContinueLevel()
    {
        // show video ad
        // after closing player will play same level he was in
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(1);
    }
}
