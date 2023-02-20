using UnityEngine.UI;
using UnityEngine;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinTotalDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        coinTotalDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
