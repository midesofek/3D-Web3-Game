using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBTC : MonoBehaviour
{
    public GameObject rewardCoin;

    void Update()
    {
        if (CollectableControl.coinCount >= 100)
        {
            rewardCoin.SetActive(true);
            // Debug.Log(CollectableControl.coinCount);
            
        }
    }
}
