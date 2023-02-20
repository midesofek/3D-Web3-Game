using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class NinjaAlert : MonoBehaviour
{
    public GameObject ninjaWinAlert;

    // void Update()
    // {
    //     if (CollectableControl.coinCount >= 10)
    //     {
    //         Pop();
    //     }
         
    // }

    public async Task Pop()
    {
        if(CollectableControl.coinCount >= 12)
        {
            ninjaWinAlert.SetActive(true);
            Debug.Log("Task Delay Works");
            await Task.Delay(3000);
            ninjaWinAlert.SetActive(false);
        } 
    }
}
