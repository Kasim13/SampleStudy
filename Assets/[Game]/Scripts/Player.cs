using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody;  } }
    public float MoveSpeed;
    public int point;


    public UnityEvent OnPlayerDamage = new UnityEvent();


    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        Rigidbody.velocity = input * MoveSpeed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
         Coin coin = other.GetComponent<Coin>();
        if(coin!= null)
        {
            point += 1 * GameManager.Instance.LevelCoinMultiplier;
            coin.PickUpCoin();
        }
    }

    public void DamagePlayer()
    {
        OnPlayerDamage.Invoke();
    }
}
