using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.session4;
using Newtonsoft.Json;

namespace ConsoleApp1.assignment4
{
    public class ApiAssignment4
    {
        {
            string url = "https://dummyjson.com/products/1";

        HttpClient client = new HttpClient();
        var rs = await client.GetAsync(url);
            if(rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
        Product p = JsonConvert.DeserializeObject<Product>(responseText);
                return p;
            }
            return null;
        }
    }
}
