using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject restartButton;
    public Button restartButtonAction;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI youWinText;
    private GameObject gameArea;
    private GameObject titleScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        restartButton = GameObject.Find("Restart Button");
        restartButtonAction = restartButton.GetComponent<Button>();
        gameArea = GameObject.Find("Game Area");
        titleScreen = GameObject.Find("Title Screen");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        gameArea.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void YouWin()
    {
        youWinText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
