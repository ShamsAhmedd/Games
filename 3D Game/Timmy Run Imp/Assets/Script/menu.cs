using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void level2()
    {
        SceneManager.LoadScene("level2");
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void doExitGame()
    {
        Application.Quit();
    }
}
