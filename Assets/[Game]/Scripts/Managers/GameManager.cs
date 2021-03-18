using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnGameOver.AddListener(GameOver);
    }

    private void OnDisable()
    {
        EventManager.OnGameOver.RemoveListener(GameOver);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
}
