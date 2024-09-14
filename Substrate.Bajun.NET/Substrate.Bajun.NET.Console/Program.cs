using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Substrate.Bajun.NET.Integration.Client;

class Program
{
    static async Task Main(string[] args)
    {
        // Configure Serilog for logging
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        // Set up a cancellation token for graceful shutdown
        CancellationTokenSource cts = new CancellationTokenSource();


        await MainAsync(cts.Token);

        // Keep the application alive to continue monitoring the connection
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        // Cleanup logging resources
        Log.CloseAndFlush();
    }

    private static async Task MainAsync(CancellationToken token)
    {
        // Create the client
        string substrateNodeUrl = "wss://rpc-parachain.bajun.network";
        var client = new BaseClient(substrateNodeUrl);

        // Subscribe to connection events
        client.Connected += OnConnected;
        client.Disconnected += OnDisconnected;

        // Try to ensure the client is connected with retries
        _ = await client.ConnectAsync(
            useMetadata: true,
            standardSubstrate: true,
            token: token,
            monitor: true,
            retryCount: 5,
            delayMilliseconds: 2000
        );


        while (!token.IsCancellationRequested)
        {
            try
            {
                // Check if the client is connected before making requests
                if (!client.IsConnected)
                {
                    Log.Warning("Client is not connected. Waiting for reconnection...");
                    await Task.Delay(5000); // Wait and retry
                    continue;
                }

                var currentBlocknumber = await client.SubstrateClient.SystemStorage.Number(null, token);
                Log.Information("MainAsync running... block: {blocknumber}", currentBlocknumber.Value);
            }
            catch (Exception ex)
            {
                Log.Error("Error in MainAsync: {Message}", ex.Message);
                Log.Information("Client reset!");
                client.Reset();
            }

            // Wait before next call
            await Task.Delay(12000);
        }

        // Gracefully shut down
        await client.DisconnectAsync();
        client.StopHeartbeat();
    }

    // Event handler when connected to the network
    private static void OnConnected(object sender, EventArgs e)
    {
        Log.Information("Connected to the network.");
    }

    // Event handler when disconnected from the network
    private static void OnDisconnected(object sender, EventArgs e)
    {
        Log.Information("Disconnected from the network.");
    }
}
