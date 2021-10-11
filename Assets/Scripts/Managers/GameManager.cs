using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameObject player;
    public GameObject spawner;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    


    public void StartGame()
    {
        //SceneManager.LoadSceneAsync(1);
        player.SetActive(true);
        spawner.SetActive(true);
        LevelManager.instance.LoadLevel(0);
        UIManager.instance.ShowPanel(false, false, true);
    }

    public void OnGameOver()
    {
        Destroy(GameObject.FindGameObjectWithTag("moon"));
        player.SetActive(false);
        spawner.SetActive(false);
        // show panel pause the game
        Debug.LogError("GAME OVER");
        UIManager.instance.GameOverUI.SetActive(true);
    }

    public void ContinueLevel()
    {
        // show video ad
        // after closing player will play same level he was in
    }

    public void RestartLevel()
    {
        StartGame();
    }
}
