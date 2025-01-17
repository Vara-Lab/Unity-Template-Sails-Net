using UnityEngine;
using Substrate.NetApi.Model.Types.Primitive;

public class Balance : MonoBehaviour
{
    // The WebSocket URL for connecting to the test network of the Vara blockchain.
    private string url = "wss://testnet.vara.network";

    async void Start()
    {
        // Asynchronously fetch the account balance for the specified account address.
        // The address is provided in hex format.
        U128 balance = await BalanceService.GetAccountBalanceAsync(url, "0x3b3b98cb04c56d1a02da3a899f5495f0b5ccc8cb1e23bd3d0d5257126919dbcf");

        // Log the retrieved balance to the Unity console.
        // This is useful for debugging and verifying that the correct balance is retrieved.
        Debug.Log($"Result: {balance}");
    }
}