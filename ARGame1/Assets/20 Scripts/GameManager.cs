using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI drawText;
    public bool isDrawing = false;

    int i = 0;

    public void GameOver()
    {
        Application.Quit();
    }

    public void DrawButton()
    {
        i = (i + 1) % 2;
        if(i == 1)
        {
            drawText.text = "Stop";
            isDrawing = true;
        }
        else
        {
            drawText.text = "Draw";
            isDrawing = false;
        }
    }
}
