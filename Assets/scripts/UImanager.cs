using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    #region
    public static UImanager ui;
    private void Awake()
    {
        if(ui == null)
        {
            ui = this;
        }
    }
    #endregion

    public TextMeshProUGUI scoreText;

    public GameObject gameOverScreen;
    public GameObject gameStartScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicScript.logic.onGamePlay.AddListener(StartingGame);
        LogicScript.logic.onGameOver.AddListener(GameOverScreen);
    }

    public void ScoreText(int score)
    {
        scoreText.text = score.ToString();
    }

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
    public void StartingGame()
    {
        gameStartScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        scoreText.gameObject.SetActive(true);
        scoreText.text = "0";
    }

}
