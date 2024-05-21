using System.Net.Http.Json;
using System.Text.Json;

using Nexo.UI.Models.Summary;

namespace Nexo.UI.Pages;

public partial class Home
{
    private Summary[]? _summary;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _summary = await Http.GetFromJsonAsync<Summary[]>("request/summaries.json");
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
    }
}
