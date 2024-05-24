using System.Net.Http.Json;
using System.Text.Json;

namespace Nexo.UI.Util;

public static class HttpClientExtensions
{
    /// <summary>
    /// Asynchronously fetches data from the specified URI and deserializes it into the specified type.
    /// </summary>
    public static async Task<T?> FetchDataAsync<T>(this HttpClient httpClient, string requestUri)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<T>(requestUri);
        }
        catch (HttpRequestException httpEx)
        {
            Console.WriteLine($"Request error: {httpEx.Message}");
        }
        catch (NotSupportedException nsEx)
        {
            Console.WriteLine($"The content type is not supported: {nsEx.Message}");
        }
        catch (JsonException jsonEx)
        {
            Console.WriteLine($"JSON parse error: {jsonEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        return default;
    }
}