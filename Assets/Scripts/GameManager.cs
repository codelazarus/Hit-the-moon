using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

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
    
}
