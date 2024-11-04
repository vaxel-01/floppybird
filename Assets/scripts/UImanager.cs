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
    public TextMeshProUGUI highScoreText;

    public GameObject gameOver0Screen; //default screen - to show if something goes wrong
    public GameObject gameOver1Screen;
    public GameObject gameOver2Screen;
    public GameObject gameOver3Screen;
    public GameObject gameStartScreen;
    public GameObject highScoreScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicScript.logic.onGamePlay.AddListener(StartingGame);
        LogicScript.logic.onGameOver.AddListener(GameOver);
        NewGame();
    }

    public void ScoreText(int score)
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        switch (LogicScript.logic.endingType)
        {
            case "golv":
                gameOver1Screen.SetActive(true);
                break;
            case "tak":
                gameOver2Screen.SetActive(true);
                break;
            case "blomma":
                gameOver3Screen.SetActive(true);
                break;
            default:
                gameOver0Screen.SetActive(true);
                break;
        } 
    }

    public void GameOverScreensOff()
    {
        //gameOverScreen.SetActive(true);
        gameOver0Screen.SetActive(false);
        gameOver1Screen.SetActive(false);
        gameOver2Screen.SetActive(false);
        gameOver3Screen.SetActive(false);
    }
    public void StartingGame()
    {
        gameStartScreen.SetActive(false);
        //gameOverScreen.SetActive(false);
        GameOverScreensOff();
        scoreText.gameObject.SetActive(true);
        scoreText.text = "0";
    }
    public void NewGame()
    {
        //gameOverScreen.SetActive(false);
        GameOverScreensOff();
        scoreText.gameObject.SetActive(false);
        gameStartScreen.SetActive(true);
        if (LogicScript.logic.highestScore != -0)
        {
            highScoreScreen.SetActive(true);
            highScoreText.text = LogicScript.logic.highestScore.ToString();
        }
    }

}
