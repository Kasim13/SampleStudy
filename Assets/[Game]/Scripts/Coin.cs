using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnDestroy()
    {
        
    }




    private void OnEnable()
    {
        FindObjectOfType<CoinManager>().AddCoin(this);
    }

    private void OnDisable()
    {
        FindObjectOfType<CoinManager>().RemoveCoin(this);   
    }

    public void PickUpCoin()
    {
        EventManager.OnCoinPickUp.Invoke();
        Destroy(gameObject);
    }
}
