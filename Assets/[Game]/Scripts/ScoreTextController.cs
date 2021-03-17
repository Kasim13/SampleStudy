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
    }

    private void OnDisable()
    {
        EventManager.OnCoinPickUp.RemoveListener(UpdateScoreText);
    }

    private void UpdateScoreText()
    {
        int point = FindObjectOfType<Player>().point;
        ScoreText.text = "Score : " + point;
    }

}
