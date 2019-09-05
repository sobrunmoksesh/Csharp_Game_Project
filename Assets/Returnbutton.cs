using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Returnbutton : MonoBehaviour {

public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    } // to access menu when the menu button is clicked in level 1 or to play the previous level that is level 1 when
    //the person is actually in level 2 and wants to play the previous level.

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } // to restart the same level when the restart button is clicked in either level 1 or level 2

    public void Nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } // to go from level to level 2 when level 1 is completed.
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
} // to load the menu when the menu button is clicked in level 2
