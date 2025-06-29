using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject YesQuit;
    public GameObject NoQuit;
    // Start is called before the first frame update
    void Start()
    {
        YesQuit.SetActive(false);
        NoQuit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        YesQuit.SetActive(true);
        NoQuit.SetActive(true);
    }

    public void yesQuit()
    {
        Application.Quit();
    }

    public void noQuit()
    {
        YesQuit.SetActive(false);
        NoQuit.SetActive(false);
    }

    public void Resstart()
    {
        Time.timeScale = 1.0f;
        Time.timeScale = 1.0f;
        string nextScene = PlayerPrefs.GetString("SelectedMap");
        SceneManager.LoadScene(nextScene); ;
    }
}
