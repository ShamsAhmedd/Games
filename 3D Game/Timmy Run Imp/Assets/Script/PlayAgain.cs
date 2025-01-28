using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("sampleScene");
    }
    public void doExitGame()
    {
        Application.Quit();
    }

}