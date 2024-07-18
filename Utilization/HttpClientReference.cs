using System.Net.Http.Json;

namespace Utilization;

public static class HttpClientReference
{
    public static T GetHttpClient<T>(string url) where T : class
    {
        var httpClient = new HttpClient();
        var result = httpClient.GetFromJsonAsync<T>(url);
        if (result != null) return result.Result;
        return null;
    }
}