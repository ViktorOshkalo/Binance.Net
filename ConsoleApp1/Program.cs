using Binance.Net.Clients;
using Binance.Net.Objects.Options;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new BinanceRestClient();
            client.SetApiCredentials(new ApiCredentials(
                "72Xey7MqnjffYFRdshVU8sK6QyColbYsQHBLHGF7oKjfmBvsmiuvaNGRJGpCLOsA", 
                "DRASEqAL45vG4y2i8YXUEvIAN00JIvPEOkapy4NHX1AigUzYTvIfe47l6PHtt6uH"));
            client.ClientOptions.OutputOriginalData = true; 

            var res3 = await client.GeneralApi.CryptoLoans.GetFlexibleBorrowHistoryAsync();
            var res4 = await client.GeneralApi.CryptoLoans.GetFlexibleRepayHistoryAsync();
            var res5 = await client.GeneralApi.CryptoLoans.GetOpenBorrowOrdersAsync();
            

        }
    }
}
