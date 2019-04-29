using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public GameObject startGameButton;

    private bool up;

	// Use this for initialization
	void Start () {
        startGameButton = GameObject.Find("Button");
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void onStartGameButtonClick()
    {
        SceneManager.LoadScene("Main");
    }
}
