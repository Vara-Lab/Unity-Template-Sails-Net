using System;
using System.Threading;
using System.Threading.Tasks;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.Gear.Api.Generated.Storage;
using Substrate.Gear.Api.Generated.Model.sp_core.crypto;
using Substrate.Gear.Api.Generated.Model.frame_system;

public static class BalanceService
{
    private static SubstrateClient _client;
    private static string _currentUrl;

    /// <summary>
    /// Initializes the client and connects to the specified URL if not already connected.
    /// </summary>
    private static async Task InitializeClientAsync(string url)
    {
        if (_client == null || _currentUrl != url)
        {
            _currentUrl = url;
            _client = new SubstrateClient(new Uri(url), ChargeTransactionPayment.Default());
            await _client.ConnectAsync();
        }

        if (!_client.IsConnected)
        {
            throw new Exception("Client is not connected.");
        }
    }

    /// <summary>
    /// Retrieves the balance of the specified account.
    /// </summary>
    /// <param name="url">The URL of the node to connect to.</param>
    /// <param name="account">The account to retrieve the balance for.</param>
    /// <returns>The free balance of the account.</returns>
    public static async Task<U128> GetAccountBalanceAsync(string url, string account)
    {
        await InitializeClientAsync(url);

        // Convert the account string to AccountId32
        var account32 = new AccountId32();
        account32.Create(account);

        // Get the parameters needed to query account storage
        string parameters = SystemStorage.AccountParams(account32);



        // Query the account info from the storage asynchronously
        var accountInfo = await _client.GetStorageAsync<AccountInfo>(
            parameters,
            null,
            CancellationToken.None
        );

        if (accountInfo == null)
        {
            throw new Exception("Failed to retrieve account information.");
        }

        // Return the free balance of the account
        return accountInfo.Data.Free;
    }
}