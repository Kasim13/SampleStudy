using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Player player;
    public Player Player { get { return (player == null) ? player = GetComponent<Player>() : player; } }

    private void OnEnable()
    {
        Player.OnPlayerDamage.AddListener(Damage);
    }

    private void OnDisable()
    {
        Player.OnPlayerDamage.RemoveListener(Damage);
    }

    private void Damage(int damageValue)
    {
        Debug.Log("Vuruldummmm" + damageValue );
    }
}
