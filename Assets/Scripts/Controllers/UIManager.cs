using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject uplexaText;
    public GameObject uplexaLogo;

    public GameObject MainMenuUI;
    public GameObject GameOverUI;
    public GameObject GamePlayUI;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    /// <summary>
    /// Show and disable other UI panels
    /// </summary>
    public void ShowPanel(bool mainMenu, bool gameover, bool gameplay)
    {
        GameOverUI.SetActive(gameover);
        GamePlayUI.SetActive(gameplay);
        MainMenuUI.SetActive(mainMenu);
    }

    public void ShowMainMenu()
    {
        HideSplashScreen();
        GameOverUI.SetActive(false);
        GamePlayUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void HideSplashScreen()
    {
        uplexaLogo.SetActive(false);
        uplexaText.SetActive(false);
    }

}
