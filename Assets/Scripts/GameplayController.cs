using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

    public static GameplayController instance;

    public GameObject GameOverUI;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void RestartLevel()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OnGameOver()
    {
        // show panel pause the game
        Debug.LogError("GAME OVER");
        GameOverUI.SetActive(true);
    }
}
