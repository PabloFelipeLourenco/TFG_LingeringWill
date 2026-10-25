using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;


    public void OpenOptionsPanel(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

     public void OpenMainMenuPanel(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void PlayGame(){
        SceneManager.LoadScene(""); //MEter aqui el inicio del juego
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
