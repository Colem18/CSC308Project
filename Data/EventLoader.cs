using System;
using Newtonsoft.Json;
namespace eventsApp.Data
{
    public class EventLoader
    {
        HttpRestService _httprestservice = ServiceHelper.GetService<HttpRestService>();

    public async Task<List<Event>> GetEventsAsync()
        {
        List<Event> Items = new List<Event>();
        Uri uri = new Uri(string.Format("https://romaeventfunction.azurewebsites.net/api/event", string.Empty));
        Console.WriteLine(uri);
        try
        {
            HttpResponseMessage response = await _httprestservice._client.GetAsync(uri);
            //Console.WriteLine(response.IsSuccessStatusCode);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                //Items = JsonSerializer.Deserialize(content,_httprestservice._serializerOptions);
                Items = JsonConvert.DeserializeObject<List<Event>>(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(@"\tERROR {0}", ex.Message);
        }

        return Items;
    }
	}
}

