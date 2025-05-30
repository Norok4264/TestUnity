using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GoalEvent goalEventScript; // SoccerBall에 붙어있는 GoalEvent 스크립트 연결

    private int timeRemaining = 30;
    private bool isGameOver = false;

    void Start()
    {
        StartCoroutine(TimerCountdown());
    }

    IEnumerator TimerCountdown()
    {
        while (timeRemaining > 0)
        {
            timerText.text = timeRemaining.ToString();
            yield return new WaitForSeconds(1f);
            timeRemaining--;
        }

        timerText.text = "0";
        EndGame();
    }

    void EndGame()
    {
        if (isGameOver) return;

        isGameOver = true;

        int blueScore = goalEventScript.GetBlueScore();
        int redScore = goalEventScript.GetRedScore();

        if (blueScore > redScore)
        {
            SceneManager.LoadScene("BlueWin");
        }
        else if (redScore > blueScore)
        {
            SceneManager.LoadScene("RedWin");
        }
        else
        {
            SceneManager.LoadScene("Draw");
        }
    }
}