using UnityEngine.SceneManagement;
using UnityEngine;

public class OyunYoonetimi : MonoBehaviour
{
    // Start is called before the first frame update

    public bool oyunBittimi = false;
    public void GameOver()
    {
        if (oyunBittimi == false)
        {
            oyunBittimi = true;
            Debug.Log("Game Over Dude");
            RestartGame();
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("restartScene");
       
    }
}
    