using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using ModelLibrary;
using Newtonsoft.Json;

namespace ConsumeRest
{
    internal class RestConsumer
    {
        internal void Start()
        {
            IList<RestData> all = GetAll();
            foreach (RestData data in all)
            {
                //Console.WriteLine(data);
            }

            RestData one = GetOne(12);
            Console.WriteLine("ONE  \n" + one);
        }

        private const string URI = "https://jsonplaceholder.typicode.com/todos";
            private IList<RestData> GetAll()
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonContent = client.GetStringAsync(URI).Result;
                    IList<RestData> cList = JsonConvert.DeserializeObject<IList<RestData>>(jsonContent);
                    return cList;
                }
            }

        private RestData GetOne(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string jsonContent = client.GetStringAsync(URI+ "/"+ id).Result;
                RestData data = JsonConvert.DeserializeObject<RestData>(jsonContent);
                return data;
            }
        }


    }
}