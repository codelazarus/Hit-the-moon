using UnityEngine;
using UnityEngine.UI;

public class LogoDissolve : MonoBehaviour
{
    public Text logoText;
    Material _material;
    float fade = 0f;
    float time = 0f;
    private bool isDissolving = true;
    bool triggerOnce = false;

    Color textColor;
    // Start is called before the first frame update
    void Start()
    {
        textColor = logoText.color;
        _material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDissolving)
        {
            fade += Time.deltaTime;
            if (fade >= 1f)
            {
                fade = 1f;
                isDissolving = false;
            }

            _material.SetFloat("_Fade", fade);
        }
        time += Time.deltaTime;
        if (time >= 1)
        {
            textColor.a = time - 1f;
            logoText.color = textColor;
            
            if (!triggerOnce)
            {
                triggerOnce = true;
                logoText.gameObject.SetActive(true);
            }
            if (time >= 2.5f)
                UIManager.instance.ShowMainMenu();
                    //UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);
        }
    }
}
