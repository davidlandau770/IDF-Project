//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Security.Policy;
//using System.Text;
//using System.Threading.Tasks;

//namespace IDF_Project
//{
//    public class RequestAPI
//    {
//        private readonly HttpClient _httpClient;
//        private readonly string _apiKey;
//        public RequestAPI(string apiKey)
//        {
//            _httpClient = new HttpClient();
//            _apiKey = apiKey;
//        }
//        public async Task<string> GetIntelAsync(string prompt)
//        {
//            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyB81pNm1vkl-POi2JKNl9n7PDqmzKH4eJ0";
//            var body = new
//            {
//                contents = new[]
//                {
//                    new
//                    {
//                        parts = new[]
//                        {
//                            new { text = prompt }
//                        }
//                    }
//                }
//            };
//            var json = JsonSerializer.Serialize(body);
//            var content = new StringContent(json, Encoding.UTF8, "application / json");
//            var response = await _httpClient.PostAsync(url, content);
//            response.EnsureSuccessStatusCode();
//            return await response.Content.ReadAsStringAsync();
//            //    public async Task SendHttpPOSTithHeaders()
//            //    {
//            //        HttpClient client = new HttpClient();
//            //        var data = new StringContent("{\"key\":\"value\"}", Encoding.UTF8, "Content-Type: application/json");
//            //        var postResponse = await client.PostAsync("https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyB81pNm1vkl-POi2JKNl9n7PDqmzKH4eJ0", data);
//            //        string content = await postResponse.Content.ReadAsStringAsync();
//            //        Console.WriteLine(content);
//        }
//    }
//}
