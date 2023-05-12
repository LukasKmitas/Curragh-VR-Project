using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject PlayButton;
    [SerializeField] private GameObject optionsButton;
    [SerializeField] private GameObject InstructionsButton;
    [SerializeField] private GameObject quitButton;

    public void Play()
    {
        SceneManager.LoadScene("GamePlayScene");
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
