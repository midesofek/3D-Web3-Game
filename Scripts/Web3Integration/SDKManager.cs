using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;

public class SDKManager : MonoBehaviour
{
    public static SDKManager Instance;
    
    public ThirdwebSDK SDK;

    private void Awake() 
    {
        if (Instance != null) 
        {
            Destroy(gameObject);
        }
        else 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        SDK = new ThirdwebSDK("goerli");
    }
   
    void Update()
    {
        
    }
}
