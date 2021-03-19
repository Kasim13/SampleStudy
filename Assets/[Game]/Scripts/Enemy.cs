using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public void EnemyDestroy()
    {
        Destroy(gameObject);
    }
}
