using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("1Main"); 
    }
}

// restart 에 연결하여 게임 재시작하기 위한 코드