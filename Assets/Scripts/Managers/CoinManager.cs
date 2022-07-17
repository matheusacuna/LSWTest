using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
     public int amountCoin;

    public void DecrementCoin(int value)
    {
        amountCoin -= value;
    }
}
