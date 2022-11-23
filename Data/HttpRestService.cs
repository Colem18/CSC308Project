using System;
using System.Text.Json;

namespace eventsApp.Data
{
	public class HttpRestService
	{
        public HttpClient _client;
        public JsonSerializerOptions _serializerOptions;
        public HttpRestService()
		{
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
	}
}

