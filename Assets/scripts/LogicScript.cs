using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LogicScript : MonoBehaviour
{
    //Makes calling functions from this script easier
    #region
    public static LogicScript logic;
    private void Awake()
    {
        if(logic == null)
        {
            logic = this;
        }
    }
    #endregion

    public int playerScore = 0;

    public bool isPlaying = false;
    public UnityEvent onGamePlay = new UnityEvent();
    public UnityEvent onGameOver = new UnityEvent();

    [Header("Game Objects")]
    public GameObject player;
    public GameObject pipeSpawner;

    public void StartGame()
    {
        onGamePlay.Invoke();
        isPlaying = true;
        player.SetActive(true);
        pipeSpawner.SetActive(true);
    }

    public void GameOver()
    {
        onGameOver.Invoke();
        isPlaying = false;
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        UImanager.ui.ScoreText(playerScore);
    }

    public void restartGame() //temp
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
