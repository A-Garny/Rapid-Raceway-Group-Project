using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button restartButtonAction;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI youWinText;
    public GameObject gameArea;
    public GameObject titleScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        //Starts the game
        gameArea.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        //Displays game over and lets you restart
        gameOverText.gameObject.SetActive(true);
        restartButtonAction.gameObject.SetActive(true);
    }

    public void YouWin()
    {
        //Displays you win and lets you restart
        youWinText.gameObject.SetActive(true);
        restartButtonAction.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        //Restarts game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
