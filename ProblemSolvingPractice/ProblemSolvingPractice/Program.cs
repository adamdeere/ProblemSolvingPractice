using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProblemSolvingPractice;
using ProblemSolvingPractice.DataObjects;
using System;
using System.Collections;
internal class Program
{
    private static async Task Main(string[] args)
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        HttpClient client = new HttpClient();

        try
        {
            var response = await client.GetAsync(url);
            var responseMessage = await response.Content.ReadAsStringAsync();

            var comments = JsonConvert.DeserializeObject<Posts[]>(responseMessage);
          
            if (comments != null)
            {
                Array.Reverse(comments);
               
                Array.Sort(comments, (a, b) => (a.CompareTo(b)));
                foreach (var item in comments)
                {
                    Console.WriteLine(item.UserId  + " " + item.Title);
                }
            }
            
        }
        catch (Exception e)
        {

           Console.WriteLine(e.Message);
        }
        finally
        {
            client.Dispose();
        }
        int n = 15;
        Console.WriteLine(PowerDigitSum.TotalPower(n));
        Console.ReadLine();
    }
}