using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Thirdweb;
using UnityEngine.SceneManagement;


public class ClaimManager : MonoBehaviour
{

    // void Start()
    // {
        
    // }
   
    // void Update()
    // {
        
    // }
    
    public void EnterMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public async Task ClaimNFT()
    {
        Contract contract = SDKManager.Instance.SDK.GetContract("0x8743315AFf1F2054Ea890f2c89cB5875cd49fb97");
        await contract.ERC721.Claim(1);
    }

    public async void Claim()
    {
        await ClaimNFT();
    }
}
