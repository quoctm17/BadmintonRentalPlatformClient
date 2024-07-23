using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Utilization;

public static class HttpClientReference
{
    public static string URL = "https://localhost:7020/";
    public static T GetHttpClient<T>(string url) where T : class
    {
        var httpClient = new HttpClient();
        var result = httpClient.GetFromJsonAsync<T>(url);
        if (result != null) return result.Result;
        return null;
    }

    public static async Task<T> PostHttpClient<T>(string url, object data) where T : class
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(URL);
        var jsonObject = JsonSerializer.Serialize(data);
        var requestContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");
        var result = httpClient.PostAsync(url, requestContent).Result;
        var content = result.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<T>(content)!;
    }
}