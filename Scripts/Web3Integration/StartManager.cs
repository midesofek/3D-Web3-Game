using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using Thirdweb;

public class StartManager : MonoBehaviour
{
    public GameObject connected;
    public GameObject disconnected;
    public GameObject enterBtn;
    public TMPro.TextMeshProUGUI addressTxt;
    public TMPro.TextMeshProUGUI ownsNFTTxt;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public async void ConnectWallet() 
    {
        string address = await SDKManager.Instance.SDK.wallet.Connect(new WalletConnection()
            {
                provider = WalletProvider.MetaMask,
                chainId = 5 // Switch the wallet Goerli on connection
            });

        addressTxt.text = address;

        connected.SetActive(true);
        disconnected.SetActive(false);

        await CheckBalance();
    }

    public async Task CheckBalance() 
    {
        Contract contract = SDKManager.Instance.SDK.GetContract("0x0dB40290F8122CFeB1f086601318e238692fDcDA");

        string balance = await contract.ERC721.Balance();

        float balanceFloat = float.Parse(balance);

        if (balanceFloat == 0) 
        {
            ownsNFTTxt.text = "Without your pass, you can't enter the Clan!";
            return; 
        } 

        ownsNFTTxt.text = "Welcome to the Game";
        enterBtn.SetActive(true);
    }

    public void EnterGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
