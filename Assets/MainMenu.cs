using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } // Play button on Main Menu , when executed launches the next scene that is level 1 //

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    } // Exit button on Main Menu, when executed it closes the application //

}
