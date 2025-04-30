using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ClearDirector : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameSceneMove");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("GameSceneMove");
    }
}

