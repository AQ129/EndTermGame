using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject pauseCanvas;
    public bool isPaused = false;
    public GameObject YesQuit;
    public GameObject NoQuit;
    private void Start()
    {
        pauseCanvas.SetActive(false);
        YesQuit.SetActive(false);
        NoQuit.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        pauseCanvas.SetActive(false);
    }

    public void Pause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
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
        string nextScene = PlayerPrefs.GetString("SelectedMap");
        SceneManager.LoadScene(nextScene);
    }

}