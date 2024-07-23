using System.Net;

namespace DTOs;

public class Result<T>
{
    public HttpStatusCode statusCode { get; set; }
    public string? message { get; set; }
    public T? data { get; set; }

    public Result()
    {
    }
}