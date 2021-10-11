using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;


    public int currentLevel = 0;

    public GameObject player;
    public GameObject spawner;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void OnLevelPassed()
    {
        //TODO: notify UI manager to reload UI
        currentLevel++;

        Destroy(GameObject.FindGameObjectWithTag("moon"));
        SpawnerController.instance.Reload();

        StartGame();
    }

    public void StartGame()
    {
        SpawnerController.instance.Reload();
        LevelManager.instance.LoadLevel(currentLevel);
        UIManager.instance.ShowPanel(false, false, true);
    }

    public void OnGameOver()
    {
        Destroy(GameObject.FindGameObjectWithTag("moon"));

        UIManager.instance.GameOverUI.SetActive(true);
    }

    public void ContinueLevel()
    {
        //TODO: show video ad
        StartGame();
    }

    public void OnPlayAgain()
    {
        currentLevel = 0;
        StartGame();
    }
}
