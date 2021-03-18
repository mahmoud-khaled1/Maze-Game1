using UnityEngine;
using UnityEngine.SceneManagement;
public class levelHandler : MonoBehaviour
{
    

    int checkPause = 0;
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public AudioSource ADsource;

    public void Level1()
    {

        SceneManager.LoadScene("Level 1");

    }
    public void SelectChar()
    {
        SceneManager.LoadScene("SelectCharMenu");
    }
    public void Quitt()
    {
        Application.Quit();

    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Pause()
    {
        if(checkPause==0)
        {
            Time.timeScale = 0;
            checkPause = 1;
            PauseButton.SetActive(false);
            ResumeButton.SetActive(true);
            ADsource.mute = true;
        }
        else if(checkPause==1)
        {
            Time.timeScale = 1;
            checkPause = 0;
            PauseButton.SetActive(true);
            ResumeButton.SetActive(false);
            ADsource.mute = false;

        }
    }
}


