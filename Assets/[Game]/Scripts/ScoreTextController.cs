using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    private Text scoreText;
    public Text ScoreText { get { return (scoreText == null) ? scoreText = GetComponent<Text>() : scoreText; } }

    private void OnEnable()
    {
        EventManager.OnCoinPickUp.AddListener(UpdateScoreText);
        EventManager.OnGameOver.AddListener(GameOverText);
    }

    private void OnDisable()
    {
        EventManager.OnCoinPickUp.RemoveListener(UpdateScoreText);
        EventManager.OnGameOver.RemoveListener(GameOverText);
    }

    private void UpdateScoreText()
    {
        int point = FindObjectOfType<Player>().point;
        ScoreText.text = "Score : " + point;
    }

    private void GameOverText()
    {       
        ScoreText.text = "GameOver";
    }
}
