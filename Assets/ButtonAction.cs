using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public void MenuFunction()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GameFunction()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitFunction()
    {
        Application.Quit();
    }
}
