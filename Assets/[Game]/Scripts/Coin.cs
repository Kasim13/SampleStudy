using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void OnEnable()
    {
        CoinManager.Instance.AddCoin(this);
    }

    private void OnDisable()
    {
        CoinManager.Instance.RemoveCoin(this);
    }

    public void PickUpCoin()
    {
        EventManager.OnCoinPickUp.Invoke();
        Destroy(gameObject);
    }
}
