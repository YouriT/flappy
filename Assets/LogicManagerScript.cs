using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public const string Tag = "LogicManager";
    private int _playerScore = 0;
    public Text scoreDisplay;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void AddScore()
    {
        _playerScore++;
        scoreDisplay.text = $"{_playerScore}";
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
