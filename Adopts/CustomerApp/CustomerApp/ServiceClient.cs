using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace CustomerApp
{
    class ServiceClient
    {
        internal async static Task<List<string>> GetBreedNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>(
                    await lcHttpClient.GetStringAsync("http://localhost:60065/api/Data/GetBreedNames/"
                )
            );
        }

        internal async static Task<clsBreed> GetBreedAsync(string prBreedName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                string js = await lcHttpClient.GetStringAsync("http://localhost:60065/api/Data/GetBreed?BreedName=" + prBreedName);

                clsBreed b = JsonConvert.DeserializeObject<clsBreed>(js);
                return b;
            }
        }

        internal async static Task<string> InsertDragonAsync (clsAllDragons prDragon)
        {
            return await InsertOrUpdateAsync(prDragon, "http://localhost:60065/api/Data/PostDragon", "POST");
        }

        internal async static Task<string> UpdateDragonAsync(clsAllDragons prDragon)
        {
            return await InsertOrUpdateAsync(prDragon, "http://localhost:60065/api/Data/PutDragon", "PUT");
        }

        internal async static Task<string> DeleteDragonAsync(clsAllDragons prDragon)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                ($"http://localhost:60065/api/Data/DeleteDragon?DragonID={prDragon.DragonID}"); 
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<ICollection<clsAllOrders>> GetAllOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                string js = await lcHttpClient.GetStringAsync("http://localhost:60065/api/Data/GetAllOrders/");
                ICollection<clsAllOrders> o = JsonConvert.DeserializeObject<ICollection<clsAllOrders>>(js);
                return o;
            }
        }

        internal async static Task<int> GetSalesTotalAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<int>(
                    await lcHttpClient.GetStringAsync("http://localhost:60065/api/Data/GetSalesTotal/"
                )
            );
        }

        internal async static Task<string> InsertOrderAsync(clsAllOrders prOrder)
        {
            return await InsertOrUpdateAsync(prOrder, "http://localhost:60065/api/Data/PostOrder", "POST");
        }
        internal async static Task<string> UpdateOrderDragonAsync(clsAllDragons prDragon)
        {
            return await InsertOrUpdateAsync(prDragon, "http://localhost:60065/api/Data/PutOrderDragon", "PUT");
        }

        internal async static Task<string> DeleteOrderAsync(clsAllOrders prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                ($"http://localhost:60065/api/Data/DeleteOrder?OrderID={prOrder.OrderID}"); 
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }



        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Unicode, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }



        internal async static Task<clsAllDragons> GetDragonAsync(int prDragonID) // test
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                string js = await lcHttpClient.GetStringAsync("http://localhost:60065/api/Data/GetDragon?DragonID=" + prDragonID);
                clsAllDragons d = JsonConvert.DeserializeObject<clsAllDragons>(js);
                return d;
            }
        }
    }
}
